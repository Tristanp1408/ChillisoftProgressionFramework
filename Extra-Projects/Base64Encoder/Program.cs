using System.Text;

namespace Base64Encoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "5bc9a1a3-da4d-4e7a-be3b-d65918bd0e86:5bdf45ca-86bc-4396-bec6-9dc9cc724f22";
            var base64Encoded = Base64Encode(input);
            Console.WriteLine(base64Encoded);
        }

        static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
