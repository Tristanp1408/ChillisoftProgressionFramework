using Generics.Interfaces;

namespace Generics;

public class LinkedListContainer<T> : IContainer<T>
{
    private readonly LinkedList<T> _linkedList = [];

    // Adds an item to the end of the linked list.
    public void Add(T item)
    {
        _linkedList.AddLast(item);
        Console.WriteLine($"Item {item} added to linked list.");
    }

    // Removes and returns the item from the front of the linked list.
    public T Remove()
    {
        if (_linkedList.Count == 0)
        {
            Console.WriteLine("Linked list is empty. Nothing to remove.");
            return default!;
        }

        var item = _linkedList.First!.Value;
        _linkedList.RemoveFirst();
        Console.WriteLine($"Item {item} removed from linked list.");
        return item;
    }

    // Returns the item from the front of the linked list without removing it.
    public T Peek()
    {
        if (_linkedList.Count == 0)
        {
            Console.WriteLine("Linked list is empty. Nothing to peek.");
            return default!;
        }

        return _linkedList.First!.Value;
    }

    public T GetLastItemFromList()
    {
        if (_linkedList.Count == 0)
        {
            Console.WriteLine("Linked list is empty. Nothing to peek.");
            return default!;
        }

        return _linkedList.Last!.Value;
    }

    // Gets the number of items currently in the linked list.
    public int Count => _linkedList.Count;

    // Checks if the linked list is empty.
    public bool IsEmpty => _linkedList.Count == 0;
}