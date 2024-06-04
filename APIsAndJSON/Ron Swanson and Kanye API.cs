using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class Ron_Swanson_and_Kanye_API
    {
        var client = new HttpClient();

        var kanyeURL = "https://api.kanye.rest";
        var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

        var kanyeQuote = JsonObject.Parse(kanyeResponse).GetValue("quote").ToString();

        Console.WriteLine($"-------------");
        Console.WriteLine($"Kanye:  '{kanyeQuote}'");
        Console.WriteLine($"---------------");
        
    }

    public static void RonQuote()
    {
        var client = new HttpClient();

        var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        var ronsResponse = client.GetStringAsync(ronURL).Result;

        var ronQuote = JArray.Parse(ronsResponse).ToString().Replace('[', '').Replace(']', '').Trim();

        Console.WriteLine($"-------------");
        Console.WriteLine($"Ron:  '{ronQuote}'");
        Console.WriteLine($"---------------");

    }
}
