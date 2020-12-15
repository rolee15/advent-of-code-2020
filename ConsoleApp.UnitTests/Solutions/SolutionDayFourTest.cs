using System;
using System.Collections.Generic;
using ConsoleApp.Solutions;
using Xunit;

namespace ConsoleApp.UnitTests.Solutions
{
    public class SolutionDayFourTest
    {
        [Fact]
        public void ArrayFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            string[] array = { };

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayFour.FromArray(array));
        }

        [Fact]
        public void ListFactoryMethodWithIncorrectListsThrowsArgumentException()
        {
            //Given
            var list = new List<string>();

            //Then
            Assert.Throws<ArgumentException>(() => SolutionDayFour.FromList(list));
        }

        [Fact]
        public void GetFirstResultTest()
        {
            //Given
            var solution = Init();

            //When
            var result = solution.SolvePartOne();

            //Then
            Assert.Equal(2, result);
        }

        [Fact]
        public void GetSecondResultTest()
        {
            //Given
            var solution = Init();

            //When
            var result = solution.SolvePartTwo();

            //Then
            Assert.Equal(null, result);
        }

        private static SolutionDayFour Init()
        {
            string[] array =
            {
                "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd",
                "byr:1937 iyr:2017 cid:147 hgt:183cm",
                "",
                "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884",
                "hcl:#cfa07d byr:1929",
                "",
                "hcl:#ae17e1 iyr:2013",
                "eyr:2024",
                "ecl:brn pid:760753108 byr:1931",
                "hgt:179cm",
                "",
                "hcl:#cfa07d eyr:2025 pid:166559648",
                "iyr:2011 ecl:brn hgt:59in"
            };
            var solution = SolutionDayFour.FromArray(array);
            return solution;
        }
    }
}