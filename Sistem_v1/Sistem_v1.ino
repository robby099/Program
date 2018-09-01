#include <DallasTemperature.h>
#include <OneWire.h>

//inisialisasi port
#define sensorSuhuPin   2
#define kekeruhanAirPin A1
#define PHPin           A2
#define DOPin           A3

//suhu air
OneWire oneWire(sensorSuhuPin);
DallasTemperature sensorSuhu(&oneWire);
float suhuSekarang;

//Kekeruhan Air
int ValueSensorKekeruhan;
float KekeruhanAir;
float TeganganSensorKekeruhan;

//PH air
float PHAir;
float TeganganSensorPH;
int ValuePhair;

//Dissolved Oxygen
float SaturationDoVoltage, averageVoltage;
int ValueSensorDo;
float DOAir;
const float SaturationValueTab[41] PROGMEM = {      //saturation dissolved oxygen concentrations at various temperatures
14.46, 14.22, 13.82, 13.44, 13.09,
12.74, 12.42, 12.11, 11.81, 11.53,
11.26, 11.01, 10.77, 10.53, 10.30,
10.08, 9.86,  9.66,  9.46,  9.27,
9.08,  8.90,  8.73,  8.57,  8.41,
8.25,  8.11,  7.96,  7.82,  7.69,
7.56,  7.43,  7.30,  7.18,  7.07,
6.95,  6.84,  6.73,  6.63,  6.53,
6.41,
};

void setup() {
  Serial1.begin(57600);
  Serial.begin(9600);
  sensorSuhu.begin();
}

void loop() {
  //suhu
  suhuSekarang = AmbilSuhu();
  //Kekeruhan air
  ValueSensorKekeruhan      = analogRead(kekeruhanAirPin);
  TeganganSensorKekeruhan   = ValueSensorKekeruhan * (5.0 / 1024);
  KekeruhanAir              = 100.00 - (TeganganSensorKekeruhan / 4.16) * 100.00 ;
  //Ph Air
  ValuePhair        = analogRead(PHPin);
  TeganganSensorPH  = ValuePhair * (5.0 / 1024);
  PHAir             = 7.00 + ((2.6 - TeganganSensorPH) / 0.17);
  //Dissolved Oxygen
  ValueSensorDo   = analogRead(DOPin);
  averageVoltage  = ValueSensorDo / (5.0 * 1023);
  DOAir           = pgm_read_float_near(&SaturationValueTab[0] + (int)(suhuSekarang+0.5)) / averageVoltage;

  //
  Serial1.print("I");
  Serial1.print(",");
  Serial1.print(suhuSekarang);
  Serial1.print(",");
  Serial1.print(KekeruhanAir);
  Serial1.print(",");
  Serial1.print(PHAir);
  Serial1.print(",");
  Serial1.println(DOAir);

  delay(1000);
}

void UpdateSuhu() {
  suhuSekarang = AmbilSuhu();
  //Serial1.println(suhuSekarang);
  //delay(2000);
}

float AmbilSuhu() {
  sensorSuhu.requestTemperatures();
  float Suhu = sensorSuhu.getTempCByIndex(0);
  return Suhu;
}

void UpdateKekeruhanAir() {
  ValueSensorKekeruhan      = analogRead(kekeruhanAirPin);
  TeganganSensorKekeruhan   = ValueSensorKekeruhan * (5.0 / 1024);
  KekeruhanAir              = 100.00 - (TeganganSensorKekeruhan / 4.16) * 100.00 ; //  4.16 adalah hasil Tegangan sensor saat pembacaan air jernih
  //Serial1.println(KekeruhanAir);
  //delay(500);
}
