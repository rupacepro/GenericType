//var rupesh = new AClass(1);
//var shrestha = new AClass(1);
//Console.WriteLine(rupesh.Equals(shrestha));

//class AClass
//{
//    public int Id { get; set; }
//    public AClass(int id)
//    {
//        Id = id;
//    }

//    public override bool Equals(object? obj)
//    {
//        return obj is AClass person && Id == person.Id;
//    }
//}



var rupesh = new AClass(1);
var shrestha = rupesh;
Console.WriteLine(Object.ReferenceEquals(rupesh, shrestha));

class AClass
{
    public int Id { get; set; }
    public AClass(int id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        return obj is AClass person && Id == person.Id;
    }
}