#include <ELECHOUSE_CC1101.h>
#include "DHT.h"          
const int DHTPIN = 4;      
const int DHTTYPE = DHT11;  
DHT dht(DHTPIN, DHTTYPE);
void setup() {
  Serial.begin(9600);
  dht.begin();
  ELECHOUSE_cc1101.Init(F_433);      
}
void loop() {
  
  float h = dht.readHumidity();    
  float t = dht.readTemperature(); 
  String tx_message = String(t)+ "|" + String(h);
  int m_length = tx_message.length();
  byte txbyte[m_length];
  tx_message.getBytes(txbyte, m_length + 1);  //m_length + 1: cộng thêm 1 byte địa chỉ
  Serial.println((char *)txbyte);
  ELECHOUSE_cc1101.SendData(txbyte, m_length);
  delay(1000);                     
}
