using Newtonsoft.Json;

namespace PublicHolidays
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var country = "ZA"; 
            var year = 2024;

            var apiEndpoint = $"https://api.api-ninjas.com/v1/holidays?country={country}&year={year}";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-Api-Key", ApiDetails.ApiKey);

            var response = await client.GetAsync(apiEndpoint);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();

                var deserializeObject = JsonConvert.DeserializeObject<List<PublicHoliday>>(responseBody)!.Where(x => x.Type == "PUBLIC_HOLIDAY");

                var serializedPublicHolidays = JsonConvert.SerializeObject(deserializeObject, new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented
                });

                Console.WriteLine(serializedPublicHolidays);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
            }
        }
    }
}
