using System.Collections.Generic;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Repositories
{
    internal sealed class InputFileRepository : IInputFileRepository
    {
        private readonly IFileAdapter _fileAdapter;

        public InputFileRepository(IFileAdapter fileAdapter)
        {
            _fileAdapter = fileAdapter;
        }

        public IEnumerable<int> GetDayOneInput()
        {
            var lines = _fileAdapter.GetFile("day1.txt");
            foreach (var line in lines)
                yield return int.Parse(line);
        }

        public IEnumerable<string> GetDayTwoInput()
        {
            var lines = _fileAdapter.GetFile("day2.txt");
            foreach (var line in lines)
                yield return line;
        }

        public IEnumerable<string> GetDayThreeInput()
        {
            var lines = _fileAdapter.GetFile("day3.txt");
            foreach (var line in lines)
                yield return line;
        }

        public IEnumerable<string> GetDayFourInput()
        {
            var lines = _fileAdapter.GetFile("day4.txt");
            foreach (var line in lines)
                yield return line;
        }
    }
}