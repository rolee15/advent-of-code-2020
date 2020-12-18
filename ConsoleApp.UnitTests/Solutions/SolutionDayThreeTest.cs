using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayThreeTest
    {
        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            var solution = Init();

            //When
            var result = solution.SolvePartOne();

            //Then
            Assert.Equal(7, result);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            //Given
            var solution = Init();

            //When
            var result = solution.SolvePartTwo();

            //Then
            Assert.Equal(336L, result);
        }

        private static SolutionBase Init()
        {
            string[] array =
            {
                "..##.......",
                "#...#...#..",
                ".#....#..#.",
                "..#.#...#.#",
                ".#...##..#.",
                "..#.##.....",
                ".#.#.#....#",
                ".#........#",
                "#.##...#...",
                "#...##....#",
                ".#..#...#.#"
            };
            var solution = SolutionBase.CreateDayThreeFrom(array);
            return solution;
        }
    }
}