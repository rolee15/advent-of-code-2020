using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    internal interface IWebAdapter
    {
        Task<string> GetAsync();
    }
}