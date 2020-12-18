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

        public IEnumerable<string> GetInput(string fileName)
        {
            var lines = _fileAdapter.GetFile(fileName);
            foreach (var line in lines)
                yield return line;
        }
    }
}