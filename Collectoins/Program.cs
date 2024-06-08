using System.Collections;

var customCollection = new CustomCollection(new string[] { "Rupesh", "Rakesh" });

var first = customCollection[0];
Console.WriteLine(first);

var newNames = new CustomCollection
{
    "Ramala", "Mukesh", "Bikram", "Pramila"
};

Console.ReadKey();

class CustomCollection : IEnumerable<string>
{
    public string[] names { get; }

    public CustomCollection()
    {
        names = new string[10];
    }

    public CustomCollection(string[] names)
    {
        this.names = names;
    }

    private int _currentIndex = 0;
    public void Add(string name)
    {
        names[_currentIndex] = name;
        ++_currentIndex;
    }

    public IEnumerator<string> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}