using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.presenter.attributi;
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

            Application.Idle += OnApplicationIdle;
            _allenamentoForm.TreeView.AfterSelect += OnSelectedNode;

            _allenamentoForm.AggiungiDatiButton.Click += OnAggiungiDatiButton;
            _allenamentoForm.AnnullaSelezioneButton.Click += OnAnnullaSelezioneButtonClick;
            _allenamentoForm.EliminaEsercizioButton.Click += OnEliminaEsercizioButton;
        }

        
        private void OnEliminaEsercizioButton(object sender, EventArgs e)
        {
            if (_allenamentoForm.TreeView.SelectedNode.Tag != null && _allenamentoForm.TreeView.SelectedNode.Tag is EsercizioSvolto)
            {
                EsercizioSvolto eSvolto = (EsercizioSvolto)_allenamentoForm.TreeView.SelectedNode.Tag;
                
                _eserciziSvolti.Remove(eSvolto);
                AggiornaTreeView();
            }
        }

        protected virtual void OnAnnullaSelezioneButtonClick(object sender, EventArgs e)
        {
            _eserciziSvolti.Clear();
            _allenamentoForm.Data.Value = DateTime.Today.Date;
            AggiornaTreeView();
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

        protected virtual void OnApplicationIdle(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void OnSelectedNode(object sender, TreeViewEventArgs e)
        {
            EnableButtons();
        }

        private void EnableButtons()
        {
            _allenamentoForm.AggiungiDatiButton.Enabled = _allenamentoForm.TreeView.SelectedNode != null &&
                           _allenamentoForm.TreeView.SelectedNode.Tag is EsercizioSvolto;
            _allenamentoForm.EliminaEsercizioButton.Enabled = _allenamentoForm.TreeView.SelectedNode != null &&
                            _allenamentoForm.TreeView.SelectedNode.Tag is EsercizioSvolto && !(_allenamentoForm.TreeView.SelectedNode.Parent.Tag is CircuitoSvolto);
        }

        protected void AggiornaTreeView()
        {
            _treeViewPresenter.VisualizzaEserciziSvolti(_eserciziSvolti);
        }

        private void OnAggiungiDatiButton(object sender, EventArgs e)
        {
            // Recupero l'esercizio svolto selezionato
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

    }
}
