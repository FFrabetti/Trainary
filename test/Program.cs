using System;
using System.Windows.Forms;
using Trainary.test.model;
using Trainary.test.view;

namespace Trainary
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            DiarioTest.Test();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDiario());
            

            //AttributoTempoTest.Test();
            //Separator();
            //CategoriaAttivitaTest.Test();
            //Separator();
            //FormatTest.Test();
            //Separator();
            //PeriodoTest.Test();
            //Separator();
            //QuantitaFactoryTest.Test();
            //Separator();

            //Console.ReadLine(); 
        }
        
        public static void Separator()
        {
            Console.WriteLine("----------------");
        }

    }
}
