using System;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.Tests
{
    public class DayOneTest
    {
        [Fact]
        public void InitializingWithEmptyListThrowsArgumentException()
        {
            //Given
            int[] ints = {};

            //Then
            Assert.Throws<ArgumentException>(() => new DayOneSolution(ints));
        }

        [Fact]
        public void FactoryMethodWithEmptyListThrowsArgumentException()
        {
            //Given
            int[] ints = {};

            //Then
            Assert.Throws<ArgumentException>(() => new DayOneSolution(ints));
        }

        [Fact]
        public void GetResultTest()
        {
            //Given
            int[] ints = { 1001, 1002, 1003, 1004, 1019 };
            var dayOne = new DayOneSolution(ints);

            //When
            var x = dayOne.GetResult();

            //Then
            //Assert.Equal(1001 * 1019, x);
        }
    }
}
