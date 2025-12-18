
string answer;

do
{
    Console.Write("Enter your name: ");
    string? firstName = Console.ReadLine();
    
    if (firstName.ToLower() == "tim")
    {
        firstName = $"Professor {firstName}";
    }
    else
    {
        firstName = $"Student {firstName}";
    }

    Console.WriteLine($"Welcome me {firstName}.");

    Console.Write("Exit or Continue? ");
    answer = Console.ReadLine();
} while (answer.ToLower() != "exit");

Console.WriteLine("End of Application");