using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.persistence;
using Trainary.Presentation;
using Trainary.presenter;
using Trainary.utils;
using Trainary.view;

namespace Trainary
{
    class Program
    {
        private static MainForm _mainForm;

        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _mainForm = new MainForm();
            MenuPresenter menuPresenter = new MenuPresenter(typeof(Program), _mainForm.MenuStrip);

            // Schermata iniziale
            MostraDiario();

            Application.Run(_mainForm);
        }


        private static void AddControl(Control control)
        {
            _mainForm.Panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _mainForm.Panel.Controls.Add(control);
        }


        // ------------------------------ MENU ------------------------------

        [MenuLabel("Trainary", "Exit")]
        public static void Exit()
        {
            Application.Exit();
        }

        [MenuLabel("Visualizza Diario")]
        public static void MostraDiario()
        {
            Control control = new DiarioControl();
            AddControl(control);
        }

        [MenuLabel("Gestione Schede")]
        public static void MostraGestioneSchede()
        {
            GestioneSchedeControl control = new GestioneSchedeControl();
            GestioneSchedePresenter presenter = new GestioneSchedePresenter(control);
            AddControl(control);
        }

        [MenuLabel("Allenamenti", "Inserisci Allenamento Programmato")]
        public static void NuovoAllenamentoProgrammato()
        {
            using (AllenamentoForm form = new AllenamentoForm())
            {
                InserisciAllenamentoProgrammatoPresenter presenter = new InserisciAllenamentoProgrammatoPresenter(form);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("ok");
                }
                else
                    Console.WriteLine("cancel");
            }
        }

        [MenuLabel("Allenamenti", "Inserisci Allenamento Extra")]
        public static void NuovoAllenamentoExtra()
        {
            using (AllenamentoForm form = new AllenamentoForm())
            {
                InserisciAllenamentoExtraPresenter presenter = new InserisciAllenamentoExtraPresenter(form);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("ok");
                }
                else
                    Console.WriteLine("cancel");
            }
        }
        
    }
}
