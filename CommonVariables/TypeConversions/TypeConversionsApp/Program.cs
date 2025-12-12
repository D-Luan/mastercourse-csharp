using System;

Console.WriteLine("What is your age: ");
string? ageText = Console.ReadLine();

//Console.WriteLine(ageText + 15);

//int age = int.Parse(ageText);

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

Console.WriteLine(age + 15);

double testDouble = age;
decimal testDecimal = (decimal)testDouble;

Console.WriteLine();
Console.Write("Enter a number: ");

string? numberText = Console.ReadLine();
int number = 0;

try
{
    number = int.Parse(numberText);
    Console.WriteLine($"Value in try-catch: {number}");
}
catch
{
    Console.WriteLine("ERROR catch");
}


bool isValidDouble = double.TryParse(numberText, out double exampleDouble);


if (isValidInt)
{
    Console.WriteLine("Value in if " + exampleDouble);
}
else
{
    Console.WriteLine("ERROR else");
}