using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.utils;

namespace Trainary
{
    class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            MenuPresenter menuPresenter = new MenuPresenter(typeof(Program), mainForm.MenuStrip);
            Application.Run(mainForm);
        }

        [MenuLabel("Exit", "Trainary")]
        public static void Exit()
        {
            Application.Exit();
        }

        [MenuLabel("Diario")]
        public static void MostraDiario()
        {
            Console.WriteLine("mostra diario");
        }

        [MenuLabel("Gestione Schede", "Schede")]
        public static void MostraGestioneSchede()
        {
            Console.WriteLine("gestione schede");
        }

        [MenuLabel("Aggiungi Scheda", "Schede")]
        public static void AggiungiScheda()
        {
            Console.WriteLine("aggiungi scheda");
        }

        [MenuLabel("Nuovo Allenamento Programmato", "Allenamenti")]
        public static void NuovoAllenamentoProgrammato()
        {
            Console.WriteLine("nuovo all programmato");
        }

        [MenuLabel("Nuovo Allenamento Extra", "Allenamenti")]
        public static void NuovoAllenamentoExtra()
        {
            Console.WriteLine("nuovo all extra");
        }
    }
}
