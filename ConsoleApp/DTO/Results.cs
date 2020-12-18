namespace ConsoleApp.DTO
{
    internal class Results
    {
        public string Title { get; set; }
        public object FirstResult { get; set; }
        public object SecondResult { get; set; }
        public double TotalMilliseconds { get; internal set; }
    }
}