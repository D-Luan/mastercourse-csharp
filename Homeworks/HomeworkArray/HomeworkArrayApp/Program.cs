string[] firstName = new string[] { "Smith", "John", "Mary" };

string? numberText = string.Empty;
bool isValidNumber = false;
int number = 0;

do
{
    Console.Write("Enter a number to verify a name: ");
    numberText = Console.ReadLine();

    isValidNumber = int.TryParse(numberText, out number);

    if (isValidNumber == false)
    {
        Console.WriteLine("Invalid Number. Enter a valid number.");
    }

    if (number > (firstName.Length - 1))
    {
        Console.WriteLine("Invalid number. Enter a number between 0 and 2.");
    }
    
} while (isValidNumber == false || number > (firstName.Length - 1));

Console.WriteLine($"Name stored in number {number}: {firstName[number]}");