string name = "John Smith";
int age = 23;
bool isAlive = true;
string phoneNumber = "+1 432-545-2873";

Console.WriteLine("First person information...");
Console.WriteLine();

if (isAlive)
{
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Is alive? {isAlive}");
    Console.WriteLine($"Phone number: {phoneNumber}");
}
else
{
    Console.WriteLine($"{name} is dead!");
}

Console.WriteLine();
Console.WriteLine("Second person information...");
Console.WriteLine();

name = "Mary Taylor";
age = 56;
isAlive = false;
phoneNumber = "+1 555-983-6213";

if (isAlive)
{
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Is alive? {isAlive}");
    Console.WriteLine($"Phone number: {phoneNumber}");
}
else
{
    Console.WriteLine($"{name} is dead!");
}