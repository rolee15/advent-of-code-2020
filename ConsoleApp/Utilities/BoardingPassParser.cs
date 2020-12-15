using System;

namespace ConsoleApp.Utilities
{
    internal class BoardingPassParser
    {
        internal static object GetRowNumber(string pass)
        {
            var rows = pass.Substring(0, 7);
            rows = rows.Replace('F', '0').Replace('B', '1');
            return  Convert.ToInt32(rows, 2);
        }

        internal static object GetColumnNumber(string pass)
        {
            var rows = pass.Substring(7);
            rows = rows.Replace('L', '0').Replace('R', '1');
            return  Convert.ToInt32(rows, 2);
        }
    }
}