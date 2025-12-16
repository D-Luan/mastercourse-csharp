Console.Write("What is your name? ");
string? name = string.Empty;

try
{
    name = Console.ReadLine();
}
catch
{
    Console.WriteLine("Invalid name!");
}

if (name.ToLower() == "tim") 
{
    Console.WriteLine($"Welcome Professor {name}!");
}
else
{
    Console.WriteLine($"Welcome student {name}!");
}