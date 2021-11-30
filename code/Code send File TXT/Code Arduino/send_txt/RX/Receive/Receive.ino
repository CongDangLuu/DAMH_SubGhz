#include <ELECHOUSE_CC1101.h>

const int n = 135;

void setup()
{
  Serial.begin(9600);
  ELECHOUSE_cc1101.Init(F_433);
}

void loop()
{
  ELECHOUSE_cc1101.SetReceive();
  byte buffer[n] = "";
  String str = "";
  if (ELECHOUSE_cc1101.CheckReceiveFlag()) //Đọc trạng thái chân GD0
  {
    ELECHOUSE_cc1101.ReceiveData(buffer);
    String str((char*) buffer);
    Serial.print(str);
  }
}
