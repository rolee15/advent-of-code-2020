namespace ConsoleApp.Interfaces
{
    internal interface ISolution
    {
        int FirstResult { get; }
        int SecondResult { get; }
        void Solve();
    }
}