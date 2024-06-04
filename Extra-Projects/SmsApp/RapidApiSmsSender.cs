namespace SmsApp;

public class RapidApiSmsSender: ISmsSender
{
    private readonly string _userName;
    private readonly string _key;

    public RapidApiSmsSender(string userName, string key)
    {
        _userName = userName;
        _key = key;
    }

    public async Task Send(ISmsMessagePayload payload)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://inteltech.p.rapidapi.com/send.php"),
            Headers =
            {
                { "X-RapidAPI-Key", "d7a03f33b2msh71ea7478d3f3911p1616c5jsncbc1a2eca9c2" },
                { "X-RapidAPI-Host", "inteltech.p.rapidapi.com" },
            },
            Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "sms", payload.Recipients.First() },
                { "message", payload.Body },
                { "key", _key },
                { "username", _userName },
            }),
        };
        using var response = await client.SendAsync(request);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        Console.WriteLine(body);
    }
}