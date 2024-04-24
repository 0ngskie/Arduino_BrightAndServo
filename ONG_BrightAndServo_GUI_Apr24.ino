#include <Servo.h>
Servo myServo;

int led01 = 3;
int led02 = 5;

String Data;
char d1;
String x;
int servoVal;
int ledVal;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  
  myServo.attach(A5);
  
  pinMode(led01, OUTPUT);
  pinMode(led02, OUTPUT);
  
}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available()){
    Data = Serial.readString();
    d1 = Data.charAt(0);
    switch(d1){

      // servo Controller
      case 'S':
      x = Data.substring(1);
      servoVal = x.toInt();
      myServo.write(servoVal);
      break;

      // LED Brightness Controller
      case 'B':
      x = Data.substring(1);
      ledVal = x.toInt();
      analogWrite(led01, ledVal);
      analogWrite(led02, ledVal);
      break;
    }
  }
}
