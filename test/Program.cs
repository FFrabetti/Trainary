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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run(new FormDiario());

            // Application.Run(new EserciziListForm());

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

            DataManagerTest.Test();
            Console.ReadLine(); 
        }
        
        public static void Separator()
        {
            Console.WriteLine("----------------");
        }

    }
}
