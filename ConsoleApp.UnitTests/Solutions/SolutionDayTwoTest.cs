using System;
using System.Collections.Generic;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayTwoTest
    {
        [Fact]
        public void ArrayFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            string[] array = { };

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayTwo.FromArray(array));
        }

        [Fact]
        public void ListFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            var list = new List<string>();

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayTwo.FromList(list));
        }

        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            var solution = Init();

            //When
            var result = solution.SolvePartOne();

            //Then
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            //Given
            var solution = Init();

            //When
            var result = solution.SolvePartTwo();

            //Then
            Assert.Equal(1, result);
        }

        private static SolutionDayTwo Init()
        {
            string[] array =
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            var solution = SolutionDayTwo.FromArray(array);
            return solution;
        }
    }
}