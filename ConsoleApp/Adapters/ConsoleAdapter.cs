using System;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Adapters
{
    class ConsoleAdapter : IConsoleAdapter
    {
        public void Write(string msg)
        {
            Console.Write(msg);
        }

        public void Write(string format, params object[] arg)
        {
            Console.Write(format, arg);
        }

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