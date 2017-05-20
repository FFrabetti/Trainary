using System;

namespace Trainary
{
    static class FormatUtils
    {
        public static string ToMaxTwoDecimals(double value)
        {
            return value.ToString("0.##");
        }

        public static string ToStringDate(DateTime dateTime)
        {
            return dateTime.ToString("d");
        }
    }
}
