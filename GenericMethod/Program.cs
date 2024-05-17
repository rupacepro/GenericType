//List<int> data = new List<int> { 1, 2, 3 };
//data.AddItemInPosition(9);

//Console.ReadKey();

//public static class ExtensionExample
//{
//    public static void AddItemInPosition<T>(this List<T> list, T item)
//    {
//        list.Insert(0, item);
//    }
//}

var decimals = new List<decimal>() { 1.1m, 0.5m, 22.5m };
var strings = decimals.ConvertToInt<decimal, string>();

foreach(var i in strings)
{
    Console.WriteLine(i);
}
Console.ReadKey();

 static class ListExtension
{
    public static List<T2> ConvertToInt<T1, T2>(this List<T1> items)
    {
        List<T2> result = new List<T2>();
        foreach(T1 item in items)
        {
            T2 itemAfterCasting = (T2)Convert.ChangeType(item, typeof(T2));
            result.Add(itemAfterCasting);
        }
        return result;

    }
}