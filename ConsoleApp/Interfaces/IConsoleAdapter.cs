namespace ConsoleApp.Interfaces
{
    internal interface IConsoleAdapter
    {
        void WriteLine();
        void WriteLine(string msg);
        void WriteLine(string format, params object[] arg);
    }
}