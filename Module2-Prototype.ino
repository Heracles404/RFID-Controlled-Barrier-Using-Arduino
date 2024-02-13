#include <Servo.h>
Servo myservo; 

// RFID
#include <SPI.h>
#include <MFRC522.h>

#define RFID_POWER 48
#define SS_PIN 53
#define RST_PIN 5

MFRC522 mfrc522(SS_PIN, RST_PIN);

// Ultrasonic Sensor
#define trigPin A0
#define echoPin A1

// RGB
#define R 12
#define G 11
#define B 10

// Receiving Variables
String gateCtrl;

// defines variables
long duration;
int distance;


// Define the list of UIDs
byte knownUIDs[][4] = {
  {0x83, 0x56, 0xD7, 0x0F}, // card
  {0x23, 0xF1, 0xB0, 0x0D},  // keychain
};


void setup() {
  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input
  Serial.begin(9600); // Starts the serial communication


  myservo.attach(13);  // attaches the servo on pin 9 to the servo object


  SPI.begin();      
  mfrc522.PCD_Init();

  pinMode(RFID_POWER, OUTPUT);   // Initialize the digital pin as an output

  pinMode(R, OUTPUT);   // Initialize the digital pin as an output
  pinMode(B, OUTPUT); // Initialize the digital pin as an output
  pinMode(G, OUTPUT);  // Initialize the digital pin as an output

  setColor(255, 0, 0);
}
void loop() {

  if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()) {
    if (isKnownUID(mfrc522.uid.uidByte)) {
      Serial.println("known");
      gateOpen();
      delay(2000);
    }else{
      Serial.println("unknown");
    }
  }


  if(Serial.available() > 0){
    gateCtrl = Serial.readString();
    Serial.println(gateCtrl);

    while(gateCtrl == 'LOCKED')
      digitalWrite(RFID_POWER, LOW);

    if(gateCtrl == 'UNLOCKED')
      digitalWrite(RFID_POWER, HIGH);
      if(gateCtrl == 'UP')
        gateOpen();
      else if(gateCtrl == 'DOWN')
        gateClosed();
  }
}


// check if the scanned UID matches any of the known UIDs
bool isKnownUID(byte *uid) {
  // Compare the scanned UID with each known UID
  for (byte i = 0; i < sizeof(knownUIDs) / sizeof(knownUIDs[0]); i++) {
    if (compareUID(uid, knownUIDs[i], sizeof(knownUIDs[i]))) {
      return true; // UID matches a known UID
    }
  }
  return false; // UID doesn't match any known UID
}


// to compare two UIDs byte by byte
bool compareUID(byte *uid, byte *knownUID, byte size) {
  for (byte i = 0; i < size; i++) {
    if (uid[i] != knownUID[i]) {
      return false; // UID doesn't match
    }
  }
  return true; // UID matches
}


void carPresence(){
  // Clears the trigPin
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration = pulseIn(echoPin, HIGH);
  // Calculating the distance
  distance = duration * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  // Serial.print("Distance: ");
  // Serial.println(distance);


  if (distance > 20){
    gateClosed();
  }
}


void gateOpen(){
  Serial.println("UP");
  myservo.write(90);
  setColor(0, 255, 0);
  
  carPresence();
}

void gateClosed(){
  delay(2000);
  Serial.println("DOWN");
  myservo.write(0);
  setColor(255, 0, 0);
}


// Function to set the RGB LED color
void setColor(int redValue, int greenValue, int blueValue) {
  analogWrite(R, redValue);     // Set the brightness of the red LED
  analogWrite(G, greenValue); // Set the brightness of the green LED
  analogWrite(B, blueValue);   // Set the brightness of the blue LED
}