using System;
using System.Collections.Generic;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.Tests.UnitTests
{
    public class DayOneSolutionTest
    {
        [Fact]
        public void InitializingWithEmptyListThrowsArgumentException()
        {
            //Given
            int[] ints = { };

            //Then
            Assert.Throws<ArgumentException>(() => new DayOneSolution(ints));
        }

        [Fact]
        public void ArrayFactoryMethodWithEmptyListThrowsArgumentException()
        {
            //Given
            int[] array = { };

            //Then
            Assert.Throws<ArgumentException>(() => DayOneSolution.FromArray(array));
        }
        [Fact]
        public void ListFactoryMethodWithEmptyListThrowsArgumentException()
        {
            //Given
            List<int> list = new List<int>();

            //Then
            Assert.Throws<ArgumentException>(() => DayOneSolution.FromList(list));
        }

        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            int[] ints = { 672, 673, 675, 1001, 1002, 1003, 1004, 1019 };
            var dayOne = new DayOneSolution(ints);

            //When
            var x = dayOne.GetFirstResult();

            //Then
            Assert.Equal(1001 * 1019, x);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            //Given
            int[] ints = { 672, 673, 675, 1001, 1002, 1003, 1004, 1019 };
            var dayOne = new DayOneSolution(ints);

            //When
            var x = dayOne.GetSecondResult();

            //Then
            Assert.Equal(672 * 673 * 675, x);
        }

        [Fact]
        public void GetSecondResultMultipleGood()
        {
            //Given
            int[] ints = { 1, 2, 3, 4, 5, 2015};
            var dayOne = new DayOneSolution(ints);

            //When
            var x = dayOne.GetSecondResult();

            //Then
            Assert.Equal(1 * 4 * 2015, x);
        }
    }
}
