using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.model;
using Trainary.model.attributi;

namespace Trainary.test.model
{
    class DataManagerTest
    {

        public static void Test()
        {
            Documento documento = Documento.GetInstance();

            // categorie, stampa ricorsiva
            PrintCategorie(documento.GetCategoriaRadice());

            Separator();

            // attibuti
            foreach (Attributo a in documento.GetAttributi())
                Console.WriteLine(a);

            Separator();

            // esercizi
            foreach (Esercizio e in documento.GetEsercizi())
                Console.WriteLine(e.ToFullString());

            Separator();

            // schede
            foreach (Scheda s in documento.GetSchede())
                Console.WriteLine(s.ToString());

            Separator();

            // sedute
            foreach (Seduta se in documento.GetSedute())
                Console.WriteLine(se);
        }

        private static void Separator()
        {
            Console.WriteLine("\n----------\n");
        }

        private static void PrintCategorie(Categoria categoria)
        {
            Console.WriteLine(categoria + ":");

            foreach (Attivita a in categoria.Attivita)
                Console.WriteLine("- " + a);

            foreach (Categoria c in categoria.SottoCategorie)
                PrintCategorie(c);
        }
    }
}
