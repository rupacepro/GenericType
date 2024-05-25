
var person = new Person();
person.Id = 1;
person.Print();
class Person
{
    public int Id { get; set; }

    public void Print()
    {
        Console.WriteLine(Id);
    }
}

