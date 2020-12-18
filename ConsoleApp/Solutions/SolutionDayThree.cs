using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp.Solutions
{
    internal abstract partial class SolutionBase
    {
        public static SolutionBase CreateDayThreeFrom(IEnumerable<string> lines)
        {
            return new SolutionDayThree(lines);
        }

        private class SolutionDayThree : SolutionBase
        {
            private Point _pos;

            public SolutionDayThree(IEnumerable<string> lines)
            {
                Map = new List<string>(lines);
                Height = Map.Count;
                Width = Map[0].Length;
                _pos = new Point(0, 0);
            }

            private List<string> Map { get; }
            private int Height { get; }
            private int Width { get; }

            public override string Title => "Day 3: Toboggan Trajectory";

            public override object SolvePartOne()
            {
                return CountTrees(new Slope(3, 1));
            }

            public override object SolvePartTwo()
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
}