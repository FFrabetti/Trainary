using System;
using System.Collections.Generic;
using Trainary.model;

namespace Trainary.test.model
{
    class CategoriaAttivitaTest
    {

        public static void Test()
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
            Console.WriteLine(nuoto.FullToString());
            Console.WriteLine(atletica.FullToString());
        }
    }
}
