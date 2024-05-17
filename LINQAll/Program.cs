//var lengths = new int[] { 2, 2, 3, 4, 5, 6 };

//bool areAllLargeThanOne = lengths.All(length => length > 1);

//Console.WriteLine(areAllLargeThanOne);

//Console.WriteLine(lengths.Contains(1));





//var students = new List<Student>()
//{
//    new Student(3, "Atem", 23),
//    new Student(3, "Clair", 26),
//    new Student(2, "Bob", 20)
//};

//var orderedStudents = students.OrderBy(student => student.v1).ThenByDescending(student => student.v3);

//foreach (Student student in orderedStudents)
//{
//    Console.WriteLine(student.v2);
//}

//internal class Student
//{
//    public int v1 { get; set; }
//    public string v2 { get; set; }
//    public int v3 { get; set; }

//    public Student(int v1, string v2, int v3)
//    {
//        this.v1 = v1;
//        this.v2 = v2;
//        this.v3 = v3;
//    }

//}



//var numbers = new int[] { 2, 4, 3, 2, 6 };

//var a = numbers.Where(x => x > 3).ToList();

//foreach(var number in a)
//{
//    Console.WriteLine(number);
//}


//var numbers = new int[] { 2, 4, 6, 2, 3 };

//var indexPresent = new int[] { 2, 3, 4 };

//var result = numbers.Where((number, index) => number > 2 && indexPresent.Contains(index)).OrderBy(number => number);

//foreach (var number in result)
//{
//    Console.WriteLine(number);
//}



List<List<int>> listOfNumbers = new List<List<int>>()
{
    new List<int>(){1, 2, 3, 4, 5, 6 },
    new List<int>(){2, 3, 4, 5, 6, 7 },
    new List<int>(){3, 4, 5, 6, 7, 8 }
};


var average = listOfNumbers.Select(listOfNumber => listOfNumber.Average());
var sum = listOfNumbers.Select(listOfNumber => listOfNumber.Sum());

foreach(var number in average)
{
    Console.WriteLine(number);
}
foreach(var num in sum)
{
    Console.WriteLine(num);
}