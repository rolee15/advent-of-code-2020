using System;
using System.Collections.Generic;
using ConsoleApp.Interfaces;
using ConsoleApp.Utilities;

namespace ConsoleApp.Solutions
{
    internal sealed class SolutionDayTwo : ISolution
    {
        private SolutionDayTwo(string[] lines)
        {
            if (lines.Length < 1)
                throw new ArgumentException("Number of arguments less one");
            Lines = new List<string>(lines);
        }

        private List<string> Lines { get; }

        /// <summary>
        ///     Given a list of password policies and passwords, separated with a colon,
        ///     find the number of passwords that fit their policy.
        /// </summary>
        public object SolvePartOne()
        {
            var count = 0;
            foreach (var line in Lines)
            {
                var minOccurence = PasswordParser.ParseLowerBound(line);
                var maxOccurence = PasswordParser.ParseUpperBound(line);
                var character = PasswordParser.ParseCharacter(line);
                var password = PasswordParser.ParsePassword(line);

                var occurence = 0;
                foreach (var ch in password)
                    if (character == ch)
                        occurence++;

                if (minOccurence <= occurence && occurence <= maxOccurence)
                    count++;
            }

            return count;
        }

        public object SolvePartTwo()
        {
            var count = 0;
            foreach (var line in Lines)
            {
                var pos1 = PasswordParser.ParseLowerBound(line);
                var pos2 = PasswordParser.ParseUpperBound(line);
                var character = PasswordParser.ParseCharacter(line);
                var password = PasswordParser.ParsePassword(line);

                var ch1 = password[pos1 - 1];
                var ch2 = password[pos2 - 1];

                if ((ch1 == character) ^ (ch2 == character))
                    count++;
            }

            return count;
        }

        public static SolutionDayTwo FromArray(string[] lines)
        {
            return new SolutionDayTwo(lines);
        }

        public static SolutionDayTwo FromList(List<string> list)
        {
            return new SolutionDayTwo(list.ToArray());
        }
    }
}