using System;

namespace ConsoleApp.Utilities
{
    internal static class BoardingPassParser
    {
        internal static int GetRowNumber(string pass)
        {
            var rows = pass.Substring(0, 7);
            rows = rows.Replace('F', '0').Replace('B', '1');
            return Convert.ToInt32(rows, 2);
        }

        internal static int GetColumnNumber(string pass)
        {
            var rows = pass.Substring(7);
            rows = rows.Replace('L', '0').Replace('R', '1');
            return Convert.ToInt32(rows, 2);
        }

        internal static int GetId(string pass)
        {
            var row = GetRowNumber(pass);
            var col = GetColumnNumber(pass);
            return row * 8 + col;
        }
    }
}