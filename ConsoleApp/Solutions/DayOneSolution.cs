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
        public int GetResult()
        {
            Dictionary<int, int> visited = new Dictionary<int, int>();
            foreach (var item in Numbers)
            {
                if (visited.ContainsKey(item))
                    return item * visited[item];
                else
                    visited.Add(2020 - item, item);
            }
            return 0;
        }

        public int GetResult(bool isMeasuring)
        {
            int res;
            if (isMeasuring)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                res = GetResult();
                stopWatch.Stop();
                // Get the elapsed time as a TimeSpan value.
                TimeSpan ts = stopWatch.Elapsed;

                Console.WriteLine("RunTime {0}ms", ts.Milliseconds);
                Console.WriteLine("Ticks {0}", ts.Ticks);
            }
            else
            {
                res = GetResult();
            }

            return res;
        }
    }
}