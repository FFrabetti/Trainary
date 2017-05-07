using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainary
{
    class Program
    {

        public static void Main(string[] args)
        {
            Attivita corsa = new Attivita("corsa");
            Attivita rana = new Attivita("rana", "descrizione rana");
            Attivita dorso = new Attivita("dorso");
            Attivita saltoInAlto = new Attivita("salto in alto", "desc salto in alto",
                new string[] { "asta" , "materasso"});
            Attivita saltoInLungo = new Attivita("salto in lungo", new string[] { "pedana" });

            //ISet<Attivita> setAtletica = new SortedSet<Attivita>();
            //setAtletica.Add(saltoInLungo);
            //setAtletica.Add(corsa);
            //setAtletica.Add(saltoInAlto);
            //setAtletica.Add(corsa);
            //Categoria atletica = new Categoria("Atletica", setAtletica);
            Categoria atletica = new Categoria("Atletica",
                new Attivita[] { saltoInLungo, corsa, saltoInAlto, corsa });

            //ISet<Attivita> setNuoto = new SortedSet<Attivita>();
            //setNuoto.Add(rana);
            //setNuoto.Add(dorso);
            //Categoria nuoto = new Categoria("Nuoto", setNuoto);
            Categoria nuoto = new Categoria("Nuoto", new Attivita[] { rana, dorso });
            nuoto.Attivita.Add(rana);

            //ISet<Categoria> sottoCategorie = new SortedSet<Categoria>();
            //sottoCategorie.Add(nuoto);
            //sottoCategorie.Add(atletica);
            //sottoCategorie.Add(nuoto);
            //Categoria generale = new Categoria("Generale", sottoCategorie);
            Categoria generale = new Categoria("Generale", 
                new Categoria[] { nuoto, atletica, nuoto});

            Console.WriteLine(generale.FullToString());
            Console.WriteLine("---------");
            Console.WriteLine(nuoto.FullToString());
            Console.WriteLine("---------");
            Console.WriteLine(atletica.FullToString());

            Console.ReadLine(); 
        }
    }
}
