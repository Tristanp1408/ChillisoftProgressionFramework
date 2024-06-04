namespace SerializeAndDeserialize.Entity;

public class BookEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string AuthorJson { get; set; } = null!;
}