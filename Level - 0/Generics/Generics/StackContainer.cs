using Generics.Interfaces;

namespace Generics;

public class StackContainer<T> : IContainer<T>
{
    private readonly Stack<T> _stack = new();

    // Adds an item to the top of the stack.
    public void Add(T item)
    {
        _stack.Push(item);
        Console.WriteLine($"Item {item} added to stack.");
    }

    // Removes and returns the item from the top of the stack.
    public T Remove()
    {
        if (_stack.Count == 0)
        {
            Console.WriteLine("Stack is empty. Nothing to remove.");
            return default!;
        }

        var item = _stack.Pop();
        Console.WriteLine($"Item {item} removed from stack.");
        return item;
    }

    // Returns the item from the top of the stack without removing it.
    public T Peek()
    {
        if (_stack.Count == 0)
        {
            Console.WriteLine("Stack is empty. Nothing to peek.");
            return default!;
        }

        return _stack.Peek();
    }

    // Gets the number of items currently in the stack.
    public int Count => _stack.Count;

    // Checks if the stack is empty.
    public bool IsEmpty => _stack.Count == 0;
}