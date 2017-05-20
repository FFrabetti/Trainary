using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary.attributi2
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestAttributoTempo();

            Console.ReadLine();
        }

        public static void Separator()
        {
            Console.WriteLine("----------------");
        }

        public static void TestAttributoTempo()
        {
            IAttributo attr1 = new Attributo(
                "attr1",
                QuantitaFactory.newQuantita(0, 2, 3)
            );
            IAttributo attr2 = new Attributo(
                "attr2",
                QuantitaFactory.newQuantita(24, 60, 123)
            );
            IAttributo attr3 = new Attributo(
                "attr3",
                QuantitaFactory.newQuantita(new TimeSpan(1, 0, 3))
            );
            IAttributo attr4 = new Attributo(
                "attr4",
                QuantitaFactory.newQuantita(new TimeSpan(1, 1, 2, 3, 666))
            );

            //IAttributo sum = attr4.Add(attr3);
            IAttributo sum = new Attributo(
                "somma",
                QuantitaFactory.newQuantita(
                    attr3.Quantita.toStandard() + attr4.Quantita.toStandard(),
                    attr3.Quantita.Tipo
                )
            );

            Console.WriteLine("{0}\n{1}\n{2}\n{3}", attr1, attr2, attr3, attr4);
            Separator();
            Console.WriteLine("sum = {0} + {1} = {2}", attr3.Quantita, attr4.Quantita, sum.Quantita);
        }

    }
}
