using System;
using System.Collections.Generic;
using System.Linq;
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
            _ids = lines.Select(pass => BoardingPassParser.GetID(pass));
        }
        private readonly IEnumerable<int> _ids;

        public object SolvePartOne()
            => _ids.Max();

        public object SolvePartTwo()
        {
            var minId = _ids.Min();
            var maxId = _ids.Max();
            var missingIds = Enumerable.Range(minId, maxId).Where(id => !_ids.Contains(id));
            var id = missingIds.Where(id => _ids.Contains(id - 1) && _ids.Contains(id + 1)).FirstOrDefault();

            return id;
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