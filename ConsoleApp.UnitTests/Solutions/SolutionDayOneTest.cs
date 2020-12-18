using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayOneTest
    {
        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            string[] input = {"672", "673", "675", "1001", "1002", "1003", "1004", "1019"};
            var dayOne = SolutionBase.CreateDayOneFrom(input);

            //When
            var result = dayOne.SolvePartOne();

            //Then
            Assert.Equal(1001 * 1019, result);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            //Given
            string[] input = {"672", "673", "675", "1001", "1002", "1003", "1004", "1019"};
            var dayOne = SolutionBase.CreateDayOneFrom(input);

            //When
            var result = dayOne.SolvePartTwo();

            //Then
            Assert.Equal(672 * 673 * 675, result);
        }

        [Fact]
        public void GetSecondResultMultipleGood()
        {
            //Given
            string[] input = {"1", "2", "3", "4", "5", "2015"};
            var dayOne = SolutionBase.CreateDayOneFrom(input);

            //When
            var result = dayOne.SolvePartTwo();

            //Then
            Assert.Equal(1 * 4 * 2015, result);
        }
    }
}