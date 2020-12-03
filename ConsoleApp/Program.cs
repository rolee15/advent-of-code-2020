using ConsoleApp.Adapters;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;

namespace ConsoleApp
{
    class Program
    {
        private static IFileAdapter _fileAdapter;
        private static IInputFileRepository _inputFileRepository;
        private static SolutionManager _manager;

        static void Main(string[] args)
        {
            ConfigureProgram();
            SolveAndPrintDayOne();
        }

        private static void ConfigureProgram()
        {
            _fileAdapter = new FileAdapter("./input");
            _inputFileRepository = new InputFileRepository(_fileAdapter);
            _manager = new SolutionManager(_inputFileRepository);
        }

        private static void SolveAndPrintDayOne()
        {
            _manager.SolveDayOne();
            PrintDayOne();
        }

        private static void PrintDayOne()
        {
            System.Console.WriteLine("--- Day 1: Report Repair --- Part 1");
            System.Console.WriteLine("Solution: {0}", _manager.FirstResult);

            System.Console.WriteLine("--- Day 1: Report Repair --- Part 2");
            System.Console.WriteLine("Solution: {0}", _manager.SecondResult);

            System.Console.WriteLine("Elapsed time: {0}ms", _manager.TotalRunTimeInMilliseconds);
        }
    }
}
