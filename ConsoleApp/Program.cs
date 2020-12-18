using ConsoleApp.Adapters;
using ConsoleApp.DTO;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;
using JetBrains.Annotations;

namespace ConsoleApp
{
    [UsedImplicitly]
    internal class Program
    {
        private static ISolutionManager _solutionManager;
        private static IConsoleAdapter _consoleAdapter;

        public static void Main()
        {
            ConfigureProgram();
            var results = _solutionManager.SolveAll();
            foreach (var result in results) PrintResults(result);
        }

        private static void ConfigureProgram()
        {
            var fileAdapter = new FileAdapter("./input");
            var inputFileRepository = new InputFileRepository(fileAdapter);
            _solutionManager = new SolutionManager(inputFileRepository);
            _consoleAdapter = new ConsoleAdapter();
        }

        private static void PrintResults(Results result)
        {
            _consoleAdapter.WriteLine($"--- {result.Title} --- Part 1");
            _consoleAdapter.WriteLine($"Solution: {result.FirstResult}");
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine($"--- {result.Title} ---  Part 2");
            _consoleAdapter.WriteLine($"Solution: {result.SecondResult}");
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine($"Elapsed time: {result.TotalMilliseconds}ms");
            _consoleAdapter.WriteLine();
        }
    }
}