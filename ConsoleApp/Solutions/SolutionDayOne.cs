using System.Collections.Generic;

namespace ConsoleApp.Solutions
{
    internal abstract partial class SolutionBase
    {
        public static SolutionBase CreateDayOneFrom(IEnumerable<string> lines)
        {
            return new SolutionDayOne(lines);
        }

        private class SolutionDayOne : SolutionBase
        {
            public SolutionDayOne(IEnumerable<string> input)
            {
                var ints = ParseNumbers(input);
                Numbers = new List<int>(ints);
            }

            private List<int> Numbers { get; }
            public override string Title => "Day 1: Report Repair";

            public override object SolvePartOne()
            {
                var visited = new Dictionary<int, int>();
                foreach (var item in Numbers)
                    if (visited.ContainsKey(item))
                        return item * visited[item];
                    else
                        visited.Add(2020 - item, item);
                return null;
            }

            public override object SolvePartTwo()
            {
                var visited = new Dictionary<int, (int, int)>();
                for (var i = 0; i < Numbers.Count - 1; i++)
                for (var j = i + 1; j < Numbers.Count; j++)
                {
                    var a = Numbers[i];
                    var b = Numbers[j];
                    if (visited.ContainsKey(a)) return a * visited[a].Item1 * visited[a].Item2;

                    if (visited.ContainsKey(b)) return b * visited[b].Item1 * visited[b].Item2;

                    var sum = 2020 - a - b;
                    if (!visited.ContainsKey(sum))
                        visited.Add(sum, (a, b));
                }

                return null;
            }

            private IEnumerable<int> ParseNumbers(IEnumerable<string> lines)
            {
                foreach (var line in lines)
                    yield return int.Parse(line);
            }
        }
    }
}