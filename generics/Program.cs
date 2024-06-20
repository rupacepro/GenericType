

List<string> names = new List<string>() { "Rupesh", "Ramala" };
Console.WriteLine(new Practice().Contain("Rupesh", names));


public class Practice
{
    public bool Contain<T>(T item, List<T> names)
    {
        foreach (var name in names)
        {
            if (name.Equals(item))
            {
                return true;
            }
        }
        return false;
    }
}
