using System.Collections;
var myLinkedList = new CustomedLinkedList<int>();
myLinkedList.Add(1);
myLinkedList.Add(2);
myLinkedList.AddToFront(3);
myLinkedList.Remove(1);

foreach(var item in myLinkedList)
{
    Console.WriteLine(item);
}

Console.ReadKey();

public interface ILinkedList<T> : ICollection<T>
{
    void AddToFront(T item);
    void AddToEnd(T item);
}

public class CustomedLinkedList<T> : ILinkedList<T>
{
    class Node
    {
        public T Item;
        public Node? Next;
        public Node(T item)
        {
            this.Item = item;
        }
    }
    private Node? head;
    private Node? tail;
    private int count;
    public int Count => count;

    public bool IsReadOnly => false;

    public void Add(T item)
    {
        AddToEnd(item);
    }

    public void AddToEnd(T item)
    {
        var newNode = new Node(item);
        if(tail is null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    public void AddToFront(T item)
    {
        var newNode = new Node(item);
        if(head is null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
        }
        count++;
    }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public bool Contains(T item)
    {
        Node? currentNode = head;
        while(currentNode is not null)
        {
            if (EqualityComparer<T>.Default.Equals(currentNode.Item, item))
                return true;
            currentNode = currentNode.Next;
        }
        return false;
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        if (arrayIndex < 0)
            throw new ArgumentOutOfRangeException(nameof(arrayIndex));

        if (array.Length - arrayIndex < count)
            throw new ArgumentException("The destination array has fewer elements than the collection.");

        var current = head;
        while (current != null)
        {
            array[arrayIndex++] = current.Item;
            current = current.Next;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = head;
        while (current != null)
        {
            yield return current.Item;
            current = current.Next;
        }
    }

    public bool Remove(T item)
    {
        if(head == null)
        {
            return false;
        }
        if (EqualityComparer<T>.Default.Equals(head.Item, item))
        {
            head = head.Next;
            if (head is null)
            {
                tail = null;
            }
            count--;
            return true;
        }

        Node currentNode = head;
        while(currentNode.Next is not null)
        {
            if(EqualityComparer<T>.Default.Equals(currentNode.Next.Item, item))
            {
                currentNode.Next = currentNode.Next.Next;
                if(currentNode.Next == null)
                {
                    tail = currentNode;
                }
                return true;
            }
            currentNode = currentNode.Next;
        }
        return false;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

