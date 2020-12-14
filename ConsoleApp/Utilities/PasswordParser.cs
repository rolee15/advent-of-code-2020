using System;

namespace ConsoleApp.Utilities
{
    internal static class PasswordParser
    {
        public static int ParseLowerBound(string line)
        {
            var indexFrom = 0;
            var length = line.IndexOf("-", StringComparison.Ordinal);
            var lowerStr = line.Substring(indexFrom, length);
            return int.Parse(lowerStr);
        }

        public static int ParseUpperBound(string line)
        {
            var indexFrom = line.IndexOf("-", StringComparison.Ordinal) + 1;
            var indexTo = line.IndexOf(" ", StringComparison.Ordinal);
            var length = indexTo - indexFrom;
            var upperStr = line.Substring(indexFrom, length);
            return int.Parse(upperStr);
        }

        internal static char ParseCharacter(string line)
        {
            var indexFrom = line.IndexOf(" ", StringComparison.Ordinal) + 1;
            var character = line.Substring(indexFrom, 1);
            return character[0];
        }

        internal static string ParsePassword(string line)
        {
            var indexFrom = line.IndexOf(": ", StringComparison.Ordinal) + 2;
            var password = line.Substring(indexFrom);
            return password;
        }
    }
}