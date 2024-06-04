namespace SerializeAndDeserialize.Domain;

public class Book
{
    private Book() {}

    public static Book Create(int id, string title, Author author)
    {
        return new Book
        {
            Id = id,
            Title = title,
            Author = author
        };
    }

    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public Author Author { get; set; } = null!;
}