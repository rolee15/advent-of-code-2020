using System;
using System.Collections.Generic;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    internal class SolutionDayFive : ISolution
    {
        private SolutionDayFive(string[] lines)
        {
            if (lines.Length < 1)
                throw new ArgumentException("Number of arguments less than one");
        }

        public object SolvePartOne()
        {
            var count = 0;


            return count;
        }

        public object SolvePartTwo()
        {
            var count = 0;


            return count;
        }

        internal static SolutionDayFive FromArray(string[] lines)
        {
            return new SolutionDayFive(lines);
        }

        public static SolutionDayFive FromList(List<string> list)
        {
            return new SolutionDayFive(list.ToArray());
        }
    }
}