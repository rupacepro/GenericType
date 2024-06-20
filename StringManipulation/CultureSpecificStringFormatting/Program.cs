
using System.Globalization;

DateTime today = DateTime.Now;
var currentCulture = CultureInfo.CurrentCulture;
CultureInfo.CurrentCulture = new CultureInfo("ne-NP");


Console.WriteLine(today.ToString("d"));

Console.ReadKey();
