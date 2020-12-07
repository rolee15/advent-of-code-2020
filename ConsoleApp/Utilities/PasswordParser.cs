namespace ConsoleApp.Utilities
{
    internal static class PasswordParser
    {
        public static int ParseLowerBound(string line)
        {
            var indexFrom = 0;
            var indexTo = line.IndexOf("-");
            var length = indexTo - indexFrom;
            var lowerStr = line.Substring(indexFrom, length);
            return int.Parse(lowerStr);
        }

        public static int ParseUpperBound(string line)
        {
            var indexFrom = line.IndexOf("-") + 1;
            var indexTo = line.IndexOf(" ");
            var length = indexTo - indexFrom;
            var upperStr = line.Substring(indexFrom, length);
            return int.Parse(upperStr);
        }

        internal static string ParseCharacter(string line)
        {
            var indexFrom = line.IndexOf(" ") + 1;
            var indexTo = line.IndexOf(":");
            var length = indexTo - indexFrom;
            var character = line.Substring(indexFrom, length);
            return character;
        }

        internal static string ParsePassword(string line)
        {
            var indexFrom = line.IndexOf(": ") + 2;
            var password = line.Substring(indexFrom);
            return password;
        }
    }
}