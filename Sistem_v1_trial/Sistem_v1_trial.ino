#include <Servo.h>
#include <TinyGPS++.h>
#include <DallasTemperature.h>
#include <OneWire.h>
#include <avr/pgmspace.h>
#include <EEPROM.h>

String data;
//inisialisasi port
#define sensorSuhuPin   2
#define kekeruhanAirPin A1
#define PHPin           A2
#define DOPin           A7
#define VREF 5000
#define ESC1            A4
#define ESC2            A3

//ESC
Servo esc1,esc2;
//

//GPS Module
//TinyGPS gps;
TinyGPSPlus gps;
float lt, ln;
//

//suhu air
OneWire oneWire(sensorSuhuPin);
DallasTemperature sensorSuhu(&oneWire);
float suhuSekarang;
//

//Kekeruhan Air
int ValueSensorKekeruhan;
float KekeruhanAir;
float TeganganSensorKekeruhan;
//

//PH air
float PHAir;
float TeganganSensorPH;
int ValuePhair;
//

//Dissolved Oxygen
float doValue;      //current dissolved oxygen value, unit; mg/L
float temperature = 25;    //default temperature is 25^C, you can use a temperature sensor to read it

#define EEPROM_write(address, p) {int i = 0; byte *pp = (byte*)&(p);for(; i < sizeof(p); i++) EEPROM.write(address+i, pp[i]);}
#define EEPROM_read(address, p)  {int i = 0; byte *pp = (byte*)&(p);for(; i < sizeof(p); i++) pp[i]=EEPROM.read(address+i);}

#define ReceivedBufferLength 20
char receivedBuffer[ReceivedBufferLength+1];    // store the serial command
byte receivedBufferIndex = 0;

#define SCOUNT  30           // sum of sample point
int analogBuffer[SCOUNT];    //store the analog value in the array, readed from ADC
int analogBufferTemp[SCOUNT];
int analogBufferIndex = 0,copyIndex = 0;

#define SaturationDoVoltageAddress 12          //the address of the Saturation Oxygen voltage stored in the EEPROM
#define SaturationDoTemperatureAddress 16      //the address of the Saturation Oxygen temperature stored in the EEPROM
float SaturationDoVoltage,SaturationDoTemperature;
float averageVoltage;

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
//

void setup() {
  Serial1.begin(57600);
  Serial.begin(115200);
  Serial3.begin(9600);
  sensorSuhu.begin();
  pinMode(DOPin,INPUT);
  esc1.attach(ESC1);//port    
  esc2.attach(ESC2);//port
  setting();
  readDoCharacteristicValues();
}
 
void loop() {
    //GPS Module
  while (Serial3.available() > 0){
    if (gps.encode(Serial3.read())){
    }
  }
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
  static unsigned long analogSampleTimepoint = millis();
  if(millis()-analogSampleTimepoint > 30U)     //every 30 milliseconds,read the analog value from the ADC
  {
    analogSampleTimepoint = millis();
    analogBuffer[analogBufferIndex] = analogRead(DOPin);    //read the analog value and store into the buffer
    analogBufferIndex++;
    if(analogBufferIndex == SCOUNT)
        analogBufferIndex = 0;
  }

  static unsigned long tempSampleTimepoint = millis();
  if(millis()-tempSampleTimepoint > 500U)  // every 500 milliseconds, read the temperature
  {
     tempSampleTimepoint = millis();
     //temperature = readTemperature();  // add your temperature codes here to read the temperature, unit:^C
  }

  static unsigned long printTimepoint = millis();
  if(millis()-printTimepoint > 1000U)
  {
     printTimepoint = millis();
     for(copyIndex=0;copyIndex<SCOUNT;copyIndex++)
     {
       analogBufferTemp[copyIndex]= analogBuffer[copyIndex];
     }
     averageVoltage = getMedianNum(analogBufferTemp,SCOUNT) * (float)VREF / 1024.0; 
     doValue = pgm_read_float_near( &SaturationValueTab[0] + (int)(SaturationDoTemperature+0.5) ) * averageVoltage / SaturationDoVoltage; 
  } 
  if (gps.location.isValid()) {
    lt = gps.location.lat();
    ln = gps.location.lng();
  }
  prints();
  if (Serial1.available() > 0) {
     data = Serial1.readStringUntil('\n');
     if (data == "A") {
       setSpeed(40); 
     }
     if (data == "B") {
       setSpeed(10); 
     }
  }
// delay(1);
}

void UpdateSuhu() {
  suhuSekarang = AmbilSuhu();
}

