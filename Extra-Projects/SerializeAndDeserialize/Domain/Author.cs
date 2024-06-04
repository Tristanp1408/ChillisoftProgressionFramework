namespace SerializeAndDeserialize.Domain;

public class Author
{
    private Author() {}

    public static Author Create(int id, string name, int age)
    {
        return new Author
        {
            Id = id,
            Name = name,
            Age = age
        };
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
}