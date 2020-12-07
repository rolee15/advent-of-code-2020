using System;
using System.Collections.Generic;
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
            string line1 = "1-3 c: abcde";
            string line2 = "1-3 b: 2-5 7-9";
            string line3 = "13-9 c: ";

            //When
            int lowerBound1 = PasswordParser.ParseLowerBound(line1);
            int lowerBound2 = PasswordParser.ParseLowerBound(line2);
            int lowerBound3 = PasswordParser.ParseLowerBound(line3);

            //Then
            Assert.Equal(1, lowerBound1);
            Assert.Equal(1, lowerBound2);
            Assert.Equal(13, lowerBound3);
        }

        [Fact]
        public void ParseUpperBoundTest()
        {
            //Given
            string line1 = "1-3 c: abcde";
            string line2 = "1-3 b: 2-5 7-9";
            string line3 = "13-9 c: ";

            //When
            int upperBound1 = PasswordParser.ParseUpperBound(line1);
            int upperBound2 = PasswordParser.ParseUpperBound(line2);
            int upperBound3 = PasswordParser.ParseUpperBound(line3);

            //Then
            Assert.Equal(3, upperBound1);
            Assert.Equal(3, upperBound2);
            Assert.Equal(9, upperBound3);
        }

        [Fact]
        public void ParseCharTest()
        {
            //Given
            string line1 = "1-3 c: abcde";
            string line2 = "1-3 b: 2-5 7-9";
            string line3 = "13-9 c: ";

            //When
            string char1 = PasswordParser.ParseCharacter(line1);
            string char2 = PasswordParser.ParseCharacter(line2);
            string char3 = PasswordParser.ParseCharacter(line3);

            //Then
            Assert.Equal("c", char1);
            Assert.Equal("b", char2);
            Assert.Equal("c", char3);
        }

        [Fact]
        public void ParsePasswordTest()
        {
            //Given
            string line1 = "1-3 c: abcde";
            string line2 = "1-3 b: 2-5 7-9";
            string line3 = "13-9 c: ";

            //When
            string pass1 = PasswordParser.ParsePassword(line1);
            string pass2 = PasswordParser.ParsePassword(line2);
            string pass3 = PasswordParser.ParsePassword(line3);

            //Then
            Assert.Equal("abcde", pass1);
            Assert.Equal("2-5 7-9", pass2);
            Assert.Equal("", pass3);
        }
    }
}