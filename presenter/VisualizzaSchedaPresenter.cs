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
      
        public VisualizzaSchedaPresenter(SchedaForm form, Scheda scheda) : base(form)
        {
            if (scheda == null)
                throw new ArgumentNullException("scheda");
            Scheda = scheda;

            _vecchieSedute = new List<Seduta>(Scheda.Sedute);

            SchedaForm.Buttons.CancelButton.Visible = false;
            SchedaForm.AnnullaSelezioneButton.Visible = false;
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
           
            FireSeduteChanged();
        }

       
        
        
    }
}
