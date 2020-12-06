using System;
using System.Collections.Generic;

namespace ConsoleApp.Solutions
{
    public sealed class SolutionDayOne : SolutionBase
    {
        public SolutionDayOne(int[] ints)
        {
            if (ints.Length < 3)
                throw new ArgumentException("Number of arguments less than three");
            Numbers = new List<int>(ints);
        }

        private List<int> Numbers { get; }

        /// <summary>
        ///     Find two numbers with sum 2020,
        ///     and return their product.
        /// </summary>
        protected override void SolvePartOne()
        {
            var visited = new Dictionary<int, int>();
            foreach (var item in Numbers)
                if (visited.ContainsKey(item))
                    FirstResult = item * visited[item];
                else
                    visited.Add(2020 - item, item);
        }

        /// <summary>
        ///     Find three numbers with sum 2020,
        ///     and return their product.
        /// </summary>
        protected override void SolvePartTwo()
        {
            var visited = new Dictionary<int, (int, int)>();
            for (var i = 0; i < Numbers.Count; i++)
            for (var j = i + 1; j < Numbers.Count; j++)
            {
                var a = Numbers[i];
                var b = Numbers[j];
                if (visited.ContainsKey(a))
                {
                    SecondResult = a * visited[a].Item1 * visited[a].Item2;
                }
                else if (visited.ContainsKey(b))
                {
                    SecondResult = b * visited[b].Item1 * visited[b].Item2;
                }
                else
                {
                    var sum = 2020 - a - b;
                    if (!visited.ContainsKey(sum))
                        visited.Add(sum, (a, b));
                }
            }
        }

        public static SolutionDayOne FromArray(int[] ints)
        {
            return new SolutionDayOne(ints);
        }

        public static SolutionDayOne FromList(List<int> list)
        {
            return new SolutionDayOne(list.ToArray());
        }
    }
}