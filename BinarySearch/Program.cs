var sortedList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int indexOf5 = sortedList.IndexOf(5);

Console.WriteLine(indexOf5);
Console.ReadKey();

public static class BinarySearch
{ 
    public static int? findIndex<T>(T item, List<T> ints) where T : IComparable<T>
    {
        int leftBound = 0;
        int rightBound = ints.Count() - 1;

        while(leftBound <= rightBound)
        {
            int targetIndex = (leftBound + rightBound) / 2;
            if (item.Equals(ints[targetIndex]))
            {
                return targetIndex;
            }
            
            else if (item.CompareTo(ints[targetIndex]) < 0)
            {
                rightBound = targetIndex - 1;
            }
            else
            {
                leftBound = targetIndex + 1;
            }

        }
        return null;
    }
}