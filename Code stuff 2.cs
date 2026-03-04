Servo myservo;



void setup()
{
myservo.attach(9);
Serial.begin(9600);
}

void loop()
{
int deg = 20;
while(deg <= 180)
{
delay(500);
deg += 20;
}
deg = 160;
while(deg >= 0){
delay(500);
deg -= 20;
}
} 
