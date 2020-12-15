using System;
using System.Collections.Generic;
using System.Drawing;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    internal class SolutionDayThree : ISolution
    {
        private Point _pos;

        private SolutionDayThree(string[] lines)
        {
            if (lines.Length < 1)
                throw new ArgumentException("Number of arguments less than one");
            Map = new List<string>(lines);
            Height = lines.Length;
            Width = lines[0].Length;
            _pos = new Point(0, 0);
        }

        private List<string> Map { get; }
        private int Height { get; }
        private int Width { get; }

        /// <summary>
        ///     Given the map of the area, starting from the top left corner,
        ///     how many trees(#) do you encounter by jumping three to the
        ///     right, and on to the bottom.
        /// </summary>
        public object SolvePartOne()
        {
            return CountTrees(new Slope(3, 1));
        }

        /// <summary>
        ///     Given multiple jump methods, calculate the number of
        ///     encountered trees for all of them, and return their product.
        /// </summary>
        public object SolvePartTwo()
        {
            Slope[] slopes =
            {
                new Slope(1, 1),
                new Slope(3, 1),
                new Slope(5, 1),
                new Slope(7, 1),
                new Slope(1, 2)
            };

            long product = 1;
            foreach (var slope in slopes)
            {
                InitStartPosition();
                var count = CountTrees(slope);
                product *= count;
            }

            return product;
        }

        private void InitStartPosition()
        {
            _pos.X = 0;
            _pos.Y = 0;
        }

        private int CountTrees(Slope s)
        {
            var count = 0;
            do
            {
                Jump(s.Right, s.Down);
                if (IsOnTree())
                    count++;
            } while (_pos.Y < Height - 1);

            return count;
        }

        private void Jump(int right, int down)
        {
            _pos.X = (_pos.X + right) % Width;
            _pos.Y += down;
        }

        private bool IsOnTree()
        {
            if (_pos.Y < Height && _pos.X < Width)
                return Map[_pos.Y][_pos.X] == '#';
            return false;
        }

        internal static SolutionDayThree FromArray(string[] lines)
        {
            return new SolutionDayThree(lines);
        }

        public static SolutionDayThree FromList(List<string> list)
        {
            return new SolutionDayThree(list.ToArray());
        }

        private class Slope
        {
            public Slope(int right, int down)
            {
                Right = right;
                Down = down;
            }

            public int Right { get; }
            public int Down { get; }
        }
    }
}