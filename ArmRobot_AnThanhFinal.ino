#include <Servo.h>

char incomingByte = 0;

Servo khop1;  //0-180
Servo khop2;  //96-180
Servo khop3;  //97-180 56-180
Servo khop4;  //10-45

int a[50][4];// 50 hang - 4 cot
int n = 0;

void setup() 
{
  Serial.begin(9600);
  khop1.attach(2);//0-180
  khop2.attach(3);//96-180
  khop3.attach(4);//97-180 56-180
  khop4.attach(5);//15-45
  servoPosition(90,100,140,79);// set toa do ban dau
}

void loop() 
{
  Serial.print("khop1 = ");
  Serial.print(khop1.read());
  Serial.print("  khop2 = ");
  Serial.print(khop2.read());
  Serial.print("  khop3 = ");
  Serial.print(khop3.read());
  Serial.print("  khop4 = ");
  Serial.println(khop4.read());

  if (Serial.available() > 0) 
  {
    incomingByte = Serial.read();
  }

  switch (incomingByte)
  {
    case '0':
      stopRobotArm();
      break;
    case 'a':
      quayTraiNBuoc(1, 1);
      break;
    case 'b':
      quayPhaiNBuoc(1, 1);
      break;
    case 'c':
      nangLenNBuoc(1,1);
      break;
    case 'd':
      haXuongNBuoc(1,1);
      break;
    case 'e':
      vuonRaNBuoc(1,1);
      break;
    case 'f':
      thuVaoNBuoc(1,1);
      break;
    case 'g':
      thaRaNBuoc(1,1);
      break;
    case 'h':
      kepVaoNBuoc(1,1);
      break;
    case 'i':
      luuGocTayRobot();
      break;
    case 'k':
      chayTuDong();
      break;
  }
}

void luuGocTayRobot()
{
  a[n][0] = khop1.read();
  a[n][1] = khop2.read();
  a[n][2] = khop3.read();
  a[n][3] = khop4.read();
  n++;
  incomingByte = '0';
}

void chayTuDong()
{
  for (int i = 0; i < n; i++)
  {
    khop1.write(a[i][0]);
    khop2.write(a[i][1]);
    khop3.write(a[i][2]);
    khop4.write(a[i][3]);
    delay(1000);
  }
}

void stopRobotArm()// canh tay dang o dau thi o yen do
{
  servoPosition(khop1.read(), khop2.read(), khop3.read(), khop4.read());
}

void quayTraiNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop1.write(khop1.read() + soBuoc * soDoTrongBuoc);
  delay(50);
}

void quayPhaiNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop1.write(khop1.read() - soBuoc * soDoTrongBuoc);
  delay(50);
}

void nangLenNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop2.write(khop2.read() - soBuoc * soDoTrongBuoc);
  delay(50);
}

void haXuongNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop2.write(khop2.read() + soBuoc * soDoTrongBuoc);
  delay(50);
}

void vuonRaNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop3.write(khop3.read() + soBuoc * soDoTrongBuoc);
  delay(50);
}

void thuVaoNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop3.write(khop3.read() - soBuoc * soDoTrongBuoc);
  delay(50);
}

void thaRaNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop4.write(khop4.read() - soBuoc * soDoTrongBuoc);
  delay(50);
}

void kepVaoNBuoc(int soBuoc, int soDoTrongBuoc)
{
  khop4.write(khop4.read() + soBuoc * soDoTrongBuoc);
  delay(50);
}

void thaRa()
{
  khop4.write(15);
}
void kepVao()
{
  khop4.write(45);
}
void vuonRa()
{
  khop3.write(180);
}
void thuVao()
{
  khop3.write(97);
}
void nangLen()
{
  khop2.write(100);
}
void haXuong()
{
  khop2.write(180);
}
void quayTrai()
{
  khop1.write(180);
}
void quayPhai()
{
  khop1.write(0);
}

void servoPosition (byte servo1, byte servo2, byte servo3, byte servo4)
{
  khop1.write(servo1);
  khop2.write(servo2);
  khop3.write(servo3);
  khop4.write(servo4);
}
