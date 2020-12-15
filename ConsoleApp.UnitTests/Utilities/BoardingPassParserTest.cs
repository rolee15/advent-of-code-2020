using ConsoleApp.Utilities;
using Xunit;

namespace ConsoleApp.UnitTests.Utilities
{
    public class BoardingPassParserTest
    {
        [Fact]
        public void GetRowNumberTest()
        {
            //Given
            var pass = "FBFBBFFRLR";
            
            //When
            var row = BoardingPassParser.GetRowNumber(pass);
            
            //Then
            Assert.Equal(44, row);
        }

        [Fact]
        public void GetColumnNumberTest()
        {
            //Given
            var pass = "FBFBBFFRLR";
            
            //When
            var row = BoardingPassParser.GetColumnNumber(pass);
            
            //Then
            Assert.Equal(5, row);
        }
    }
}