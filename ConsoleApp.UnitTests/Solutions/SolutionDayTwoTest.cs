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
            SolutionDayTwo solution = InitAndRun();

            //Then
            Assert.Equal(2, solution.FirstResult);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            SolutionDayTwo solution = InitAndRun();

            //Then
            Assert.Equal(1, solution.SecondResult);
        }

        private static SolutionDayTwo InitAndRun()
        {
            //Given
            string[] array =
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            var solution = SolutionDayTwo.FromArray(array);

            //When
            solution.Solve();
            return solution;
        }
    }
}