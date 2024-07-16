namespace Generics.Interfaces;

public interface IRepository<T>
{ 
    // Adds an item to the repository.
    void Add(T item);

    // Removes an item from the repository.
    void Remove(T item);

    // Retrieves an item from the repository by its unique identifier.
    T GetById(int id);
}