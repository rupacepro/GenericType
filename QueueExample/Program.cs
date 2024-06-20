
var queue = new Queue<string>();

queue.Enqueue("a");
queue.Enqueue("b");
queue.Enqueue("c");

Console.WriteLine(queue);

var itemremoved = queue.Dequeue();

Console.WriteLine(queue);

var itemPeeked = queue.Peek(); 

Console.WriteLine(queue);



var priorityQueue = new PriorityQueue<string, int>();

priorityQueue.Enqueue("a", 2);
priorityQueue.Enqueue("b", 1);
priorityQueue.Enqueue("c", 1);
priorityQueue.Enqueue("d", 3);

var itemRemoved = priorityQueue.Dequeue();

Console.ReadKey();