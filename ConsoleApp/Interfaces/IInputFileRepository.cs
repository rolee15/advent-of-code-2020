using System.Collections.Generic;

namespace ConsoleApp.Interfaces
{
    public interface IInputFileRepository
    {
        IEnumerable<int> GetDayOneInput();
        IEnumerable<string> GetDayTwoInput();
    }
}