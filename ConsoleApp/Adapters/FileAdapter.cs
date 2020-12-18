using System.IO;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Adapters
{
    internal class FileAdapter : IFileAdapter
    {
        private readonly string _folderPath;

        public FileAdapter(string folderPath)
        {
            _folderPath = folderPath;
        }

        public string[] GetFile(string fileName)
        {
            var path = Path.Combine(_folderPath, fileName);
            try
            {
                return File.ReadAllLines(path);
            }
            catch
            {
                return null;
            }
        }
    }
}