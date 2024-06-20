

var stackOne = new Stack<int>();

stackOne.Push(1);
stackOne.Push(2);
stackOne.Push(3);
stackOne.Push(4);

var itemRemoved = stackOne.Pop();

var itemPeeked = stackOne.Peek();

Console.ReadKey();