namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            UsingTheFactoryMethodOnCarDetails();

            UsingTheDtoMethodToSerializeAndDeserializeThePersonObject();

            UsingTheOrderObject();
        }

        private static void UsingTheDtoMethodToSerializeAndDeserializeThePersonObject()
        {
            // Create a Person object
            var person = new Person
            {
                Name = "Tristan",
                Age = 22,
                Email = "tristan@test.com"
            };

            // Serialize the Person object to a JSON string.
            var personJson = person.ToJson();
            Console.WriteLine("\nSerialized JSON:");
            Console.WriteLine(personJson);

            // Deserialize the JSON string back to a Person object.
            var deserializedPerson = Person.FromJson(personJson);
            Console.WriteLine("\nDeserialized Person object:");
            deserializedPerson.DisplayInfo();
        }

        private static void UsingTheFactoryMethodOnCarDetails()
        {
            // Create a CarDetails object
            var carDetails = CarDetails.Create("Toyota", "Yaris", 2007);

            // Using the Display method on CarDetails to show the object properties
            carDetails.DisplayInfo();
        }

        private static void UsingTheOrderObject()
        {
            // Create an Order object
            var order = new Order("12345");

            // Add items to the order
            order.AddItem("Laptop", 1500)
                .AddItem("Mouse", 50)
                .AddItem("Keyboard", 100);

            // Display order details
            Console.WriteLine("\nOrder Details:");
            order.DisplayInfo();
        }
    }
}
