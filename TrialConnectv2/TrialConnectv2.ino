String dataTerima;

void setup() {
  Serial1.begin(57600);
  pinMode(13, OUTPUT);

}

void loop() {
  if (Serial1.available() >0) {
    dataTerima = Serial1.readStringUntil('\n');

    if (dataTerima == "on") {
      digitalWrite(13, HIGH);
    }
    else if (dataTerima == "off") {
      digitalWrite(13, LOW);
    }
  }

}
