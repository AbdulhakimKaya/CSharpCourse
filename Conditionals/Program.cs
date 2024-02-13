var number = 9;

// if else
if (number == 10)
{
    Console.WriteLine("number is 10");
}
else if (number == 12)
{
    Console.WriteLine("number is 12");
}
else
{
    Console.WriteLine("number is not 10");
}

// single line if
Console.WriteLine(number == 10 ? "number is 10" : "number is not 10");

// switch case
switch (number)
{
   case 10:
       Console.WriteLine("number is 10");
       break;
   case 12:
       Console.WriteLine("number is 12");
       break;
   default:
       Console.WriteLine("number is not 10 or 12");
       break;
}


// example
if (number >= 0 && number <= 100)
{
    Console.WriteLine("number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("number is between 100-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("number is less than 0 or greater than 200");
}


// nested if
if (number < 100)
{
    if (number >= 90 && number <95)
    {
        Console.WriteLine(number);
    }

    if (number < 0)
    {
        Console.WriteLine(number);
    }
}