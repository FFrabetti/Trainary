using System;
using System.Collections.Generic;
using Trainary.model.attributi;

namespace Trainary.test.model
{
    class QuantitaFactoryTest
    {

        public static void Test()
        {
            List<string> list = new List<string>();
            try
            {
                list.Add(QuantitaFactory.StrTryNewQuantita(1, UnitaFactory.Get("km")));
                list.Add(QuantitaFactory.StrTryNewQuantita(2.8643, TipoQuantita.MASSA));
                list.Add(QuantitaFactory.StrTryNewQuantita(-2.0, TipoQuantita.NUMERO_PURO));
                list.Add(QuantitaFactory.StrTryNewQuantita(-3.3789, "g"));
                list.Add(QuantitaFactory.StrTryNewQuantita(2.200000, TipoQuantita.TEMPO));
                list.Add(QuantitaFactory.StrTryNewQuantita(new TimeSpan(2, -3, -4, 5, 667455467)));
                list.Add(QuantitaFactory.StrTryNewQuantita(7, 88, 9));
                list.Add(QuantitaFactory.StrTryNewQuantita(4456313.45630));
                list.Add(QuantitaFactory.StrTryNewQuantita(46, UnitaFactory.Get("yd")));
                list.Add(QuantitaFactory.StrTryNewQuantita(46, UnitaFactory.Get("")));

                // fail
                list.Add(QuantitaFactory.StrTryNewQuantita(2.200000, 2));
                list.Add(QuantitaFactory.StrTryNewQuantita(2.200000, 8));
                list.Add(QuantitaFactory.StrTryNewQuantita(3, "hhhh"));
                // list.Add(QuantitaFactory.StrTryNewQuantita(1, UnitaDiMisura.Get("ml")));
            }
            catch (Exception e) // se UnitaDiMisura.Get fallisce
            {
                Console.WriteLine(e);
            }

            foreach (string str in list)
                Console.WriteLine(str);
        }
    }
}
