using System;
using System.Collections.Generic;
using System.Globalization;

namespace Trainary
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TestCategoriaAttivita();
            //TestAttributoDiTempo();
            //TestTimeSpan();
            //TestAttributoTempo();
            //TestAttributoDistanza();
            //TestFormat();
            //TestAttributoPeso();
            //TestAttributoRipetizione();
            TestEnumUnits();

            Console.ReadLine(); 
        }

        public static void Separator()
        {
            Console.WriteLine("----------------");
        }

        //public static void TestCategoriaAttivita()
        //{
        //    Attivita corsa = new Attivita("corsa");
        //    Attivita rana = new Attivita("rana", "descrizione rana");
        //    Attivita dorso = new Attivita("dorso");
        //    Attivita saltoInAlto = new Attivita("salto in alto", "desc salto in alto",
        //        new string[] { "asta", "materasso" });
        //    Attivita saltoInLungo = new Attivita("salto in lungo", new string[] { "pedana" });
        //    Categoria atletica = new Categoria("Atletica",
        //        new Attivita[] { saltoInLungo, corsa, saltoInAlto, corsa });

        //    IList<Attivita> listNuoto = new List<Attivita>();
        //    listNuoto.Add(rana);
        //    listNuoto.Add(dorso);
        //    listNuoto.Add(rana);
        //    Categoria nuoto = new Categoria("Nuoto", listNuoto);
        //    Categoria nuoto2 = new Categoria("Nuoto", new Attivita[] { rana, dorso });

        //    Categoria generale = new Categoria("Generale",
        //        new Categoria[] { nuoto, atletica, nuoto2 });

        //    Console.WriteLine(generale.FullToString());
        //    Separator();
        //    Console.WriteLine(nuoto.FullToString());
        //    Separator();
        //    Console.WriteLine(atletica.FullToString());
        //}

        public static void TestAttributoDiTempo()
        {
            //Attributo temp1 = new AttributoDiTempo("recupero", 260, "s");
            //Attributo temp2 = new AttributoDiTempo("durata", 3, "h");
            //Attributo temp3 = new AttributoDiTempo("recupero breve", 30, "s");

            //Console.WriteLine(temp1);
            //Console.WriteLine(temp2);
            //Console.WriteLine(temp3);
            //Separator();
            //Console.WriteLine("temp1.toStandardValue() = {0}", temp1.toStandardValue());
            //Console.WriteLine("temp2.toStandardValue() = {0}", temp2.toStandardValue());
            //Console.WriteLine("temp3.toStandardValue() = {0}", temp3.toStandardValue());
            //Separator();
            //Console.WriteLine("temp1.getStandardUnita() = {0}", temp1.getStandardUnita());
            //Separator();
            //Console.WriteLine("AttributoDiTempo.getStandardUnitaDiMisura() = {0}", AttributoDiTempo.getStandardUnitaDiMisura());
            //Console.Write("AttributoDiTempo.getUnitaDiMisura() = ");
            //foreach (string s in AttributoDiTempo.getUnitaDiMisura())
            //    Console.Write(s + " ");
        }

        public static void TestTimeSpan()
        {
            Console.WriteLine("");
            Separator();
            string[] tempi = new string[] {
                "5.1:10", // 5 giorni, 1h 10min
                "1:10:20", // 1h 10min 20s
                "1:10:20.120", // 1h 10min 20s 120ms
                "3.1:10:20.200", // 3 giorni, 1h 10min 20s 200ms
                "3", // 3 giorni
                "7:50" // 7h 50min
            };

            // see also: bool TryParse(string s, out TimeSpan result);
            foreach(string s in tempi)
            {
                try
                {
                    TimeSpan ts = TimeSpan.Parse(s);
                    Console.WriteLine("TimeSpan.Parse({0}) = {1} | {2}", s, ts, ts.ToString("d' days 'h'h'"));
                    Console.WriteLine("\t{0}d {1}h {2}min {3}s {4}ms", ts.Days, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
                } catch(FormatException e)
                {
                    Console.WriteLine("{0} -> {1}", s, e.Message);
                }
            }
        }

        public static void TestAttributoTempo()
        {
            AttributoTempo attr1 = new AttributoTempo(0, 2, 3);
            AttributoTempo attr2 = new AttributoTempo(24, 60, 123);
            AttributoTempo attr3 = new AttributoTempo(new TimeSpan(1, 0, 3));
            AttributoTempo attr4 = new AttributoTempo(new TimeSpan(1, 1, 2, 3, 666));

            IAttributo sum = attr4.Add(attr3);

            Console.WriteLine("attr1 = {0} (val = {1} {2})", attr1, attr1.Valore, attr1.Unita);
            Console.WriteLine("attr2 = {0} (val = {1} {2})", attr2, attr2.Valore, attr2.Unita);
            Console.WriteLine("attr3 = {0} (val = {1} {2})", attr3, attr3.Valore, attr3.Unita);
            Console.WriteLine("attr4 = {0} (val = {1} {2})", attr4, attr4.Valore, attr4.Unita);
            Separator();
            Console.WriteLine("sum = {0} + {1} = {2}", attr3, attr4, sum);
        }

        private static void TestAttributoDistanza()
        {
            IAttributo attr1 = new AttributoDistanza(10);
            // explicit cast to AttributoDistanza
            AttributoDistanza attr2 = (AttributoDistanza)20.5678;
            // + operator
            IAttributo attr3 = attr2 + (AttributoDistanza)attr1;
            IAttributo attr4 = (AttributoDistanza)attr3 + (AttributoDistanza)attr1;
            // implicit cast to double
            double val2 = attr2;

            // AttributoFactory
            IAttributo attrDec = new ConverterDecorator(
                (AttributoDistanza)10.0,
                new LinearConverter(Units.YARD, 1 / 0.9144)
            );
            IAttributo sum = attrDec.Add(attr2);

            Console.WriteLine("attr1 = {0} (val = {1})", attr1, attr1.Valore);
            Console.WriteLine("attr2 = {0} (val = {1})", attr2, attr2.Valore);
            Console.WriteLine("attr3 = {0} (val = {1})", attr3, attr3.Valore);
            Console.WriteLine("attr4 = {0} (val = {1})", attr4, attr4.Valore);
            Separator();
            Console.WriteLine("attrDec = {0}, ToStandard() = {1}", attrDec, attrDec.ToStandard());
            Console.WriteLine("sum = {0} + {1} = {2}", attrDec, attr2, sum);
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

        private static void TestAttributoPeso()
        {
            IAttributo attr1 = new AttributoPeso(10);
            // explicit cast to AttributoPeso
            AttributoPeso attr2 = (AttributoPeso)20.5678;
            // + operator
            AttributoPeso attr3 = attr2 + (AttributoPeso)attr1;
            AttributoPeso attr4 = attr3 + attr2;
            // implicit cast to double
            double val3 = attr3;

            // AttributoFactory
            IAttributo attrDec = new ConverterDecorator(
                (AttributoPeso)10.0,
                new LinearConverter(Units.GRAM, 1000)
            );
            IAttributo sum = attrDec.Add(attr2);

            Console.WriteLine("attr1 = {0} (val = {1})", attr1, attr1.Valore);
            Console.WriteLine("attr2 = {0} (val = {1})", attr2, attr2.Valore);
            Console.WriteLine("attr3 = {0} (val = {1})", attr3, attr3.Valore);
            Console.WriteLine("attr4 = {0} (val = {1})", attr4, attr4.Valore);
            Separator();
            Console.WriteLine("attrDec = {0}, ToStandard() = {1}", attrDec, attrDec.ToStandard());
            Console.WriteLine("sum = {0} + {1} = {2}", attrDec, attr2, sum);
        }

        private static void TestAttributoRipetizione()
        {
            AttributoRipetizione attr1 = new AttributoRipetizione(15);
            AttributoRipetizione attr2 = (AttributoRipetizione)35;
            AttributoRipetizione attr3 = (AttributoRipetizione) (35 + 15);
            AttributoRipetizione attr4 = (AttributoRipetizione)35 + (AttributoRipetizione)15;
            IAttributo sum = attr4.Add(attr3);

            Console.WriteLine("attr1 = {0}\nattr2 = {1}\nattr3 = {2}\nattr4 = {3}",
                attr1, attr2, attr3, attr4);
            Console.WriteLine("sum = {0} + {1} = {2}", attr4, attr3, sum);
        }

        private static void TestEnumUnits()
        {
            Units[] allu = new Units[] {
                Units.METRE,
                Units.SECOND,
                Units.KILOGRAM,
                Units.NONE
            };
            Units u1 = Units.METRE;

            foreach(Units u in allu)
            {
                Console.WriteLine("{0}, name={1} ({2})", u, u.GetName(), u.GetSymbol());
                if (u == u1)
                    Console.WriteLine("\tuguale a {0}!", u1);
            }
        }
    }
}
