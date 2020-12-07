namespace ConsoleApp.Utilities
{
    internal class PasswordParser
    {
        public static int ParseLowerBound(string line)
        {
            int indexFrom = 0;
            int indexTo = line.IndexOf("-");
            int length = indexTo - indexFrom;
            var lowerStr = line.Substring(indexFrom, length);
            return int.Parse(lowerStr);
        }

        public static int ParseUpperBound(string line)
        {
            int indexFrom = line.IndexOf("-") + 1;
            int indexTo = line.IndexOf(" ");
            int length = indexTo - indexFrom;
            var upperStr = line.Substring(indexFrom, length);
            return int.Parse(upperStr);
        }

        internal static string ParseCharacter(string line)
        {
            int indexFrom = line.IndexOf(" ") + 1;
            int indexTo = line.IndexOf(":");
            int length = indexTo - indexFrom;
            var character = line.Substring(indexFrom, length);
            return character;
        }

        internal static string ParsePassword(string line)
        {
            int indexFrom = line.IndexOf(": ") + 2;
            var password = line.Substring(indexFrom);
            return password;
        }
    }

}