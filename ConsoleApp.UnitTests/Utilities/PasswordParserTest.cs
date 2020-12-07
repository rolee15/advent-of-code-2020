using ConsoleApp.Utilities;
using Xunit;

namespace ConsoleApp.UnitTests.Utilities
{
    public class PasswordParserTest
    {
        [Fact]
        public void ParseLowerBoundTest()
        {
            //Given
            var line1 = "1-3 c: abcde";
            var line2 = "1-3 b: 2-5 7-9";
            var line3 = "13-9 c: ";

            //When
            var lowerBound1 = PasswordParser.ParseLowerBound(line1);
            var lowerBound2 = PasswordParser.ParseLowerBound(line2);
            var lowerBound3 = PasswordParser.ParseLowerBound(line3);

            //Then
            Assert.Equal(1, lowerBound1);
            Assert.Equal(1, lowerBound2);
            Assert.Equal(13, lowerBound3);
        }

        [Fact]
        public void ParseUpperBoundTest()
        {
            //Given
            var line1 = "1-3 c: abcde";
            var line2 = "1-3 b: 2-5 7-9";
            var line3 = "13-9 c: ";

            //When
            var upperBound1 = PasswordParser.ParseUpperBound(line1);
            var upperBound2 = PasswordParser.ParseUpperBound(line2);
            var upperBound3 = PasswordParser.ParseUpperBound(line3);

            //Then
            Assert.Equal(3, upperBound1);
            Assert.Equal(3, upperBound2);
            Assert.Equal(9, upperBound3);
        }

        [Fact]
        public void ParseCharTest()
        {
            //Given
            var line1 = "1-3 c: abcde";
            var line2 = "1-3 b: 2-5 7-9";
            var line3 = "13-9 c: ";

            //When
            var char1 = PasswordParser.ParseCharacter(line1);
            var char2 = PasswordParser.ParseCharacter(line2);
            var char3 = PasswordParser.ParseCharacter(line3);

            //Then
            Assert.Equal("c", char1);
            Assert.Equal("b", char2);
            Assert.Equal("c", char3);
        }

        [Fact]
        public void ParsePasswordTest()
        {
            //Given
            var line1 = "1-3 c: abcde";
            var line2 = "1-3 b: 2-5 7-9";
            var line3 = "13-9 c: ";

            //When
            var pass1 = PasswordParser.ParsePassword(line1);
            var pass2 = PasswordParser.ParsePassword(line2);
            var pass3 = PasswordParser.ParsePassword(line3);

            //Then
            Assert.Equal("abcde", pass1);
            Assert.Equal("2-5 7-9", pass2);
            Assert.Equal("", pass3);
        }
    }
}