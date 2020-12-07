using System;
using System.Collections.Generic;
using ConsoleApp.Utilities;

namespace ConsoleApp.Solutions
{
    internal sealed class SolutionDayTwo : SolutionBase
    {
        public SolutionDayTwo(string[] lines)
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
        protected override void SolvePartOne()
        {
            FirstResult = 0;
            foreach (var line in Lines)
            {
                var minOccurence = PasswordParser.ParseLowerBound(line);
                var maxOccurence = PasswordParser.ParseUpperBound(line);
                var character = PasswordParser.ParseCharacter(line);
                var password = PasswordParser.ParsePassword(line);

                var count = 0;
                foreach (var ch in password)
                    if (character == ch)
                        count++;

                if (minOccurence <= count && count <= maxOccurence)
                    FirstResult++;
            }
        }

        protected override void SolvePartTwo()
        {
            SecondResult = 0;
            foreach (var line in Lines)
            {
                var pos1 = PasswordParser.ParseLowerBound(line);
                var pos2 = PasswordParser.ParseUpperBound(line);
                var character = PasswordParser.ParseCharacter(line);
                var password = PasswordParser.ParsePassword(line);

                var ch1 = password[pos1 - 1];
                var ch2 = password[pos2 - 1];

                if (ch1 == character ^ ch2 == character)
                    SecondResult++;
            }
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