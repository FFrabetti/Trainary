using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.presenter.attributi;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter
{
    public class InserisciAllenamentoPresenter
    {
        private AllenamentoForm _allenamentoForm;
        private TreeViewPresenter _treeViewPresenter;
        private List<EsercizioSvolto> _eserciziSvolti;

        public InserisciAllenamentoPresenter(AllenamentoForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _allenamentoForm = form;

            _treeViewPresenter = new TreeViewPresenter(_allenamentoForm.TreeView);
            _eserciziSvolti = new List<EsercizioSvolto>();

            _allenamentoForm.TreeView.AfterSelect += OnNodeSelected;
            _allenamentoForm.AggiungiDatiButton.Click += OnAggiungiDatiClick;
            _allenamentoForm.EliminaEsercizioButton.Click += OnEliminaEsercizioClick;
            _allenamentoForm.AnnullaSelezioneButton.Click += OnAnnullaSelezioneClick;
            _allenamentoForm.Data.ValueChanged += ControllaDataFutura;

            Application.Idle += OnApplicationIdle;
        }

        protected AllenamentoForm Form
        {
            get { return _allenamentoForm; }
        }

        protected TreeViewPresenter TreeViewPresenter
        {
            get { return _treeViewPresenter; }
        }

        protected List<EsercizioSvolto> EserciziSvolti
        {
            get { return _eserciziSvolti; }
        }

        private void OnApplicationIdle(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void ControllaDataFutura(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;
            if (dateTimePicker.Value.Date > DateTime.Today)
            {
                MessageBoxUtils.DisplayError("Data futura");
                dateTimePicker.Value = DateTime.Today;
            }
        }

        private void OnEliminaEsercizioClick(object sender, EventArgs e)
        {
            if (_allenamentoForm.TreeView.SelectedNode == null)
                return;

            EsercizioSvolto eSvolto = _allenamentoForm.TreeView.SelectedNode.Tag as EsercizioSvolto;
            if (eSvolto != null)
            {
                _eserciziSvolti.Remove(eSvolto);
                AggiornaTreeView();
            }
        }

        private void OnNodeSelected(object sender, TreeViewEventArgs e)
        {
            EnableButtons();
        }

        private void EnableButtons()
        {
            _allenamentoForm.AggiungiCircuitoButton.Enabled = EserciziSvolti.Count >= 2;

            _allenamentoForm.AggiungiDatiButton.Enabled = _allenamentoForm.TreeView.SelectedNode != null &&
                           _allenamentoForm.TreeView.SelectedNode.Tag is EsercizioSvolto;

            _allenamentoForm.EliminaEsercizioButton.Enabled = _allenamentoForm.AggiungiDatiButton.Enabled &&
                            !(_allenamentoForm.TreeView.SelectedNode.Parent.Tag is CircuitoSvolto);

            _allenamentoForm.Buttons.OkButton.Enabled = EserciziSvolti.Count > 0;

            _allenamentoForm.AnnullaSelezioneButton.Enabled = EserciziSvolti.Count > 0;
        }

        protected void AggiornaTreeView()
        {
            _treeViewPresenter.VisualizzaEserciziSvolti(_eserciziSvolti);
        }

        private void OnAggiungiDatiClick(object sender, EventArgs e)
        {
            // Recupero l'esercizio svolto selezionato
            if (_allenamentoForm.TreeView.SelectedNode == null)
                return;
            EsercizioSvolto esercizioSvolto = _allenamentoForm.TreeView.SelectedNode.Tag as EsercizioSvolto;
            if (esercizioSvolto == null)
                return;

            using (DatiForm datiForm = new DatiForm())
            {
                AttributiPresenter presenter = new AttributiPresenter(datiForm.AttributiControl, esercizioSvolto.Dati);
                datiForm.ListLabel.Text = "Dati";

                if (datiForm.ShowDialog() == DialogResult.OK)
                {
                    esercizioSvolto.Dati.Clear();
                    esercizioSvolto.Dati.AddRange(presenter.Attributi);

                    AggiornaTreeView();
                }
            }
        }

        protected virtual void OnAnnullaSelezioneClick(object sender, EventArgs e)
        {
            if (EserciziSvolti.Count > 0)
            {
                string messageBoxText = "Ci sono degli esercizi svolti non salvati, se si prosegue saranno cancellati";

                if (MessageBoxUtils.AskForConfirmation(messageBoxText) == DialogResult.OK)
                {
                    EserciziSvolti.Clear();
                    AggiornaTreeView();
                }
            }
        }
    }
}
