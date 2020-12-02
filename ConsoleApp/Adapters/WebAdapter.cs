using ConsoleApp.Interfaces;
using System;
using System.Net.Http;
using System.Threading.Tasks;

class WebAdapter : IWebAdapter
{
    private static WebAdapter _instance;
    private static readonly HttpClient client;
    public Uri Uri { get; set; }

    public static WebAdapter Instance
    {
        get { return _instance ?? (_instance = new WebAdapter()); }
    }
    static WebAdapter()
    {
        client = new HttpClient();
    }

    public async Task<string> GetAsync()
    {
        try
        {
            return await client.GetStringAsync(Uri);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message: {0} ", e.Message);
            return null;
        }
    }
}