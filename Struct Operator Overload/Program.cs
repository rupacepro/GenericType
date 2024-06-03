//var one = new A(1, 2);
//var two = new A(2, 3);
//A added = one + two;
//Console.WriteLine(added.X + "  " + added.Y);
//A isEqual = one == two;

//public struct A
//{
//    public int X { get; init; }
//    public int Y { get; init; }

//    public A(int x, int y)
//    {
//        this.X = x;
//        this.Y = y;
//    }

//    public static A operator +(A a, A b)
//    {
//        return new A(a.X + b.X, a.Y + b.Y);
//    }

//    public static bool operator ==(A a, A b)
//    {
//        return a.Equals(b);
//    }
//    public static bool operator !=(A a, A b)
//    {
//        return !a.Equals(b);
//    }

//}


using System.Diagnostics.CodeAnalysis;

var house1 = new House(10, 11);
var house2 = new House(10, 12);

var added = house1 == house2;

Console.WriteLine(added);

public struct House
{
    public int Length { get; init; }
    public int Width { get; init; }
    public House(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public static House operator +(House house1, House house2){
        return new House(house1.Length + house2.Length, house1.Width + house2.Width);
    }

    public override bool Equals(object house)
    {
        if(house is House house1 && house1.Width == Width)
        {
            return true;
        }
        return false;
    }

    public static bool operator ==(House house1, House house2)
    {
        return house1.Equals(house2);
    }

    public static bool operator !=(House house1, House house2)
    {
        return !(house1 == house2);
    }
}