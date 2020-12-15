using System;
using System.Collections.Generic;
using ConsoleApp.Interfaces;
using ConsoleApp.Utilities;

namespace ConsoleApp.Solutions
{
    internal class SolutionDayFive : ISolution
    {
        private SolutionDayFive(string[] lines)
        {
            if (lines.Length < 1)
                throw new ArgumentException("Number of arguments less than one");
            _passes = new List<string>(lines);
        }

        private readonly List<string> _passes;

        public object SolvePartOne()
        {
            var max = int.MinValue;
            foreach (var pass in _passes)
            {
                var row = BoardingPassParser.GetRowNumber(pass);
                var col = BoardingPassParser.GetColumnNumber(pass);
                var id = row * 8 + col;
                if (id > max)
                    max = id;
            }

            return max;
        }

        public object SolvePartTwo()
        {
            var max = int.MinValue;


            return max;
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