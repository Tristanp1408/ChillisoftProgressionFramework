namespace SmsApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var rapidApiSmsSender =
                new RapidApiSmsSender("tristanperumalsamy1@gmail.com", "C0175F49-B052-BA84-9703-DAA026A9A2B0");

           var payload = SmsMessagePayload.Create(new List<string> { "+2722520079" }, "", "");

           await rapidApiSmsSender.Send(payload);
        }
    }
}