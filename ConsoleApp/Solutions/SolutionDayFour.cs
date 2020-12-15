using System;
using System.Collections.Generic;
using ConsoleApp.Interfaces;

namespace ConsoleApp.Solutions
{
    internal class SolutionDayFour : ISolution
    {
        private SolutionDayFour(string[] lines)
        {
            if (lines.Length < 1)
                throw new ArgumentException("Number of arguments less than one");
            var tokens = Tokenize(lines);
            Passports = Parse(tokens);
        }

        private List<Passport> Passports { get; }

        /// <summary>
        ///     Given the map of the area, starting from the top left corner,
        ///     how many trees(#) do you encounter by jumping three to the
        ///     right, and on to the bottom.
        /// </summary>
        public object SolvePartOne()
        {
            var count = 0;
            foreach (var passport in Passports)
                if (passport.HasMandatories())
                    count++;

            return count;
        }

        /// <summary>
        ///     Given multiple jump methods, calculate the number of
        ///     encountered trees for all of them, and return their product.
        /// </summary>
        public object SolvePartTwo()
        {
            var count = 0;
            foreach (var passport in Passports)
                if (passport.HasMandatories() && passport.IsValid)
                    count++;

            return count;
        }

        private List<string> Tokenize(string[] lines)
        {
            var list = new List<string>();
            foreach (var item in lines) list.AddRange(item.Split(' '));
            return list;
        }

        private List<Passport> Parse(List<string> tokens)
        {
            var passports = new List<Passport>();
            var p = new Passport();
            foreach (string token in tokens)
                if (string.IsNullOrWhiteSpace(token))
                {
                    passports.Add(p);
                    p = new Passport();
                }
                else
                {
                    var items = token.Split(':');
                    if (items.Length == 2)
                    {
                        var key = items[0];
                        var value = items[1];
                        p.MapProperty(key, value);
                    }
                }

            passports.Add(p);

            return passports;
        }

        internal static SolutionDayFour FromArray(string[] lines)
        {
            return new SolutionDayFour(lines);
        }

        public static SolutionDayFour FromList(List<string> list)
        {
            return new SolutionDayFour(list.ToArray());
        }

        private class Passport
        {
            private readonly List<string> _eyeColors = new List<string>
            {
                "amb", "blu", "brn", "gry", "grn", "hzl", "oth"
            };

            private readonly List<string> _mandatory = new List<string>
            {
                "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"
            };

            private readonly List<string> _props = new List<string>();

            private int BirthYear { get; set; }
            private int IssueYear { get; set; }
            private int ExpirationYear { get; set; }
            private string Height { get; set; }
            private string HairColor { get; set; }
            private string EyeColor { get; set; }
            private string PassportId { get; set; }
            private string CountryId { get; set; }
            public bool IsValid { get; private set; } = true;

            public void MapProperty(string key, string value)
            {
                switch (key)
                {
                    case "byr":
                        BirthYear = int.Parse(value);
                        IsValid &= 1920 <= BirthYear && BirthYear <= 2002;
                        break;
                    case "iyr":
                        IssueYear = int.Parse(value);
                        IsValid &= 2010 <= IssueYear && IssueYear <= 2020;
                        break;
                    case "eyr":
                        ExpirationYear = int.Parse(value);
                        IsValid &= 2020 <= ExpirationYear && ExpirationYear <= 2030;
                        break;
                    case "hgt":
                        Height = value;
                        if (Height.EndsWith("cm"))
                        {
                            var heightInt = int.Parse(Height.Substring(0, Height.Length - 2));
                            IsValid &= 150 <= heightInt && heightInt <= 193;
                        }
                        else if (Height.EndsWith("in"))
                        {
                            var heightInt = int.Parse(Height.Substring(0, Height.Length - 2));
                            IsValid &= 59 <= heightInt && heightInt <= 76;
                        }
                        else
                        {
                            IsValid = false;
                        }

                        break;
                    case "hcl":
                        HairColor = value;
                        IsValid &= HairColor.StartsWith("#");
                        foreach (var ch in HairColor.Substring(1))
                            IsValid &= 'a' <= ch && ch <= 'z' || '0' <= ch && ch <= '9';
                        break;
                    case "ecl":
                        EyeColor = value;
                        IsValid &= _eyeColors.Contains(EyeColor);
                        break;
                    case "pid":
                        PassportId = value;
                        IsValid &= PassportId.Length == 9;
                        break;
                    case "cid":
                        CountryId = value;
                        break;
                    default:
                        throw new ArgumentException("Not a known field", nameof(key));
                }
                _props.Add(key);
            }

            public bool HasMandatories()
            {
                foreach (var prop in _mandatory)
                    if (!_props.Contains(prop))
                        return false;
                return true;
            }
        }
    }
}