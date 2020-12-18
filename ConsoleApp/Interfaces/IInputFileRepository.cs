using System.Collections.Generic;

namespace ConsoleApp.Interfaces
{
    public interface IInputFileRepository
    {
        IEnumerable<string> GetInput(string fileName);
    }
}