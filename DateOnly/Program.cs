// Date Only Variables
// only in .NET 6

DateOnly birthday = DateOnly.Parse(s: "8/20/1969");

Console.WriteLine(birthday.ToString(format: "MMM dd, yyyy"));
