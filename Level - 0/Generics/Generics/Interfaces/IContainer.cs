namespace Generics.Interfaces;

public interface IContainer<T>
{
    // Adds an item to the container.
    void Add(T item);

    // Removes and returns an item from the container.
    T Remove();

    // Returns the item at the front/top of the container without removing it.
    T Peek();

    // Gets the number of items currently in the container.
    int Count { get; }

    // Checks if the container is empty.
    bool IsEmpty { get; }
}