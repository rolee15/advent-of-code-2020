namespace ConsoleApp.Repositories
{
    internal class Passport
    {
        public int BirthYear { get; set; }
        public int IssueYear { get; set; }
        public int ExpirationYear { get; set; }
        public int Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int PassportId { get; set; }
        public int CountryId { get; set; }
    }
}