using System.Collections.Generic;
using ConsoleApp.Utilities;

namespace ConsoleApp.Solutions
{
    internal abstract partial class SolutionBase
    {
        public static SolutionBase CreateDayTwoFrom(IEnumerable<string> lines)
        {
            return new SolutionDayTwo(lines);
        }

        private sealed class SolutionDayTwo : SolutionBase
        {
            public SolutionDayTwo(IEnumerable<string> input)
            {
                Lines = new List<string>(input);
            }

            private List<string> Lines { get; }

            public override string Title => "Day 2: Password Philosophy";

            public override object SolvePartOne()
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

            public override object SolvePartTwo()
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
        }
    }
}