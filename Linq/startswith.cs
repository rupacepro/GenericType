using System.Xml.Linq;

string[] names = new string[]
        {
            "Rupesh",
            "Rakesh",
            "Ramala",
            "Mukesh"
        };

//var withR = names
//    .Where(name =>
//    {
//        Console.WriteLine($"Checking {name}");
//        return name.StartsWith("R");
//    });

var withR = names.Where(name => name.StartsWith("R"));

foreach(var name in withR)
{
    Console.WriteLine(name);
}