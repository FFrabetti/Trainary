using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.Presentation;
using Trainary.view;

namespace Trainary.presenter
{
    public class VisualizzaAllenamentoProgrammatoPresenter
    {
        private AllenamentoForm _form;
        private AllenamentoProgrammato _allenamento;
        private VisualizzaSchedaSeduta _control = new VisualizzaSchedaSeduta();
        private TreeViewPresenter _presenter;
        public VisualizzaAllenamentoProgrammatoPresenter(AllenamentoForm form, AllenamentoProgrammato allenamento)
        {
            _form = form;
            _allenamento = allenamento;
            _presenter = new TreeViewPresenter(_form.TreeView);
            _form.Panel.Controls.Add(_control);
            _form.AllenamentoLabel.Text = "Allenamento Programmato";
            _control.Scheda.Enabled = false;
            _control.Seduta.Enabled = false;
            _form.Data.Enabled = false;
            _form.AggiungiEsercizioButton.Visible = false;
            _form.AggiungiCircuitoButton.Visible = false;
            _form.AggiungiDatiButton.Visible = false;
            _form.EliminaEsercizioButton.Visible = false;
            _form.AnnullaSelezioneButton.Visible = false;
            _form.Buttons.Visible = false;
            VisualizzaAllenamento();
        }

        private void VisualizzaAllenamento()
        {
            _control.Scheda.Text = _allenamento.Seduta.Scheda.ToString();
            _control.Seduta.Text = _allenamento.Seduta.ToString();
            _form.Data.Value = _allenamento.Data;
            _presenter.VisualizzaEserciziSvolti(_allenamento.EserciziSvolti);
           
        }
        
    }
}
