#include <Servo.h>
Servo myservo; 

// RFID
#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN 53
#define RST_PIN 5

MFRC522 mfrc522(SS_PIN, RST_PIN);

// Ultrasonic Sensor
#define trigPin A2
#define echoPin A1

// LCD
#include <LiquidCrystal_I2C.h>  
LiquidCrystal_I2C lcd(0x27, 16, 2);  // set the LCD address to 0x27 for a 16 chars and 2 line display

// RGB
#define R 40
#define G 41
#define B 42

// defines variables
long duration;
int distance;

// Receiving Variables
String gateCtrl;
String lStat;
String remoteGate;

// Lights
#define lights 30
#define LDR 47
bool automatic_lights;

// Define the list of UIDs
byte knownUIDs[][4] = {
  {0x83, 0x56, 0xD7, 0x0F},
  {0x23, 0xF1, 0xB0, 0x0D},
  {0xE6, 0x23, 0xFF, 0x03} ,
  {0x4E, 0x90, 0x66, 0x3F}
};


void setup() {
  Serial.begin(9600); // Starts the serial communication

  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input

  pinMode(lights, OUTPUT);
  pinMode(LDR, INPUT);

  myservo.attach(23);  // attaches the servo on pin 9 to the servo object

  SPI.begin();      
  mfrc522.PCD_Init();

  lcd.init();       // initialize the LCD 
  lcd.backlight();

  pinMode(R, OUTPUT);   // Initialize the digital pin as an output
  pinMode(B, OUTPUT); // Initialize the digital pin as an output
  pinMode(G, OUTPUT);  // Initialize the digital pin as an output

  gateClosed();
  automatic_lights = true;
}

void loop(){
  if (automatic_lights) {
    autoLights();
  }

  if(Serial.available() > 0){
    String command = Serial.readStringUntil('\n'); // Read the command from Serial
    command.trim(); // Remove leading and trailing whitespaces

    if(command.equals("UP")){
      gateOpen();
    }
    else if(command.equals("DOWN")){
      gateClosed();
    }
    else if(command.equals("AUTO")){
      autoLights();
    }
    else if(command.equals("ON")){
      automatic_lights = false; 
      lightOn();
    }
    else if(command.equals("OFF")){
      automatic_lights = false; 
      lightOff();
    } 

  }
  
  // carPresence();

  if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()) {
    if (isKnownUID(mfrc522.uid.uidByte)) {
      Serial.println("known");
      gateOpen();
      delay(2000);
    }else{
      Serial.println("unknown");
    }
  }

  if (mfrc522.PICC_IsNewCardPresent() && mfrc522.PICC_ReadCardSerial()) {
    if (isKnownUID(mfrc522.uid.uidByte)) {
      Serial.println("known");
      gateOpen();
      delay(2000);
    }else{
      Serial.println("unknown");
    }
  }
}


// Light Control
void lightOn(){
    digitalWrite(lights, HIGH);
    Serial.println("ON");
}

void lightOff(){
    digitalWrite(lights, LOW);
    Serial.println("OFF");
}

void autoLights(){
  automatic_lights = true; 
  int lightAmount = digitalRead(LDR);

  if(lightAmount == HIGH){
    lightOn();
  }else{
    lightOff();
  }  
}

// Barrier - UP or DOWN
void gateControl(){
  if(Serial.available() > 0)
  {
    gateCtrl = Serial.readStringUntil('\n'); // Read until newline character
    gateCtrl.trim(); // Remove leading and trailing whitespaces

    if(gateCtrl.equals("UP"))
      gateOpen();
    else if(gateCtrl.equals("DOWN"))
      gateClosed();
  }
}

void gateClosed(){
  digitalWrite(R, HIGH);
  lcd.clear();                  // clear the screen
  lcd.setCursor(5, 1);          // set the cursor to the top-left corner
  lcd.print("STOP!");           // print "STOP!" to the LCD

  Serial.println("DOWN");
  myservo.write(90);
  setColor(255, 0, 0);
}

void gateOpen(){
  digitalWrite(G, HIGH);

  delay(50);
  Serial.println("UP");
  myservo.write(45);
  setColor(0, 255, 0);

  lcd.clear();                  // clear the screen
  lcd.setCursor(3, 1);          // set the cursor to the top-left corner
  lcd.print("WELCOME!");        // print "WELCOME!" to the LCD

  delay(2500);

  carPresence();
}

void setColor(int redValue, int greenValue, int blueValue) {
  analogWrite(R, redValue);     // Set the brightness of the red LED
  analogWrite(G, greenValue); // Set the brightness of the green LED
  analogWrite(B, blueValue);   // Set the brightness of the blue LED
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

  if (distance >= 9){
    gateClosed();
  }
}

// RFID Validation
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