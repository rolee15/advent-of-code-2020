using System.Collections.Generic;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Repositories
{
    class InputFileRepository : IInputFileRepository
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
            var numbers = GetInput("day1.txt");
            return numbers;
        }
    }
}