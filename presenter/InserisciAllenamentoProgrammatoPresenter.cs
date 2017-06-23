using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.view;

namespace Trainary.presenter
{
    class InserisciAllenamentoProgrammatoPresenter : InserisciAllenamentoPresenter
    {
        private SelezionaSedutaControl _selSedutaControl = new SelezionaSedutaControl();

        private void Debug(string txt)
        {
            Form.DebugTextBox.Text += txt + Environment.NewLine;
        }

        // Variabili che registrano lo stato associato agli esercizi svolti inseriti
        private Seduta _seduta;
        private DateTime _data;

        #region operazioni di alto livello

        private void PopolaSchedeCombo(List<Scheda> schede)
        {
            _selSedutaControl.ComboSchede.DataSource = null;
            _selSedutaControl.ComboSchede.DataSource = schede;
        }

        private void PopolaSeduteCombo(Seduta[] sedute)
        {
            _selSedutaControl.ComboSedute.Items.Clear();
            _selSedutaControl.ComboSedute.Items.AddRange(sedute);
            if(sedute.Length > 0)
                _selSedutaControl.ComboSedute.SelectedIndex = 0;

            //_selSedutaControl.ComboSedute.DataSource = null;
            //_selSedutaControl.ComboSedute.DataSource = sedute;

            Debug("SedutaCombo: " + sedute.Length);
            Debug("DataSource: " + _selSedutaControl.ComboSedute.Items.Count);
        }

        private Scheda SelectedScheda
        {
            get { return (Scheda)_selSedutaControl.ComboSchede.SelectedItem; }
            set { _selSedutaControl.ComboSchede.SelectedItem = value; }
        }

        private Seduta SelectedSeduta
        {
            get { return (Seduta)_selSedutaControl.ComboSedute.SelectedItem; }
            set { _selSedutaControl.ComboSedute.SelectedItem = value; }
        }

        private DateTime Data
        {
            get { return Form.Data.Value; }
            set { Form.Data.Value = value; }
        }

        #endregion

        public InserisciAllenamentoProgrammatoPresenter(AllenamentoForm form)
            : base(form)
        {
            Form.Panel.Controls.Add(_selSedutaControl);
            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioButton;
            Form.AggiungiCircuitoButton.Visible = false;
            Form.Buttons.OkButton.Click += OkButton_Click;

            Form.Data.ValueChanged += OnDataValueChanged;
            _selSedutaControl.ComboSchede.SelectedIndexChanged += OnSelectedSchedaCombo;
            _selSedutaControl.ComboSedute.SelectedIndexChanged += OnSelectedSedutaCombo;
            //_selSedutaControl.ComboSedute.DataSourceChanged += SelectedSeduteCombo;

            Form.AllenamentoLabel.Text = "Allenamento Programmato";

            OnDataValueChanged(null, EventArgs.Empty);
        }

        private void OnDataValueChanged(object sender, EventArgs e)
        {
            Debug("OnDataValueChanged");

            List<Scheda> schedeValide = new List<Scheda>(GestoreSchede.GetInstance().GetSchedeValide(Data));
            PopolaSchedeCombo(schedeValide);

            // nel caso di combo vuota non viene lanciato SelectedIndexChanged
            // quindi invoco l'handler manualmente
            if (schedeValide.Count == 0)
                OnSelectedSchedaCombo(null, EventArgs.Empty);
        }

        private void OnSelectedSchedaCombo(object sender, EventArgs e)
        {
            Debug("OnSelectedSchedaCombo");

            Seduta[] sedute = SelectedScheda != null ? SelectedScheda.Sedute : new Seduta[0];
            PopolaSeduteCombo(sedute);

            // nel caso di combo vuota non viene lanciato SelectedIndexChanged
            // quindi invoco l'handler manualmente
            if (sedute.Length == 0)
                OnSelectedSedutaCombo(null, EventArgs.Empty);
        }

