namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            UsingTheFactoryMethodOnCarDetails();

            UsingTheDtoMethodToSerializeAndDeserializeThePersonObject();
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
    }
}
