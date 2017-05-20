using System;
using System.Collections.Generic;
using System.Globalization;
using Trainary.attributi;

namespace Trainary
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestCategoriaAttivita();
            Separator();
            TestFormat();
            Separator();
            TestAttributoTempo();

            Console.ReadLine(); 
        }

        public static void Separator()
        {
            Console.WriteLine("----------------");
        }

        public static void TestCategoriaAttivita()
        {
            Attivita corsa = new Attivita("corsa");
            Attivita rana = new Attivita("rana", "descrizione rana");
            Attivita dorso = new Attivita("dorso");
            Attivita saltoInAlto = new Attivita("salto in alto", "desc salto in alto",
                new string[] { "asta", "materasso" });
            Attivita saltoInLungo = new Attivita("salto in lungo", new string[] { "pedana" });
            Categoria atletica = new Categoria("Atletica",
                new Attivita[] { saltoInLungo, corsa, saltoInAlto, corsa });

            IList<Attivita> listNuoto = new List<Attivita>();
            listNuoto.Add(rana);
            listNuoto.Add(dorso);
            listNuoto.Add(rana);
            Categoria nuoto = new Categoria("Nuoto", listNuoto);
            Categoria nuoto2 = new Categoria("Nuoto", new Attivita[] { rana, dorso });

            Categoria generale = new Categoria("Generale",
                new Categoria[] { nuoto, atletica, nuoto2 });

            Console.WriteLine(generale.FullToString());
            Separator();
            Console.WriteLine(nuoto.FullToString());
            Separator();
            Console.WriteLine(atletica.FullToString());
        }

        public static void TestFormat()
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
                Separator();
                Console.WriteLine("n = {0}", n);
                Console.WriteLine("n.ToString(\"N\", culture) = {0}", n.ToString("N", culture));
                Console.WriteLine("n.ToString(\"N2\", culture) = {0}", n.ToString("N2", culture));
                Console.WriteLine("n.ToString(\"0.##\") = {0}", n.ToString("0.##"));
                Console.WriteLine("n.ToString(\"N\", myCI) = {0}", n.ToString("N", myCI));
            }
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
