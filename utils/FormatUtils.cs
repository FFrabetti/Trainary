using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    static class FormatUtils
    {
        public static string ToMaxTwoDecimals(double value)
        {
            return value.ToString("0.##");
        }
    }
}
