namespace ConsoleApp.Interfaces
{
    internal interface IConsoleAdapter
    {
        void Write(string msg);
        void Write(string format, params object[] arg);
        void WriteLine();
        void WriteLine(string msg);
        void WriteLine(string format, params object[] arg);
    }
}