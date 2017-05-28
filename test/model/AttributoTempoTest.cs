using System;
using Trainary.model.attributi;

namespace Trainary.test.model
{
    class AttributoTempoTest
    {

        public static void Test()
        {
            Attributo attr1 = new Attributo(
                "attr1",
                QuantitaFactory.NewQuantita(0, 2, 3)
            );
            Attributo attr2 = new Attributo(
                "attr2",
                QuantitaFactory.NewQuantita(24, 60, 123)
            );
            Attributo attr3 = new Attributo(
                "attr3",
                QuantitaFactory.NewQuantita(new TimeSpan(1, 0, 3))
            );
            Attributo attr4 = new Attributo(
                "attr4",
                QuantitaFactory.NewQuantita(new TimeSpan(1, 1, 2, 3, 666))
            );

            //IAttributo sum = attr4.Add(attr3);
            Attributo sum = new Attributo(
                "somma",
                QuantitaFactory.NewQuantita(
                    attr3.Quantita.toStandard() + attr4.Quantita.toStandard(),
                    attr3.Quantita.Tipo
                )
            );

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", attr1, attr2, attr3, attr4);
            Console.WriteLine("sum = {0} + {1} = {2}", attr3.Quantita, attr4.Quantita, sum.Quantita);
        }
    }
}
