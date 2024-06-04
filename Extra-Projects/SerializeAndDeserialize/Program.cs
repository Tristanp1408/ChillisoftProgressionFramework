using AutoMapper;
using SerializeAndDeserialize.Domain;
using SerializeAndDeserialize.Entity;
using SerializeAndDeserialize.Mapper;

namespace SerializeAndDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigureAutoMapper();

            var bookEntityList = new List<BookEntity>();

            var mapper = config.CreateMapper();

            var author = Author.Create(1, "Tristan", 14);

            var book = Book.Create(1, "Harry Potter", author);

            Console.WriteLine("Before Mapping...");
            Console.WriteLine($"Book Id: {book.Id}, Title: {book.Title}");
            Console.WriteLine($"Author Id: {book.Author.Id}, Name: {book.Author.Name}, Age: {book.Author.Age}");

            var bookEntity = mapper.Map<BookEntity>(book);

            Console.WriteLine("\nBefore Saving:");
            Console.WriteLine($"BookEntity Id: {bookEntity.Id}, Title: {bookEntity.Title}");
            Console.WriteLine($"AuthorJson: {bookEntity.AuthorJson}");

            bookEntityList.Add(bookEntity);

            var retrievedBookEntity = bookEntityList[0];

            var retrievedBook = mapper.Map<Book>(retrievedBookEntity);

            Console.WriteLine("\nAfter Retrieving:");
            Console.WriteLine($"Book Id: {retrievedBook.Id}, Title: {retrievedBook.Title}");
            Console.WriteLine($"Author Id: {retrievedBook.Author.Id}, Name: {retrievedBook.Author.Name}, Age: {retrievedBook.Author.Age}");
        }

        private static MapperConfiguration ConfigureAutoMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
        }
    }
}
