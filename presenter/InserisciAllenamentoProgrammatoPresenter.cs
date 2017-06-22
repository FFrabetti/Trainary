using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.view;

namespace Trainary.presenter
{
    class InserisciAllenamentoProgrammatoPresenter : InserisciAllenamentoPresenter
    {

        private SelezionaSedutaControl _control = new SelezionaSedutaControl();

        private Seduta _seduta = null;
        private DateTime _data;

        public InserisciAllenamentoProgrammatoPresenter(AllenamentoForm form)
            : base(form)
        {
            Form.Panel.Controls.Add(_control);
            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioButton;
            Form.AggiungiCircuitoButton.Visible = false;
            Form.Buttons.OkButton.Click += OkButton_Click;

            Form.Data.ValueChanged += OnDataValueChanged;
            _control.ComboSchede.SelectedIndexChanged += SelectedSchedaCombo;
            _control.ComboSedute.SelectedIndexChanged += SelectedSeduteCombo;
            _control.ComboSedute.DataSourceChanged += SelectedSeduteCombo;

            Form.AllenamentoLabel.Text = "Allenamento Programmato";

            OnDataValueChanged(this, EventArgs.Empty);
        }

        private void SelectedSeduteCombo(object sender, EventArgs e)
        {
            Seduta sedutaSelezionata = (Seduta)((ComboBox)sender).SelectedItem;

            if (sedutaSelezionata != _seduta && EserciziSvolti.Count > 0)
            {
                string messageBoxText = "Ci sono degli esercizi svolti non salvati, se si prosegue saranno cancellati";
                string caption = "Conferma cancellazione";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                if (MessageBox.Show(messageBoxText, caption, buttons, icon) == DialogResult.OK)
                {
                    EserciziSvolti.Clear();
                    AggiornaTreeView();
                }
                else // altrimenti cancello l'evento e non faccio nulla
                {
                    // ripristino della data
                    Form.Data.Value = _data;
                    _control.ComboSchede.SelectedItem = _seduta.Scheda;
                    ((ComboBox)sender).SelectedItem = _seduta;
                    return;
                }
            }

            _seduta = sedutaSelezionata;
        }

        private void OnDataValueChanged(object sender, EventArgs e)
        {
            _control.ComboSchede.DataSource = new List<Scheda>(GestoreSchede.GetInstance().GetSchedeValide(Form.Data.Value));

            SelectedSchedaCombo(this, EventArgs.Empty);
        }

        private void SelectedSchedaCombo(object sender, EventArgs e)
        {
            if (_control.ComboSchede.SelectedItem != null)
            {
                Scheda scheda = (Scheda)_control.ComboSchede.SelectedItem;
                _control.ComboSedute.DataSource = scheda.Sedute;
            }
            else
            {
                _control.ComboSedute.DataSource = new List<Seduta>();
            }
        }

        private void OnAggiungiEsercizioButton(object sender, EventArgs e)
        {
            _data = Form.Data.Value;

            if (EserciziSvolti.Count > 0 && (Seduta)_control.ComboSedute.SelectedItem != _seduta)
            {
                string messageBoxText = "Non è possibile svolgere esercizi di sedute e/o schede diverse nello stesso allenamento programmato";
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(messageBoxText, caption, buttons, icon);
                return;
            }

            _seduta = (Seduta)_control.ComboSedute.SelectedItem;
            using (SelezionaEserciziSeduta form = new SelezionaEserciziSeduta())
            {
                SelezionaEserciziSedutaPresenter presenter;
                try
                {
                    presenter = new SelezionaEserciziSedutaPresenter(form, _seduta);
                }
                catch(Exception ex)
                {
                    string messageBoxText = ex.Message;
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
                    return;
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                    Esercizio es = presenter.GetEsercizio();
                    if(es == null)
                    {
                        string messageBoxText = "Non è possibile svolgere solo alcuni esercizi di un circuito. Devi svolgere l'intero circuito per poterlo inserire in un allenamento!";
                        string caption = "Errore";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;

                        MessageBox.Show(messageBoxText, caption, buttons, icon);
                        return;
                    }
                    foreach(EsercizioSvolto ev in EserciziSvolti)
                    {
                        if (ev.Esercizio.Equals(es))
                        {
                            string messageBoxText = "Non è possibile aggiungere un esercizio più volte nello stesso allenamento";
                            string caption = "Errore";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Warning;

                            MessageBox.Show(messageBoxText, caption, buttons, icon);
                            return;
                        }
                    }
                    SvolgiVisitor sv = new SvolgiVisitor();
                    es.Accept(sv);
                    EsercizioSvolto eSvolto = sv.EsercizioSvolto;
                    EserciziSvolti.Add(eSvolto);
                    TreeViewPresenter.VisualizzaEserciziSvolti(EserciziSvolti.ToArray());
                   
                }
               
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime data = Form.Data.Value;
            AllenamentoProgrammato allenamento;
            try
            {
                allenamento = new AllenamentoProgrammato(data, EserciziSvolti.ToArray(), _seduta);
            }
            catch (Exception ex)
            {
                string messageBoxText = ex.Message;
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(messageBoxText, caption, buttons, icon);
                return;
            }
            Diario.GetInstance().Allenamenti.Add(allenamento);
            Form.Close();
        }
        protected override void OnCancelButtonClick(object sender, EventArgs e)
        {
            base.OnCancelButtonClick(sender, e);
            OnDataValueChanged(null, EventArgs.Empty);
        }
        protected override void OnApplicationIdle(object sender, EventArgs e)
        {
            base.OnApplicationIdle(sender, e);
            Form.Buttons.CancelButton.Enabled = Form.Data.Value.Date != DateTime.Today.Date || EserciziSvolti.Count > 0;

        }
    }
}