        private void OnSelectedSedutaCombo(object sender, EventArgs e)
        {
            Debug("OnSelectedSedutaCombo");

            if (EserciziSvolti.Count > 0 && SelectedSeduta != _seduta)
            {
                string messageBoxText = "Ci sono degli esercizi svolti non salvati, se si prosegue saranno cancellati";
                string caption = "Conferma";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                if (MessageBox.Show(messageBoxText, caption, buttons, icon) == DialogResult.OK)
                {
                    EserciziSvolti.Clear(); // Eventuali altre chiamate vedranno Count == 0
                    ClearSnapshot();

                    AggiornaTreeView();
                }
                else // altrimenti cancello la modifica e non faccio nulla
                {
                    Debug(_data + " " + _seduta + " " + _seduta.Scheda);

                    Rollback();
                }
            }
        }

        private void Rollback()
        {
            // interrompo le dipendenze tra i 3 controlli
            Form.Data.ValueChanged -= OnDataValueChanged;
            _selSedutaControl.ComboSchede.SelectedIndexChanged -= OnSelectedSchedaCombo;
            _selSedutaControl.ComboSedute.SelectedIndexChanged -= OnSelectedSedutaCombo;

            Data = _data;
            // ripopolo la combo delle schede
            OnDataValueChanged(null, EventArgs.Empty);
            // seleziono la scheda precedente
            SelectedScheda = _seduta.Scheda;
            // ripopolo la combo delle sedute
            //OnSelectedSchedaCombo(null, EventArgs.Empty);
            PopolaSeduteCombo(_seduta.Scheda.Sedute);
            // seleziono la seduta precedente
            SelectedSeduta = _seduta;

            Form.Data.ValueChanged += OnDataValueChanged;
            _selSedutaControl.ComboSchede.SelectedIndexChanged += OnSelectedSchedaCombo;
            _selSedutaControl.ComboSedute.SelectedIndexChanged += OnSelectedSedutaCombo;
        }

        private void TakeSnapshot()
        {
            _data = Data;
            _seduta = SelectedSeduta;

            Debug("Snapshot: " + _data + " " + _seduta);
        }

        private void ClearSnapshot()
        {
            Debug("ClearSnapshot");

            _seduta = null;
            _data = default(DateTime);
        }

        private void OnAggiungiEsercizioButton(object sender, EventArgs e)
        {
            using (SelezionaEserciziSeduta form = new SelezionaEserciziSeduta())
            {
                SelezionaEserciziSedutaPresenter presenter;
                try
                {
                    presenter = new SelezionaEserciziSedutaPresenter(form, SelectedSeduta);
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
                    Esercizio esSelezionato = presenter.GetEsercizio();

                    // ???????
                    if(esSelezionato == null)
                    {
                        string messageBoxText = "Non è possibile svolgere solo alcuni esercizi di un circuito. Devi svolgere l'intero circuito per poterlo inserire in un allenamento!";
                        string caption = "Errore";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;

                        MessageBox.Show(messageBoxText, caption, buttons, icon);
                        return;
                    }

                    // Controllo sul fatto che ogni esercizio programmato venga svolto al massimo una volta
                    if (EserciziSvolti.Any(esSvolto => esSvolto.Esercizio.Equals(esSelezionato)))
                    {
                        string messageBoxText = "L'esercizio selezionato è già stato segnato come svolto in questo allenamento";
                        string caption = "Errore";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;

                        MessageBox.Show(messageBoxText, caption, buttons, icon);
                        return;
                    }

                    SvolgiVisitor sv = new SvolgiVisitor();
                    esSelezionato.Accept(sv);
                    EserciziSvolti.Add(sv.EsercizioSvolto);
                    TreeViewPresenter.VisualizzaEserciziSvolti(EserciziSvolti);

                    // Se ho inserito un esercizio salvo lo stato (data e seduta)
                    TakeSnapshot();
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            AllenamentoProgrammato allenamento;
            try
            {
                allenamento = new AllenamentoProgrammato(Data, EserciziSvolti.ToArray(), SelectedSeduta);
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
