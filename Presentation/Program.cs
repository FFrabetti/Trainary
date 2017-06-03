using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.Presentation;

namespace Trainary
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormDiario());
            //Application.Run(new AllenamentoExtraView());
            //Application.Run(new AllenamentoProgrammatoView());
            //Application.Run(new FormSchede());
            //Application.Run(new SchedaSelezionataView());
            Application.Run(new NuovaSchedaView());

        }
    }
}
