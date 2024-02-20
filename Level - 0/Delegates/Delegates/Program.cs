namespace Delegates
{
    public delegate void ButtonClickHandler();

    public class Program
    {
        static void Main(string[] args)
        {
            var button = new Button();

            button.Click += SayHello;
            button.Click += SayGoodbye;

            button.ClickButton();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void SayGoodbye()
        {
            Console.WriteLine("Goodbye World!");
        }
    }

    public class Button
    {
        public event ButtonClickHandler Click = null!;

        public void ClickButton()
        {
            Console.WriteLine("Button clicked!");
            Click.Invoke();
        }
    }
}
