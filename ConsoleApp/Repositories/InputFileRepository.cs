using System.Collections.Generic;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Repositories
{
    internal sealed class InputFileRepository : IInputFileRepository
    {
        IFileAdapter _fileAdapter;
        public InputFileRepository(IFileAdapter fileAdapter)
        {
            _fileAdapter = fileAdapter;
        }

        private IEnumerable<int> GetInput(string fileName)
        {
            var lines = _fileAdapter.GetFile(fileName);
            foreach (var line in lines)
                yield return int.Parse(line);
        }

        public IEnumerable<int> GetDayOneInput()
        {
            return GetInput("day1.txt");
        }
    }
}