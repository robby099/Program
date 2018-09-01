float Kekeruhan;
float Tegangan;

void setup() {
  Serial.begin(9600);
}

void loop() {
  int Value   = analogRead(A0);
  Tegangan    = Value * (5.0 / 1024);
  Kekeruhan   = 100.00 - (Tegangan / 4.16) * 100.00; // 4.16 adalah hasil Tegangan sensor saat pembacaan air jernih

  Serial.print("Tegangan Sensor : ");
  Serial.print(Tegangan);
  Serial.print("     ");
  Serial.print("Nilai ADC : ");
  Serial.print(Value);
  Serial.print("     ");
  Serial.print("Nilai Kekeruhan Air : ");
  Serial.print(Kekeruhan);
  Serial.println(" NTU");
  delay(300);

}
