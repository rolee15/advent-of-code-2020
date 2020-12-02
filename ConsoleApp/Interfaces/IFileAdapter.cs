using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    public interface IFileAdapter
    {
        string[] GetFile(string fileName);
    }
}