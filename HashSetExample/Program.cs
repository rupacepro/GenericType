

var hashSet = new HashSet<string>()
{
    "a", "b", "c", "d", "a" // a is ignored
};

hashSet.Add("b"); // ignored

foreach (var hash in hashSet)
{
    Console.WriteLine(hash);
}
Console.ReadKey();

public class HashSetExample
{
    
}