using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
           var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JsonObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine(kanyeQuote);
        }
    }
}
