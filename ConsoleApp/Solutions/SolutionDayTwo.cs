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
                int minOccurence = PasswordParser.ParseLowerBound(line);
                int maxOccurence = PasswordParser.ParseUpperBound(line);
                string character = PasswordParser.ParseCharacter(line);
                string password = PasswordParser.ParsePassword(line);

                int count = 0;
                foreach (var ch in password)
                {
                    if (character == ch.ToString())
                        count++;
                }
                
                if (minOccurence <= count && count <= maxOccurence)
                    FirstResult++;
            }
        }

        protected override void SolvePartTwo()
        {

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