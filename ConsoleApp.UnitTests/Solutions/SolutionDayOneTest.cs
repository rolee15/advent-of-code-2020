using System;
using System.Collections.Generic;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayOneTest
    {
        [Fact]
        public void ArrayFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            int[] array0 = { };
            int[] array1 = {1};
            int[] array2 = {1, 2};

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayOne.FromArray(array0));
            Assert.Throws<ArgumentException>(() => SolutionDayOne.FromArray(array1));
            Assert.Throws<ArgumentException>(() => SolutionDayOne.FromArray(array2));
        }

        [Fact]
        public void ListFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            var list0 = new List<int>();
            var list1 = new List<int> {1};
            var list2 = new List<int> {1, 2};

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayOne.FromList(list0));
            Assert.Throws<ArgumentException>(() => SolutionDayOne.FromList(list1));
            Assert.Throws<ArgumentException>(() => SolutionDayOne.FromList(list2));
        }

        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            int[] ints = {672, 673, 675, 1001, 1002, 1003, 1004, 1019};
            var dayOne = SolutionDayOne.FromArray(ints);

            //When
            var result = dayOne.SolvePartOne();

            //Then
            Assert.Equal(1001 * 1019, result);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            //Given
            int[] ints = {672, 673, 675, 1001, 1002, 1003, 1004, 1019};
            var dayOne = SolutionDayOne.FromArray(ints);

            //When
            var result = dayOne.SolvePartTwo();

            //Then
            Assert.Equal(672 * 673 * 675, result);
        }

        [Fact]
        public void GetSecondResultMultipleGood()
        {
            //Given
            int[] ints = {1, 2, 3, 4, 5, 2015};
            var dayOne = SolutionDayOne.FromArray(ints);

            //When
            var result = dayOne.SolvePartTwo();

            //Then
            Assert.Equal(1 * 4 * 2015, result);
        }
    }
}