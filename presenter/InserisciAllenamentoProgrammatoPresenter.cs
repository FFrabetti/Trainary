using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter
{
    class InserisciAllenamentoProgrammatoPresenter : InserisciAllenamentoPresenter
    {
        private SelezionaSedutaControl _selSedutaControl = new SelezionaSedutaControl();

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
            if (sedute.Length > 0)
                _selSedutaControl.ComboSedute.SelectedIndex = 0;
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
            Form.AllenamentoLabel.Text = "Allenamento Programmato";
            Form.Panel.Controls.Add(_selSedutaControl);
            Form.AggiungiCircuitoButton.Visible = false;

            Application.Idle += OnApplicationIdle;

            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioClick;
            Form.Buttons.OkButton.Click += OkButtonClick;
            Form.AnnullaSelezioneButton.Click += OnAnnullaSelezioneClick;

            Form.Data.ValueChanged += OnDataValueChanged;
            _selSedutaControl.ComboSchede.SelectedIndexChanged += OnSelectedSchedaChanged;

            OnDataValueChanged(null, EventArgs.Empty);
        }

        private void OnDataValueChanged(object sender, EventArgs e)
        {
            List<Scheda> schedeValide = new List<Scheda>(GestoreSchede.GetInstance().GetSchedeValide(Data));
            PopolaSchedeCombo(schedeValide);

            // nel caso di combo vuota non viene lanciato SelectedIndexChanged
            // quindi invoco l'handler manualmente
            if (schedeValide.Count == 0)
                OnSelectedSchedaChanged(null, EventArgs.Empty);
        }

        private void OnSelectedSchedaChanged(object sender, EventArgs e)
        {
            Seduta[] sedute = SelectedScheda != null ? SelectedScheda.Sedute : new Seduta[0];
            PopolaSeduteCombo(sedute);

            // nel caso di combo vuota non viene lanciato SelectedIndexChanged
            // quindi invoco l'handler manualmente
            //if (sedute.Length == 0)
            //    OnSelectedSedutaCombo(null, EventArgs.Empty);
        }

        private void TakeSnapshot()
        {
            SetFreezingState(true);
        }

        private void ClearSnapshot()
        {
            SetFreezingState(false);
        }

        private void SetFreezingState(bool state)
        {
            Form.Data.Enabled = state;
            _selSedutaControl.ComboSchede.Enabled = state;
            _selSedutaControl.ComboSedute.Enabled = state;
        }

        private void OnAggiungiEsercizioClick(object sender, EventArgs e)
        {
            try
            {
                using (SelezionaEserciziSeduta form = new SelezionaEserciziSeduta())
                {
                    SelezionaEserciziSedutaPresenter presenter = new SelezionaEserciziSedutaPresenter(form, SelectedSeduta);

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Esercizio esSelezionato = presenter.GetEsercizio();

                        // Controllo sul fatto che ogni esercizio programmato venga svolto al massimo una volta
                        if (EserciziSvolti.Any(esSvolto => esSvolto.Esercizio.Equals(esSelezionato)))
                            throw new ArgumentException("L'esercizio selezionato è già stato segnato come svolto in questo allenamento");

                        SvolgiVisitor sv = new SvolgiVisitor();
                        esSelezionato.Accept(sv);
                        EserciziSvolti.Add(sv.EsercizioSvolto);
                        TreeViewPresenter.VisualizzaEserciziSvolti(EserciziSvolti);

                        // Se ho inserito un esercizio salvo lo stato
                        TakeSnapshot();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxUtils.DisplayError(ex.Message);
            }
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            try
            {
                Allenamento allenamento = new AllenamentoProgrammato(Data, EserciziSvolti.ToArray(), SelectedSeduta);
                Diario.GetInstance().Allenamenti.Add(allenamento);

                Form.Close();
            }
            catch (Exception ex)
            {
                MessageBoxUtils.DisplayError(ex.Message);
            }
        }

        private void OnAnnullaSelezioneClick(object sender, EventArgs e)
        {
            if (EserciziSvolti.Count > 0)
            {
                string messageBoxText = "Ci sono degli esercizi svolti non salvati, se si prosegue saranno cancellati";

                if (MessageBoxUtils.AskForConfirmation(messageBoxText) == DialogResult.OK)
                {
                    EserciziSvolti.Clear();
                    ClearSnapshot();
                    AggiornaTreeView();
                }
            }
        }

        private void OnApplicationIdle(object sender, EventArgs e)
        {
            Form.AnnullaSelezioneButton.Enabled = EserciziSvolti.Count > 0;
            Form.AggiungiEsercizioButton.Enabled = SelectedSeduta != null;
        }
    }
}
