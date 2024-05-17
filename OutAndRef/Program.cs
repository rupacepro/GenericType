//int num = 1;

//IncreaseByOne(ref num); //pass by ref

//Console.WriteLine(num);
//void IncreaseByOne(ref int num)
//{
//    num++; // increses the original value
//}



string num = "1";

bool isInt = int.TryParse(num, out int result);

Console.WriteLine(result);



