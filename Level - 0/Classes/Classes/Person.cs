using System.Text.Json;

namespace Classes
{
    // The Person class represents an individual with name, age, and email attributes.
    // This class demonstrates the Data Transfer Object (DTO) pattern.
    public class Person
    {
        // Method to serialize the Person object to a JSON string.
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        // Method to serialize the Person object to a JSON string.
        public static Person FromJson(string json)
        {
            return JsonSerializer.Deserialize<Person>(json)!;
        }

        // Will be used to Display the properties of the object
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Email: {Email}");
        }

        // Public properties for name, age, and email.
        public string Name { get; set; } = null!;
        public int Age { get; set; } 
        public string Email { get; set; } = null!;
    }
}