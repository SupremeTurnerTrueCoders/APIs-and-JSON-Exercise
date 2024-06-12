using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        public const int numberOfQuotes = 5;
        static void Main(string[] args)
        {
            for (int i = 0; i < numberOfQuotes; i++)
            {

                 Ron_Swanson_and_Kanye_API.KanyeQuote();
                 Ron_Swanson_and_Kanye_API.RonQuote();
            }
        }
    }
}
