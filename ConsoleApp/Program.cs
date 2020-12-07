using ConsoleApp.Adapters;
using ConsoleApp.DTO;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;

namespace ConsoleApp
{
    internal class Program
    {
        private static IConsoleAdapter ConsoleAdapter;
        private static IFileAdapter FileAdapter;
        private static IInputFileRepository InputFileRepository;
        private static SolutionDayOneManager DayOneManager { get; set; }
        public static SolutionDayTwoManager DayTwoManager { get; private set; }
        private static Results Results { get; set; }

        private static void Main(string[] args)
        {
            ConfigureProgram();
            GetAndPrintResults();
        }

        private static void GetAndPrintResults()
        {
            // GetDayOneResults();
            // PrintDayOneResults();
            GetDayTwoResults();
        }

        private static void GetDayOneResults()
        {
            Results = DayOneManager.GetResults();
        }

        private static void PrintDayOneResults()
        {
            ConsoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 1");
            ConsoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            ConsoleAdapter.WriteLine();
            ConsoleAdapter.WriteLine("--- Day 1: Report Repair --- Part 2");
            ConsoleAdapter.WriteLine("Solution: {0}", Results.SecondResult);
            ConsoleAdapter.WriteLine();
            ConsoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
        }

        private static void GetDayTwoResults()
        {
            Results = DayTwoManager.GetResults();
        }

        private static void PrintDayTwoResults()
        {
            ConsoleAdapter.WriteLine("Day 2: Password Philosophy --- Part 1");
            ConsoleAdapter.WriteLine("Solution: {0}", Results.FirstResult);
            ConsoleAdapter.WriteLine();
            ConsoleAdapter.WriteLine("Elapsed time: {0}ms", Results.TotalMilliseconds);
        }

        private static void ConfigureProgram()
        {
            ConsoleAdapter = new ConsoleAdapter();
            FileAdapter = new FileAdapter("./input");
            InputFileRepository = new InputFileRepository(FileAdapter);
            DayOneManager = new SolutionDayOneManager(InputFileRepository);
            DayTwoManager = new SolutionDayTwoManager(InputFileRepository);
        }
    }
}