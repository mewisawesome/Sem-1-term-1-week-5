const int In1 = 9;
const int EnA = 10; 
const int In2 = 8;

void setup()

{
  pinMode(In1, OUTPUT);
  pinMode(In2, OUTPUT);
  pinMode(EnA, OUTPUT); 
}

void goStraight()   

{
  digitalWrite(In1, HIGH);
  digitalWrite(In2, LOW);
  delay(2000);
  digitalWrite(In1, LOW);
  digitalWrite(In2, LOW);  
  analogWrite(EnA, 200);
}

void loop()

{
  goStraight()
  delay(1000);
}
