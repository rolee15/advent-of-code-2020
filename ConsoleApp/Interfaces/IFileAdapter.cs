using JetBrains.Annotations;

namespace ConsoleApp.Interfaces
{
    public interface IFileAdapter
    {
        [PublicAPI]
        string[] GetFile(string fileName);
    }
}