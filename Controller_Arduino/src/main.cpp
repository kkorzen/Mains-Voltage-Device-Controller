#include <Arduino.h>

#define POT A0
#define ZCD 2
#define OPTO_TRIAC_BUTTON 3
#define OPTO_TRIAC_ENABLE 9
#define OPTO_TRIAC 8
#define RELAY_1 6
#define RELAY_2 7

short pot_reading = 0;
int triac_delay = 9000;
int reading = 0, prev_reading = 0;
volatile bool is_zcd = false;

char c;
char d1;
String dataIn;

int counter = 0;
uint64_t remtime = 0;

void ISR_Dimm();

void setup() {
  // pinMode(ZCD, INPUT);
  pinMode(OPTO_TRIAC_BUTTON, INPUT_PULLUP);
  pinMode(OPTO_TRIAC, OUTPUT);
  pinMode(OPTO_TRIAC_ENABLE, OUTPUT);
  pinMode(RELAY_1, OUTPUT);
  pinMode(RELAY_2, OUTPUT);
  attachInterrupt(digitalPinToInterrupt(ZCD), ISR_Dimm, RISING);

  Serial.begin(115200);
  digitalWrite(RELAY_1, 0);
  digitalWrite(RELAY_2, 0);
}

void loop() {
  // pot_reading = analogRead(POT);
  // triac_delay = map(pot_reading, 0, 1023, 300, 9000);

  digitalWrite(OPTO_TRIAC_ENABLE, digitalRead(OPTO_TRIAC_BUTTON));

  while (Serial.available() > 0) {
    c = Serial.read();
    if (c == '\n') {
      Serial.println(dataIn);
      break;
    } else {
      dataIn += c;
    }
  }

  if (c == '\n') {
    switch (dataIn.charAt(0)) {
      case 'L':
        dataIn = dataIn.substring(1);
        triac_delay = dataIn.toInt();
        triac_delay = map(triac_delay, 300, 9000, 9000, 300);
        break;
      case 'A':
        digitalWrite(RELAY_2, 1);
        break;
      case 'a':
        digitalWrite(RELAY_2, 0);
        break;
      case 'B':
        digitalWrite(RELAY_1, 1);
        break;
      case 'b':
        digitalWrite(RELAY_1, 0);
        break;
      default:
        break;
    }
    c = 0;
    dataIn = "";
  }

  if (is_zcd == true) {
    delayMicroseconds(triac_delay);
    digitalWrite(OPTO_TRIAC, HIGH);
    delayMicroseconds(10);
    digitalWrite(OPTO_TRIAC, LOW);
    is_zcd = false;
    
  }
}

void ISR_Dimm() {
  is_zcd = true;
}
