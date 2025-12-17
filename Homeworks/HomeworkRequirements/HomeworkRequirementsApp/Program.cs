Console.WriteLine("----Welcome to the Application----");
Console.WriteLine();

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

string? ageText;
bool isAgeValid;
int age;

do
{
	Console.Write("Enter your age: ");
	ageText = Console.ReadLine();
	isAgeValid = int.TryParse(ageText, out age);

	if (!isAgeValid)
	{
		Console.WriteLine("Invalid Number! Please enter a valid number.");
	}

	if (age < 0 || age > 120)
	{
        Console.WriteLine("Invalid age! Please enter a valid age.");
	}

} while (!isAgeValid || (age < 0 || age > 120));

int ageForNonStudents = Math.Abs(age - 21);

if (age < 21)
{
    Console.WriteLine($"{name}, recommend you wait {ageForNonStudents} years to start this class.");
	Environment.Exit(0);
}


if ((name.ToLower() == "bob") || (name.ToLower() == "sue"))
{
    Console.WriteLine($"How you doing, Professor {name}? I hope you are well.");
}
else
{
    Console.WriteLine($"How you doing, Student {name}? I hope you are well.");
}