#include <SD.h>
#include <Wire.h>
#include <Adafruit_MCP4725.h>

const int arrSize = 500;
File myFile;
word mem[arrSize];
int charSize[10];

Adafruit_MCP4725 dacx;
Adafruit_MCP4725 dacy;

void setup()
{
  Serial.begin(9600);
  Serial.print("Initializing SD card...");
  // On the Ethernet Shield, CS is pin 4. It's set as an output by default.
  // Note that even if it's not used as the CS pin, the hardware SS pin 
  // (10 on most Arduino boards, 53 on the Mega) must be left as an output 
  // or the SD library functions will not work. 
   pinMode(10, OUTPUT);
 
  if (!SD.begin(10)) {
    Serial.println("initialization failed!");
    return;
  }
  Serial.println("initialization done.");
 
  // open the file for reading:
  myFile = SD.open("laser.dat");
  
  while(!myFile){
    Serial.println("ERROR: File did not open");
    myFile = SD.open("laser.dat");
  }
    
    
} 
//    Serial.println("test.txt:");
// 
//    // read from the file until there's nothing else in it:
//    while (myFile.available()) {
//        mem.append
//    	Serial.write(myFile.read());
//    }
//    // close the file:
//    myFile.close();
//  } else {
//  	// if the file didn't open, print an error:
//    Serial.println("error opening test.txt");
//  }

boolean getNextTen(){
  
}

boolean dispLayLoop(){
}
 
void loop(){
  // Place the next 10 characters into the array
  
  // Display the characters

    
}
