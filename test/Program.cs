using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using Trainary.attributi;
using Trainary.test;

namespace Trainary
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }

        /*
        public static void Main(string[] args)
        {
            //TestCategoriaAttivita();
            //Separator();
            //TestFormat();
            //Separator();
            //TestAttributoTempo();
            //TestPeriodoDiValidita();
            TestQuantitaFactory();

            Console.ReadLine(); 
        }
        */

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
            Separator();
            Console.WriteLine("sum = {0} + {1} = {2}", attr3.Quantita, attr4.Quantita, sum.Quantita);
        }

        private static void TestPeriodoDiValidita()
        {
            DateTime inizio = DateTime.Today;
            DateTime fine = inizio.Add(new TimeSpan(1, 0, 0, 0));
            PeriodoDiValidita periodo = new PeriodoDiValidita(inizio, fine);
            DateTime prova = default(DateTime);
            Console.WriteLine("default = {1} ({0})", periodo.IsNelPeriodo(prova), default(DateTime));
            Console.WriteLine("ToString = {0}", periodo);
            Console.WriteLine("FullToString = {0}", periodo.FullToString());
        }

        private static void TestQuantitaFactory()
        {
            List<string> list = new List<string>();
            try
            {
                list.Add(QuantitaFactory.StrTryNewQuantita(1, UnitaDiMisura.Get("km")));
                list.Add(QuantitaFactory.StrTryNewQuantita(2.8643, TipoQuantita.MASS));
                list.Add(QuantitaFactory.StrTryNewQuantita(-2.0, TipoQuantita.PURE_NUMBER));
                list.Add(QuantitaFactory.StrTryNewQuantita(-3.3789, "g"));
                list.Add(QuantitaFactory.StrTryNewQuantita(2.200000, TipoQuantita.TIME));
                list.Add(QuantitaFactory.StrTryNewQuantita(new TimeSpan(2, -3, -4, 5, 667455467)));
                list.Add(QuantitaFactory.StrTryNewQuantita(7, 88, 9));
                list.Add(QuantitaFactory.StrTryNewQuantita(4456313.45630));
                list.Add(QuantitaFactory.StrTryNewQuantita(46, UnitaDiMisura.Get("yd")));
                list.Add(QuantitaFactory.StrTryNewQuantita(46, UnitaDiMisura.Get("")));

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
