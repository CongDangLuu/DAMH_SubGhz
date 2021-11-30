#include <ELECHOUSE_CC1101.h>
void setup() {
  Serial.begin(9600);
  ELECHOUSE_cc1101.Init(F_433);
}
void loop()
{
  String tx_message = "";
  if (Serial.available()>0)
  {
    tx_message= Serial.readStringUntil('|');
    int m_length = tx_message.length();
    byte txbyte[m_length];
    tx_message.getBytes(txbyte, m_length + 1);  
    Serial.print((char *)txbyte);
    ELECHOUSE_cc1101.SendData(txbyte, m_length);
  }
}
