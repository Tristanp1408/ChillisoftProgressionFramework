using Generics.Interfaces;
using Generics.Objects;

namespace Generics.Repository;

public class UserRepository : IRepository<User>
{
    private readonly List<User> _users = [];

    // Adds a user to the repository.
    public void Add(User item)
    {
        _users.Add(item);
        Console.WriteLine($"User {item.Name} added.");
    }

    // Removes a user from the repository.
    public void Remove(User item)
    {
        _users.Remove(item);
        Console.WriteLine($"User {item.Name} removed.");
    }

    // Retrieves a user from the repository by their ID.
    public User GetById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id)!;
    }
}