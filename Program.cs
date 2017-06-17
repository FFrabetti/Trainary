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

        [MenuLabel("Diario")]
        public static void MostraDiario()
        {
            Control control = new DiarioControl();
            AddControl(control);

            Console.WriteLine("mostra diario");
        }

        [MenuLabel("Schede", "Gestione Schede")]
        public static void MostraGestioneSchede()
        {
            GestioneSchedeControl control = new GestioneSchedeControl();
            GestioneSchedePresenter presenter = new GestioneSchedePresenter(control);
            AddControl(control);

            Console.WriteLine("gestione schede");
        }

        [MenuLabel("Schede", "Aggiungi Scheda")]
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

        [MenuLabel("Allenamenti", "Nuovo Allenamento Programmato")]
        public static void NuovoAllenamentoProgrammato()
        {
            AllenamentoForm form = new AllenamentoForm();
            InserisciAllenamentoProgrammatoPresenter presenter = new InserisciAllenamentoProgrammatoPresenter(form);
            form.Show();
        }

        [MenuLabel("Allenamenti", "Nuovo Allenamento Extra")]
        public static void NuovoAllenamentoExtra()
        {

            AllenamentoForm form = new AllenamentoForm();
            InserisciAllenamentoExtraPresenter presenter = new InserisciAllenamentoExtraPresenter(form);
            form.Show();
        }

        // Test only
        [MenuLabel("Test", "Nuovo eserczio")]
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

        [MenuLabel("Test", "Test2", "Nuovo Circuito")]
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
