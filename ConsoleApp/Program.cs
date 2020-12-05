using System;
using ConsoleApp.Adapters;
using ConsoleApp.Interfaces;
using ConsoleApp.Managers;
using ConsoleApp.Repositories;

namespace ConsoleApp
{
    class Program
    {
        private static IConsoleAdapter _consoleAdapter;
        private static IFileAdapter _fileAdapter;
        private static IInputFileRepository _inputFileRepository;
        private static SolutionManager _manager;

        static void Main(string[] args)
        {
            ConfigureProgram();
            _manager.SolveAndPrintDayOne();
        }

        private static void ConfigureProgram()
        {
            _consoleAdapter = new ConsoleAdapter();
            _fileAdapter = new FileAdapter("./input");
            _inputFileRepository = new InputFileRepository(_fileAdapter);
            _manager = new SolutionManager(_inputFileRepository, _consoleAdapter);
        }

        
    }
}
