using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.Tests
{
    public class DayOneTest
    {
        [Fact]
        public void GetProductTest()
        {
            // ARRANGE
            int[] ints = { 1001, 1002, 1003, 1004, 1019 };
            var dayOne = new DayOneSolution(ints);

            // ACT
            var x = dayOne.GetResult();

            // ASSERT
            Assert.Equal(1001 * 1019, x);
        }
    }
}
