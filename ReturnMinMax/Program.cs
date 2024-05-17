List<int> numbers = new List<int> { 1, 2, 3, 0 };
Console.WriteLine(FindMinMax(numbers).Value1);
ReturnTwo FindMinMax(IEnumerable<int> numbers)
{
    int min = numbers.First();
    int max = numbers.First();
    foreach(int number in numbers)
    {
        if(number < min)
        {
            min = number;
        }

        if(number > max) {
            max = number;
        }
    }
    return new ReturnTwo (min, max);
}


Console.ReadKey();

class ReturnTwo
{
    public int Value1 { get; }
    public int Value2 { get; }
    public ReturnTwo(int x, int y)
    {
        Value1 = x; 
        Value2 = y;
    }
}