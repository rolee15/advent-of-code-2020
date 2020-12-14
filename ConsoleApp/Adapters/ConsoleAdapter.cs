using System;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Adapters
{
    internal class ConsoleAdapter : IConsoleAdapter
    {
        public void WriteLine()
        {
            Console.WriteLine();
        }

        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public void WriteLine(string format, params object[] arg)
        {
            Console.WriteLine(format, arg);
        }
    }
}