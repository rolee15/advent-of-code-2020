using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    public class DayOneSolution : ISolution
    {
        public List<int> Numbers { get; }
        public DayOneSolution(int[] ints)
        {
            if (ints.Length == 0)
                throw new ArgumentException();
            Numbers = new List<int>(ints);
        }

        public static DayOneSolution FromArray(int[] ints)
        {
            return new DayOneSolution(ints);
        }

        public static DayOneSolution FromList(List<int> list)
        {
            return new DayOneSolution(list.ToArray());
        }

        /// <summary>Find two numbers with sum 2020, 
        ///     and return their product.</summary>
        public int GetFirstResult()
        {
            var visited = new Dictionary<int, int>();
            foreach (var item in Numbers)
            {
                if (visited.ContainsKey(item))
                    return item * visited[item];
                else
                    visited.Add(2020 - item, item);
            }
            return 0;
        }

        public int GetFirstResult(bool isMeasuring)
        {
            int res;
            if (isMeasuring)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                res = GetFirstResult();
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                Console.WriteLine("RunTime {0}ms", ts.Milliseconds);
                Console.WriteLine("Ticks {0}", ts.Ticks);
            }
            else
            {
                res = GetFirstResult();
            }

            return res;
        }

        /// <summary>Find three numbers with sum 2020, 
        ///     and return their product.</summary>
        public int GetSecondResult()
        {
            var visited = new Dictionary<int, (int, int)>();
            for (int i = 0; i < Numbers.Count; i++)
            {
                for (int j = i + 1; j < Numbers.Count; j++)
                {
                    int a = Numbers[i];
                    int b = Numbers[j];
                    if (visited.ContainsKey(a))
                        return a * visited[a].Item1 * visited[a].Item2;
                    else if (visited.ContainsKey(b))
                        return b * visited[b].Item1 * visited[b].Item2;
                    else
                    {
                        int sum = 2020 - a - b;
                        if (!visited.ContainsKey(sum))
                            visited.Add(sum, (a, b));
                    }
                }
            }
            return 0;
        }
    }
}