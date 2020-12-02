using System;
using System.Collections.Generic;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    public class DayOneSolution : ISolution
    {
        public IEnumerable<int> Numbers { get; }
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

        /// <summary>Find two numbers with sum 2020, 
        ///     and return their product.</summary>
        public int GetResult()
        {
            return 0;
        }
    }
}