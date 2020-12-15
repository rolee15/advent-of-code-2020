using System;
using System.Collections.Generic;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayFiveTest
    {
        [Fact]
        public void ArrayFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            string[] array = { };

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayFive.FromArray(array));
        }

        [Fact]
        public void ListFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            var list = new List<string>();

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayFive.FromList(list));
        }

        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            string[] array = {
                "BFFFBBFRRR",
                "FFFBBBFRRR",
                "BBFFBBFRLL"
                };
            var solution = SolutionDayFive.FromArray(array);

            //When
            var result = solution.SolvePartOne();

            //Then
            Assert.Equal(820, result);
        }
    }
}