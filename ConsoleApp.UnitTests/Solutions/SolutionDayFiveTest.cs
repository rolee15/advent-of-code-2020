using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayFiveTest
    {
        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            string[] array =
            {
                "BFFFBBFRRR",
                "FFFBBBFRRR",
                "BBFFBBFRLL"
            };
            var solution = SolutionBase.CreateDayFiveFrom(array);

            //When
            var result = solution.SolvePartOne();

            //Then
            Assert.Equal(820, result);
        }
    }
}