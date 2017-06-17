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
    class VisualizzaAllenamentoExtraPresenter
    {
        private AllenamentoForm _form;
        private AllenamentoExtra _allenamento;
        private NomeUserControl _control = new NomeUserControl();
        public VisualizzaAllenamentoExtraPresenter(AllenamentoForm form,AllenamentoExtra allenamento)
        {
            _form = form;
            _allenamento = allenamento;
            _form.Panel.Controls.Add(_control);
            _form.AllenamentoLabel.Text = "Allenamento Extra";


            VisualizzaAllenamento();
        }

        private void VisualizzaAllenamento()
        {
            
            _control.Nome.Text = _allenamento.Nome;
            _control.Nome.Enabled = false;
            
            _form.DataEsercizi.Data.Value = _allenamento.Data;
            _form.DataEsercizi.Data.Enabled = false;
            _form.DataEsercizi.EserciziListBox.DataSource = _allenamento.EserciziSvolti;
           // _form.DataEsercizi.EserciziListBox.Enabled = false;
            _form.ButtonPiu.Visible = false;
            _form.Buttons.Visible = false;
        }
    }
}
