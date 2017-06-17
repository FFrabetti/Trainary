using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.model;
using Trainary.Presentation;
using Trainary.view;

namespace Trainary.presenter
{
    public class VisualizzaAllenamentoProgrammatoPresenter
    {
        private AllenamentoForm _form;
        private AllenamentoProgrammato _allenamento;
        private VisualizzaSchedaSeduta _control = new VisualizzaSchedaSeduta();
        public VisualizzaAllenamentoProgrammatoPresenter(AllenamentoForm form, AllenamentoProgrammato allenamento)
        {
            _form = form;
            _allenamento = allenamento;
            _form.Panel.Controls.Add(_control);
            _form.AllenamentoLabel.Text = "Allenamento Programmato";

            VisualizzaAllenamento();
        }

        private void VisualizzaAllenamento()
        {
            _control.Scheda.Text = _allenamento.Seduta.Scheda.ToString();
            _control.Seduta.Text = _allenamento.Seduta.ToString();
            _control.Scheda.Enabled = false;
            _control.Seduta.Enabled = false;
            _form.DataEsercizi.Data.Value = _allenamento.Data;
            _form.DataEsercizi.Data.Enabled = false;
            _form.DataEsercizi.EserciziListBox.DataSource = _allenamento.EserciziSvolti;
            _form.Buttons.Visible = false;
            _form.ButtonPiu.Visible = false;
        }
    }
}
