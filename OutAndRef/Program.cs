//int num = 1;

//IncreaseByOne(ref num); //pass by ref

//Console.WriteLine(num);
//void IncreaseByOne(ref int num)
//{
//    num++; // increses the original value
//}



//string num = "1";

//bool isInt = int.TryParse(num, out int result);

//Console.WriteLine(result);

//DateTime date = DateTime.Now;
//Change(ref date);

//void Change(ref DateTime date)
//{
//    Console.WriteLine(date.Month);
//}

//int num = 1;
//object obj = num;
//int result = (int)obj;
//Console.WriteLine(result);

using StreamReader reader = new StreamReader("C:\\Users\\rupac\\Desktop\\try.txt", true);
while (!reader.EndOfStream)
{
    String content = reader.ReadLine();
    Console.WriteLine(content);
}

Console.ReadKey();

 void dispose()
{
    reader.Dispose();
}



