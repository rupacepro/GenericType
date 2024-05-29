
var person = new Person(2);
person.person1 = new Person(3);
person.Print();


string name = "Rupesh Shrestha";
string myName = name;

Console.WriteLine(object.ReferenceEquals(myName, myName));
class Person
{
    public int Id { get; set; }
    public Person person1 { get; set; }

    public Person(int id)
    {
        Id = id;
    }

    public void Print()
    {
        Console.WriteLine(person1.Id);
    }
}



