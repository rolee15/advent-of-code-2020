using ConsoleApp.Adapters;
using ConsoleApp.DTO;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;

namespace ConsoleApp
{
    internal class Program
    {
        private static IConsoleAdapter _consoleAdapter;
        private static IFileAdapter _fileAdapter;
        private static IInputFileRepository _inputFileRepository;
        private static SolutionDayOneManager _manager;

        private static Results Results { get; set; }

        private static void Main(string[] args)
        {
            ConfigureProgram();
            GetResults();
            PrintResults();
        }

        private static void GetResults()
        {
            Results = _manager.GetResults();
        }

        private static void PrintResults()
        {
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", Results.SecondResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
        }

        private static void ConfigureProgram()
        {
            _consoleAdapter = new ConsoleAdapter();
            _fileAdapter = new FileAdapter("./input");
            _inputFileRepository = new InputFileRepository(_fileAdapter);
            _manager = new SolutionDayOneManager(_inputFileRepository, _consoleAdapter);
        }
    }
}