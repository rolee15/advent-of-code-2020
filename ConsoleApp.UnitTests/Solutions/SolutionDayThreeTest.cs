using System;
using System.Collections.Generic;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayThreeTest
    {
        [Fact]
        public void ArrayFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            string[] array = { };

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayThree.FromArray(array));
        }

        [Fact]
        public void ListFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            var list = new List<string>();

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayThree.FromList(list));
        }

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

        private static SolutionDayThree Init()
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
            var solution = SolutionDayThree.FromArray(array);
            return solution;
        }
    }
}