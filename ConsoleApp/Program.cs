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
        private static SolutionDayOneManager _dayOneManager { get; set; }
        private static SolutionDayTwoManager _dayTwoManager { get; set; }
        private static Results _results { get; set; }

        private static void Main(string[] args)
        {
            ConfigureProgram();
            GetAndPrintResults();
        }

        private static void GetAndPrintResults()
        {
            GetDayOneResults();
            PrintDayOneResults();
            GetDayTwoResults();
            PrintDayTwoResults();
        }

        private static void GetDayOneResults()
        {
            _results = _dayOneManager.GetResults();
        }

        private static void PrintDayOneResults()
        {
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", _results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", _results.SecondResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", _results.TotalMilliseconds);
            _consoleAdapter.WriteLine();
        }

        private static void GetDayTwoResults()
        {
            _results = _dayTwoManager.GetResults();
        }

        private static void PrintDayTwoResults()
        {
            _consoleAdapter.WriteLine("--- Day 2: Password Philosophy --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", _results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", _results.TotalMilliseconds);
            _consoleAdapter.WriteLine();
        }

        private static void ConfigureProgram()
        {
            _consoleAdapter = new ConsoleAdapter();
            _fileAdapter = new FileAdapter("./input");
            _inputFileRepository = new InputFileRepository(_fileAdapter);
            _dayOneManager = new SolutionDayOneManager(_inputFileRepository);
            _dayTwoManager = new SolutionDayTwoManager(_inputFileRepository);
        }
    }
}