float AmbilSuhu() {
  sensorSuhu.requestTemperatures();
  float Suhu = sensorSuhu.getTempCByIndex(0);
  return Suhu;
}

void doCalibration(byte mode)
{
    char *receivedBufferPtr;
    static boolean doCalibrationFinishFlag = 0,enterCalibrationFlag = 0;
    float voltageValueStore;
    switch(mode)
    {
      case 0:
      if(enterCalibrationFlag)
         //Serial.println(F("Command Error"));
      break;

      case 1:
      enterCalibrationFlag = 1;
      doCalibrationFinishFlag = 0;
      // Serial.println();
      // Serial.println(F(">>>Enter Calibration Mode<<<"));
      // Serial.println(F(">>>Please put the probe into the saturation oxygen water! <<<"));
      // Serial.println();
      break;

     case 2:
      if(enterCalibrationFlag)
      {
         // Serial.println();
         // Serial.println(F(">>>Saturation Calibration Finish!<<<"));
         // Serial.println();
         EEPROM_write(SaturationDoVoltageAddress, averageVoltage);
         EEPROM_write(SaturationDoTemperatureAddress, temperature);
         SaturationDoVoltage = averageVoltage;
         SaturationDoTemperature = temperature;
         doCalibrationFinishFlag = 1;
      }
      break;

        case 3:
        if(enterCalibrationFlag)
        {
            // Serial.println();
            //if(doCalibrationFinishFlag)
               // Serial.print(F(">>>Calibration Successful"));
            //else
            //   Serial.print(F(">>>Calibration Failed"));
            // Serial.println(F(",Exit Calibration Mode<<<"));
            // Serial.println();
            doCalibrationFinishFlag = 0;
            enterCalibrationFlag = 0;
        }
        break;
    }
}

int getMedianNum(int bArray[], int iFilterLen)
{
      int bTab[iFilterLen];
      for (byte i = 0; i<iFilterLen; i++)
      {
    bTab[i] = bArray[i];
      }
      int i, j, bTemp;
      for (j = 0; j < iFilterLen - 1; j++)
      {
    for (i = 0; i < iFilterLen - j - 1; i++)
          {
      if (bTab[i] > bTab[i + 1])
            {
    bTemp = bTab[i];
          bTab[i] = bTab[i + 1];
    bTab[i + 1] = bTemp;
       }
    }
      }
      if ((iFilterLen & 1) > 0)
  bTemp = bTab[(iFilterLen - 1) / 2];
      else
  bTemp = (bTab[iFilterLen / 2] + bTab[iFilterLen / 2 - 1]) / 2;
      return bTemp;
}

void readDoCharacteristicValues(void)
{
    EEPROM_read(SaturationDoVoltageAddress, SaturationDoVoltage);
    EEPROM_read(SaturationDoTemperatureAddress, SaturationDoTemperature);
    if(EEPROM.read(SaturationDoVoltageAddress)==0xFF && EEPROM.read(SaturationDoVoltageAddress+1)==0xFF && EEPROM.read(SaturationDoVoltageAddress+2)==0xFF && EEPROM.read(SaturationDoVoltageAddress+3)==0xFF)
    {
      SaturationDoVoltage = 1127.6;   //default voltage:1127.6mv
      EEPROM_write(SaturationDoVoltageAddress, SaturationDoVoltage);
    }
    if(EEPROM.read(SaturationDoTemperatureAddress)==0xFF && EEPROM.read(SaturationDoTemperatureAddress+1)==0xFF && EEPROM.read(SaturationDoTemperatureAddress+2)==0xFF && EEPROM.read(SaturationDoTemperatureAddress+3)==0xFF)
    {
      SaturationDoTemperature = 25.0;   //default temperature is 25^C
      EEPROM_write(SaturationDoTemperatureAddress, SaturationDoTemperature);
    }
}

void setting() {
  setSpeed(30); 
  delay(2000);
  
  setSpeed(90);
  delay(2000);
  
  setSpeed(30);
  delay(2000);
}

void setSpeed(int speed) {
  int angle = map(speed, 0, 100, 0, 180);
  esc1.write(angle);
}

void prints() {
  Serial1.print("I");
  Serial1.print(",");
  Serial1.print(suhuSekarang);
  Serial1.print(",");
  Serial1.print(KekeruhanAir);
  Serial1.print(",");
  Serial1.print(PHAir);
  Serial1.print(",");
  Serial1.print(doValue);
  Serial1.print(",");
  Serial1.print(lt, 6);
  Serial1.print(F(","));
  Serial1.println(ln, 6);
}



