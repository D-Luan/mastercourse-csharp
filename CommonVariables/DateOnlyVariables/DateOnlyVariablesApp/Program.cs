
DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("6/11/1998");

Console.WriteLine(birthday.ToString("MMMM dd, yyyy"));

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");

DateOnly currentDate = DateOnly.FromDateTime(DateTime.UtcNow);
Console.WriteLine(currentDate);