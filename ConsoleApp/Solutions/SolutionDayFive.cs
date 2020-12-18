using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Utilities;

namespace ConsoleApp.Solutions
{
    internal abstract partial class SolutionBase
    {
        public static SolutionBase CreateDayFiveFrom(IEnumerable<string> lines)
        {
            return new SolutionDayFive(lines);
        }

        private class SolutionDayFive : SolutionBase
        {
            private readonly IEnumerable<int> _ids;

            public SolutionDayFive(IEnumerable<string> input)
            {
                _ids = input.Select(BoardingPassParser.GetId);
            }

            public override string Title => "Day 5: Binary Boarding";

            public override object SolvePartOne()
            {
                return _ids.Max();
            }

            public override object SolvePartTwo()
            {
                var minId = _ids.Min();
                var maxId = _ids.Max();
                var missingIds = Enumerable.Range(minId, maxId).Where(id => !_ids.Contains(id));
                return missingIds.FirstOrDefault(id => _ids.Contains(id - 1) && _ids.Contains(id + 1));
            }
        }
    }
}