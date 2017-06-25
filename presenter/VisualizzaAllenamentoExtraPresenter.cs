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
    class VisualizzaAllenamentoExtraPresenter
    {
        private AllenamentoForm _form;
        private AllenamentoExtra _allenamento;
        private NomeUserControl _control = new NomeUserControl();
        private TreeViewPresenter _presenter;
        public VisualizzaAllenamentoExtraPresenter(AllenamentoForm form, AllenamentoExtra allenamento)
        {
            _form = form;
            _allenamento = allenamento;
            _presenter = new TreeViewPresenter(_form.TreeView);
            _form.Panel.Controls.Add(_control);
            _form.AllenamentoLabel.Text = "Allenamento Extra";
            _form.AggiungiDatiButton.Visible = false;
            _form.EliminaEsercizioButton.Visible = false;
            _form.AnnullaSelezioneButton.Visible = false;
            _form.Data.Enabled = false;
            _form.AggiungiEsercizioButton.Visible = false;
            _form.AggiungiCircuitoButton.Visible = false;
            _form.Buttons.OkButton.Click += OnOkButtonClick;
            Application.Idle += OnIdle;
            VisualizzaAllenamento();
        }

        private void OnIdle(object sender, EventArgs e)
        {
            _form.Buttons.OkButton.Enabled = _control.Nome.Text.Trim() != String.Empty;
        }

        private void OnOkButtonClick(object sender, EventArgs e)
        {
            _allenamento.Nome = _control.Nome.Text;
        }

        private void VisualizzaAllenamento()
        {

            _control.Nome.Text = _allenamento.Nome;

            _form.Data.Value = _allenamento.Data;

            _presenter.VisualizzaEserciziSvolti(_allenamento.EserciziSvolti);

        }


    }
}

