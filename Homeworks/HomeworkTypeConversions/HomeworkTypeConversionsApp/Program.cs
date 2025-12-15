bool ageIsValid;
int age;
bool ageValidation;

do
{
	Console.Write("Enter your age: ");
	string? ageText = Console.ReadLine();

	ageIsValid = int.TryParse(ageText, out age);

    ageValidation = !ageIsValid || (age < 0 || age > 120);

    if (ageValidation)
    {
		Console.WriteLine("Invalid number! Please enter a valid number.");
	}

} while (ageValidation);

Console.WriteLine($"You would be {age + 25} in 25 years, and 25 years ago, you were {age - 25}");