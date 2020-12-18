using JetBrains.Annotations;

namespace ConsoleApp.Interfaces
{
    internal interface IConsoleAdapter
    {
        [PublicAPI]
        void Write(string msg);
        [PublicAPI]
        void Write(string format, params object[] arg);
        [PublicAPI]
        void WriteLine();
        [PublicAPI]
        void WriteLine(string msg);
        [PublicAPI]
        void WriteLine(string format, params object[] arg);
    }
}