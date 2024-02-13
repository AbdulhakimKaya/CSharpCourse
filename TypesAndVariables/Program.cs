// value types

int number1 = -2147483648;
int number2 = 2147483647;

long number3 = -9223372036854775808;
long number4 = 9223372036854775807;

short number5 = -32768;
short number6 = 32767;

byte number7 = 0;
byte number8 = 255;

bool condition1 = false;
bool condition2 = true;

char character1 = 'A';

double number9 = 23.9;

decimal number10 = 23.9m;

var number11 = 10;
number11 = 'A';
// number11 = "A";  // error


Console.WriteLine("int type ranges from {0} to {1}", number1, number2);
Console.WriteLine("long type ranges from {0} to {1}", number3, number4);
Console.WriteLine("short type ranges from {0} to {1}", number5, number6);
Console.WriteLine("byte type ranges from {0} to {1}", number7, number8);
Console.WriteLine("bool type is {0} or {1}", condition1, condition2);
Console.WriteLine("character is {0}", character1);
Console.WriteLine("ascii equivalent of the character {0}", (int)character1);
Console.WriteLine("double number is {0}", number9);
Console.WriteLine("decimal number is {0}", number10);
Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);
Console.WriteLine((int)Days2.Tuesday);
Console.WriteLine((int)Days2.Friday);
Console.WriteLine("number11 is {0}", number11);

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

enum Days2
{
    Monday=10, Tuesday=15, Wednesday=20, Thursday, Friday, Saturday, Sunday
}