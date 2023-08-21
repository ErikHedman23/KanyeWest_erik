
using Newtonsoft.Json.Linq;
using System.Net.Http;

var client = new HttpClient();

var kanyeURL = "https://api.kanye.rest/";

var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

var kanyeQuote = JObject.Parse(kanyeResponse)["quote"].ToString();


Thread.Sleep(2000);
    Console.WriteLine($"Kanye says, '{kanyeQuote}'");
Console.Write(". ");
Thread.Sleep(500);

Console.Write(". ");
Thread.Sleep(500);

Console.Write();

