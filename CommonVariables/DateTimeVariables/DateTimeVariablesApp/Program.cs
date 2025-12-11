using System.Globalization;

// Display current data for all cultures
DateTime today = DateTime.Now;
string formatedDate = today.ToString("d/MM/yyyy", CultureInfo.InvariantCulture);

DateTime todayOnlyDate = today.Date;
//DateTime birthday = DateTime.Parse("6/11/1998");

//DateTime birthday = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(todayOnlyDate);

Console.WriteLine(formatedDate);

//Console.WriteLine(birthday);

Console.WriteLine(DateTime.Now.ToString("MMMM dd, yyyy HH:mm tt zzz"));

string todayOnlyHour = today.ToString("HH:mm");

Console.WriteLine(todayOnlyHour);