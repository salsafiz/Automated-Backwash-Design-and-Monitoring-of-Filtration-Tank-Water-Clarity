#include <ArduinoModbus.h>
#include <ArduinoRS485.h> //komunikasi serial RS485

void setup() {
  Serial.begin(9600); //baudrate


  // Inisialisasi Modbus RTU server
  if (!ModbusRTUServer.begin(2, 9600)) {
    Serial.println("Failed to start Modbus RTU Server!");
    while (1);
  }
  ModbusRTUServer.configureHoldingRegisters(1, 3);// Konfigurasi holding register untuk sensor kejernihan
}

void loop() {
  int val = analogRead(A0); //analog turbidity
  voltage = val*(5.0/1024);
  NTUkekeruhan = -2.9980 * val + 2294.2858;
  //Serial.println(NTUkekeruhan);

  // Simpan nilai sensor ke holding register
  ModbusRTUServer.holdingRegisterWrite(1, val);
  ModbusRTUServer.holdingRegisterWrite(2, voltage);
  ModbusRTUServer.holdingRegisterWrite(3, NTUkekeruhan);

  // Proses permintaan Modbus
  ModbusRTUServer.poll();
}