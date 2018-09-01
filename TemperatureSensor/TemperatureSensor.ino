#include <DallasTemperature.h>
#include <OneWire.h>

#define SensorPin 3

OneWire oneWire(SensorPin);
DallasTemperature SensorSuhu(&oneWire);

float SuhuSekarang;

void setup() {
  Serial.begin(9600);
  SensorSuhu.begin();
}

void loop() {
  SuhuSekarang = AmbilSuhu();
  Serial.print("Suhu Sekarang : ");
  Serial.print(SuhuSekarang);
  Serial.println("C");
  delay(2000);

}

float AmbilSuhu() {
  SensorSuhu.requestTemperatures();
  float Suhu = SensorSuhu.getTempCByIndex(0);
  return Suhu;
}
