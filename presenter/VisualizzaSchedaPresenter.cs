using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;

namespace Trainary.presenter
{
    class VisualizzaSchedaPresenter : NuovaSchedaPresenter
    {
        List<Seduta> _vecchieSedute;
        //private Dictionary<Seduta, IList<Esercizio>> _dictionary = new Dictionary<Seduta, IList<Esercizio>>();

        public VisualizzaSchedaPresenter(SchedaForm form, Scheda scheda) : base(form)
        {
            if (scheda == null)
                throw new ArgumentNullException("scheda");
            Scheda = scheda;

            _vecchieSedute = new List<Seduta>(Scheda.Sedute);
            //foreach (Seduta s in Scheda.Sedute)
            //{
            //    _dictionary.Add(s, s.Esercizi);
            //}
            SchedaForm.Buttons.CancelButton.Click += OnAnnullaSelezioneButton;
            Inizializza();
        }
        

        private void Inizializza()
        {
            SchedaForm.Text = "Visualizza scheda";
            SchedaForm.Nome.Text = Scheda.Nome;

            SchedaForm.ScopoComboBox.SelectedItem = Scheda.Scopo;

            SchedaForm.Descrizione.Text = Scheda.Descrizione;

            SchedaForm.DataInizio.Value = Scheda.PeriodoDiValidita.DataInizio;

            SchedaForm.DataFine.Value = Scheda.PeriodoDiValidita.DataFine;

            SchedaForm.Durata.Text = Scheda.PeriodoDiValidita.Durata.Days.ToString();
           
            SedutePresenter.VisualizzaSedute(Scheda.Sedute);
        }

        protected override void OKButtonClick(object sender, EventArgs e)
        {
            Scheda.Nome = SchedaForm.Nome.Text;

            Scheda.Scopo = (ScopoDellaScheda)SchedaForm.ScopoComboBox.SelectedItem;

            Scheda.Descrizione = SchedaForm.Descrizione.Text;

            Scheda.PeriodoDiValidita = GetPeriodoDiValidita();
        }

        protected override void _nuovaSedutaButton_Click(object sender, EventArgs e)
        {
            Scheda.AggiungiSeduta(new List<Esercizio>());
            //_dictionary.Add(new Seduta(Scheda, new List<Esercizio>()),new List<Esercizio>());
            FireSeduteChanged();
        }

        public void CancellaNuoveSedute()
        {
            foreach (Seduta s in Scheda.Sedute)
                Scheda.RimuoviSeduta(s);
            foreach (Seduta s in _vecchieSedute)
                Scheda.AggiungiSeduta(s.Esercizi);
        }
        protected override void OnAnnullaSelezioneButton(object sender, EventArgs e)
        {
            CancellaNuoveSedute();
            //foreach(Seduta s in _dictionary.Keys)
            //{
            //    Scheda.AggiungiSeduta(_dictionary[s]);
            //}
            Inizializza();
        }
        
    }
}
