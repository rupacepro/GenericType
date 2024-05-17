var numbers = new SimpleList<string>();

numbers.add("a");
numbers.add("b");
numbers.add("c");
numbers.add("d");
numbers.add("e");

string result = numbers.getIndexAt(2);

Console.WriteLine(result);

numbers.removeAt(2);

result = numbers.getIndexAt(2);

numbers.removeAt(1);

foreach (string item in numbers)
{
    Console.WriteLine(item);
}

Console.ReadKey();

class SimpleList<Type>
{
    private Type[] _items = new Type[4];
    private int _size = 0;

    public void add(Type item)
    {
        if (_size >= _items.Length)
        {
            var newItems = new Type[_items.Length * 2];
            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            _items = newItems;
        }
        _items[_size] = item;
        ++_size;
    }

    public void removeAt(int index)
    {
        if (index >= _size || index < 0)
        {
            Console.WriteLine("Exicuted");
            throw new IndexOutOfRangeException($"Index {index} is out of the bounds of the list.");
        }
        _size--;
        for(int i =  index; i < _size; ++i)
        {
            _items[i] = _items[i+1];
        }
        _items[_size] = default(Type);
    }

    public Type getIndexAt(int index)
    {
        if (index >= _size || index < 0)
        {
            throw new IndexOutOfRangeException($"Index {index} is out of the bounds of the list.");
        }
        return _items[index];
    }

    public int Length()
    {
        return _size;
    }
}
