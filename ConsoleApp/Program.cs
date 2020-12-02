using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var webadapter = WebAdapter.Instance;
            webadapter.Uri = new Uri(@"https://adventofcode.com/2020/day/1/input");
            var response = await webadapter.GetAsync();
            System.Console.WriteLine("Response: {0}", response);
        }
    }
}
