// Date Only Variables
// only in .NET 6

DateTime today= DateTime.Now;

DateOnly birthday = DateOnly.Parse(s: "8/20/1969");

Console.WriteLine(birthday.ToString(format: "MMM dd, yyyy"));

Console.WriteLine(value: $"Today full format: {today}");
Console.WriteLine(value: $"Today just date: {today.Date}");
Console.WriteLine(value: $"Birthday full format: {birthday.ToString()}");