namespace Classes
{
    // The CarDetails class represents a vehicle with make, model, and year attributes.
    // This class uses the Factory Method pattern to create instances.
    public class CarDetails
    {
        // Private constructor to prevent direct instantiation. (Can't new up CarDetails)
        private CarDetails()
        {
        }

        // The only way we can Create a CarDetails object
        public static CarDetails Create(
            string make,
            string model,
            int year)
        {
            return new CarDetails
            {
                Make = make,
                Model = model,
                Year = year
            };
        }

        // Will be used to Display the properties of the object
        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }

        // Public properties for make, model, and year.
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
    }
}