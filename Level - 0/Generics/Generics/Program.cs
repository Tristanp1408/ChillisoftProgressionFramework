using Generics.Objects;
using Generics.Repository;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowRepositoryPatternDemonstration();

            ShowDemonstrationOfStackAndQueue();

            ShowDemonstrationOfALinkedList();
        }

        private static void ShowDemonstrationOfALinkedList()
        {
            var linkedListContainer = new LinkedListContainer<int>();

            linkedListContainer.Add(10);
            linkedListContainer.Add(20);
            linkedListContainer.Add(30);

            Console.WriteLine($"Peek linked list: {linkedListContainer.Peek()}"); 
            Console.WriteLine($"Linked list count: {linkedListContainer.Count}"); 
            Console.WriteLine($"Linked last item: {linkedListContainer.GetLastItemFromList()}");  

            linkedListContainer.Remove();
            Console.WriteLine($"Linked list is empty: {linkedListContainer.IsEmpty}");  

            linkedListContainer.Remove();
            linkedListContainer.Remove();
            linkedListContainer.Remove(); 

            Console.WriteLine($"Linked list count: {linkedListContainer.Count}");
        }

        private static void ShowDemonstrationOfStackAndQueue()
        {
            var stackContainer = new StackContainer<int>();
            var queueContainer = new QueueContainer<string>();

            // Stack 
            stackContainer.Add(1);
            stackContainer.Add(2);
            Console.WriteLine($"Peek stack: {stackContainer.Peek()}");  
            Console.WriteLine($"Stack count: {stackContainer.Count}");  
            stackContainer.Remove();
            Console.WriteLine($"Stack is empty: {stackContainer.IsEmpty}");  
            stackContainer.Remove();
            stackContainer.Remove(); 

            // Queue 
            queueContainer.Add("First");
            queueContainer.Add("Second");
            Console.WriteLine($"Peek queue: {queueContainer.Peek()}");  
            Console.WriteLine($"Queue count: {queueContainer.Count}");  
            queueContainer.Remove();
            Console.WriteLine($"Queue is empty: {queueContainer.IsEmpty}");  
            queueContainer.Remove();
            queueContainer.Remove(); 
        }

        private static void ShowRepositoryPatternDemonstration()
        {
            var userRepository = new UserRepository();
            var productRepository = new ProductRepository();

            var user = new User { Id = 1, Name = "John", Surname = "Test" };
            var product = new Product { Id = 1, Name = "Laptop", Description = "Brand new" };

            userRepository.Add(user);
            productRepository.Add(product);

            var retrievedUser = userRepository.GetById(1);
            var retrievedProduct = productRepository.GetById(1);

            Console.WriteLine($"Retrieved User: {retrievedUser.Name}");
            Console.WriteLine($"Retrieved Product: {retrievedProduct.Name}");
        }
    }
}
