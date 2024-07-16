using Generics.Interfaces;

namespace Generics;

public class QueueContainer<T> : IContainer<T>
{
    private readonly Queue<T> _queue = new();

    // Adds an item to the end of the queue.
    public void Add(T item)
    {
        _queue.Enqueue(item);
        Console.WriteLine($"Item {item} added to queue.");
    }

    // Removes and returns the item from the front of the queue.
    public T Remove()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Queue is empty. Nothing to remove.");
            return default!;
        }

        var item = _queue.Dequeue();
        Console.WriteLine($"Item {item} removed from queue.");
        return item;
    }

    // Returns the item from the front of the queue without removing it.
    public T Peek()
    {
        if (_queue.Count == 0)
        {
            Console.WriteLine("Queue is empty. Nothing to peek.");
            return default!;
        }

        return _queue.Peek();
    }

    // Gets the number of items currently in the queue.
    public int Count => _queue.Count;

    // Checks if the queue is empty.
    public bool IsEmpty => _queue.Count == 0;
}