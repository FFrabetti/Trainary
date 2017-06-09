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
            Application.Run(_mainForm);
        }

        private static void AddControl(Control control)
        {
            _mainForm.Panel.Controls.Clear();
            _mainForm.Panel.Controls.Add(control);
        }


        // ------------------------------ MENU ------------------------------

        [MenuLabel("Exit", "Trainary")]
        public static void Exit()
        {
            Application.Exit();
        }

        [MenuLabel("Diario")]
        public static void MostraDiario()
        {
            Control control = new DiarioControl();
            AddControl(control);

            Console.WriteLine("mostra diario");
        }

        [MenuLabel("Gestione Schede", "Schede")]
        public static void MostraGestioneSchede()
        {
            Control control = new GestioneSchedeControl();
            AddControl(control);

            Console.WriteLine("gestione schede");
        }

        [MenuLabel("Aggiungi Scheda", "Schede")]
        public static void AggiungiScheda()
        {
            using (SchedaForm schedaForm = new SchedaForm())
            {
                if (schedaForm.ShowDialog() == DialogResult.OK)
                    Console.WriteLine("ok!");
                else
                    Console.WriteLine("cancel");
            }

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

        // Test only
        [MenuLabel("Nuovo eserczio", "Test")]
        public static void NuovoEsercizio()
        {
            using (NewEsercizioForm newEsForm = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(newEsForm);

                if (newEsForm.ShowDialog() == DialogResult.OK)
                {
                    Esercizio esercizio = presenter.NewEsercizio();
                    Console.WriteLine(esercizio);
                }
                else
                    Console.WriteLine("cancel");
            }
        }

        [MenuLabel("Nuovo circuito", "Test")]
        public static void NuovoCircuito()
        {
            IDataManager<Esercizio> eserciziDM = new EserciziDataManager(new CategorieDataManager(), new AttributiDataManager());

            using (NewCircuitoForm newCircuitoForm = new NewCircuitoForm())
            {
                NewCircuitoPresenter presenter = new NewCircuitoPresenter(newCircuitoForm, new List<Esercizio>(eserciziDM.GetElements()));

                if (newCircuitoForm.ShowDialog() == DialogResult.OK)
                {
                    Circuito circuito = presenter.NewCircuito();
                    Console.WriteLine(circuito.ToFullString());
                }
                else
                    Console.WriteLine("cancel");
            }
        }

    }
}
