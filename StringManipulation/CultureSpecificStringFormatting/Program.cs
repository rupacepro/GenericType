
using System.Globalization;

DateTime today = DateTime.Now;
var currentCulture = CultureInfo.CurrentCulture;

DateTime lastDay = new DateTime(2025, 1, 2, 9, 32, 57);

CultureInfo.CurrentCulture = new CultureInfo("ne-NP"); // specific while showing the data to the user
Console.WriteLine(today.ToString("d"));

CultureInfo.CurrentCulture = new CultureInfo("en-US");
Console.WriteLine(today.ToString("d"));

Console.WriteLine(today.ToString("d", CultureInfo.InvariantCulture)); // while storing the data

Console.WriteLine(lastDay.ToString("D"));

Console.ReadKey();
