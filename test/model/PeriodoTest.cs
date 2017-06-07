using System;
using Trainary.model;

namespace Trainary.test.model
{
    class PeriodoTest
    {

        public static void Test()
        {
            DateTime inizio = DateTime.Today;
            DateTime fine = inizio.Add(new TimeSpan(1, 0, 0, 0));
            Periodo periodo = new Periodo(inizio, fine);
            DateTime prova = default(DateTime);
            Console.WriteLine("default = {1} ({0})", periodo.IsNelPeriodo(prova), default(DateTime));
            Console.WriteLine("ToString = {0}", periodo);
            Console.WriteLine("FullToString = {0}", periodo.ToFullString());
        }
    }
}
