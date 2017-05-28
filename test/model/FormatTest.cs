using System;
using System.Globalization;

namespace Trainary.test.model
{
    class FormatTest
    {

        public static void Test()
        {
            double[] numeri = new double[] {
                123456789.9876556,
                1234,
                0.12312312,
                0.1,
                5.67,
                0.998,
            };
            CultureInfo culture = CultureInfo.CurrentCulture;
            Console.WriteLine("The current culture is {0} [{1}]", culture.NativeName, culture.Name);
            CultureInfo myCI = new CultureInfo("en-US", false);
            Console.WriteLine("My culture is {0} [{1}]", myCI.NativeName, myCI.Name);

            foreach (double n in numeri)
            {
                Console.WriteLine("n = {0}", n);
                Console.WriteLine("n.ToString(\"N\", culture) = {0}", n.ToString("N", culture));
                Console.WriteLine("n.ToString(\"N2\", culture) = {0}", n.ToString("N2", culture));
                Console.WriteLine("n.ToString(\"0.##\") = {0}", n.ToString("0.##"));
                Console.WriteLine("n.ToString(\"N\", myCI) = {0}", n.ToString("N", myCI));
            }
        }
    }
}
