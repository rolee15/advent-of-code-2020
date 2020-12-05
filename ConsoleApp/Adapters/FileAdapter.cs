using System.IO;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Adapters
{
    class FileAdapter : IFileAdapter
    {
        private string _folderPath;

        public FileAdapter(string folderPath)
        {
            _folderPath = folderPath;
        }

        public string[] GetFile(string fileName)
        {
            string path = Path.Combine(_folderPath, fileName);
            return File.ReadAllLines(path);
        }
    }
}