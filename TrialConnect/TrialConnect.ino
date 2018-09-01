void setup() {
  Serial.begin(57600);
}

void loop() {
// if (Serial.available() > 0) {
//   serial = Serial.read();
// }
 
 Serial.println(DLE);
 delay(1000);

}
