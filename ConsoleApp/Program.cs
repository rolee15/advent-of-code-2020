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
        private static IConsoleAdapter _consoleAdapter;
        private static IFileAdapter _fileAdapter;
        private static IInputFileRepository _inputFileRepository;
        private static ISolutionManager _dayOneManager;
        private static ISolutionManager _dayTwoManager;
        private static ISolutionManager _dayThreeManager;
        private static ISolutionManager _dayFourManager;

        private static Results Results { get; set; }

        public static void Main()
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
            GetDayThreeResults();
            PrintDayThreeResults();
            GetDayFourResults();
            PrintDayFourResults();
        }

        private static void GetDayOneResults()
        {
            Results = _dayOneManager.GetResults();
        }

        private static void PrintDayOneResults()
        {
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", Results.SecondResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
            _consoleAdapter.WriteLine();
        }

        private static void GetDayTwoResults()
        {
            Results = _dayTwoManager.GetResults();
        }

        private static void PrintDayTwoResults()
        {
            _consoleAdapter.WriteLine("--- Day 2: Password Philosophy --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("--- Day 2: Password Philosophy --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", Results.SecondResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
            _consoleAdapter.WriteLine();
        }

        private static void GetDayThreeResults()
        {
            Results = _dayThreeManager.GetResults();
        }

        private static void PrintDayThreeResults()
        {
            _consoleAdapter.WriteLine("--- Day 3: Toboggan Trajectory --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("--- Day 3: Toboggan Trajectory --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", Results.SecondResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
            _consoleAdapter.WriteLine();
        }

        private static void GetDayFourResults()
        {
            Results = _dayFourManager.GetResults();
        }

        private static void PrintDayFourResults()
        {
            _consoleAdapter.WriteLine("--- Day 4: Passport Processing --- Part 1");
            _consoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("--- Day 4: Passport Processing --- Part 2");
            _consoleAdapter.WriteLine("Solution: {0}", Results.SecondResult);
            _consoleAdapter.WriteLine();
            _consoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
            _consoleAdapter.WriteLine();
        }

        private static void ConfigureProgram()
        {
            _consoleAdapter = new ConsoleAdapter();
            _fileAdapter = new FileAdapter("./input");
            _inputFileRepository = new InputFileRepository(_fileAdapter);
            _dayOneManager = new SolutionDayOneManager(_inputFileRepository);
            _dayTwoManager = new SolutionDayTwoManager(_inputFileRepository);
            _dayThreeManager = new SolutionDayThreeManager(_inputFileRepository);
            _dayFourManager = new SolutionDayFourManager(_inputFileRepository);
        }
    }
}