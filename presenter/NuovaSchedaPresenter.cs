using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter
{
    class NuovaSchedaPresenter
    {
        private SchedaForm _schedaForm;
        private TreeViewPresenter _presenter;
        private IList<Seduta> _sedute = new List<Seduta>();
        private Scheda _scheda = null;
        public event EventHandler SeduteChanged;

        public NuovaSchedaPresenter(SchedaForm schedaForm)
        {
            if (schedaForm == null)
                throw new ArgumentNullException("scheda form");
            _schedaForm = schedaForm;
            _presenter = new TreeViewPresenter(_schedaForm.TreeView);
            InizializeScopoCombo();
            AssegnaGestori();

        }

        protected Scheda Scheda
        {
            get { return _scheda; }
            set { _scheda = value; }
        }

        protected TreeViewPresenter SedutePresenter
        {
            get { return _presenter; }
        }

        protected SchedaForm SchedaForm { get { return _schedaForm; } }

        private void AssegnaGestori()
        {
            Application.Idle += OnIdle;
            _schedaForm.Buttons.OkButton.Click += OKButtonClick;
            _schedaForm.NuovaSedutaButton.Click += _nuovaSedutaButton_Click;
            _schedaForm.TreeView.AfterSelect += OnSelectedNode;
            SeduteChanged += OnSeduteChanged;
            _schedaForm.NuovoEsercizioButton.Click += OnNuovoEsercizioButton;
            _schedaForm.EliminaEsercizioButton.Click += OnEliminaEsercizioButton;
            _schedaForm.RimuoviSedutaButton.Click += OnRimuoviSedutaButton;
            _schedaForm.RinominaSedutaButton.Click += OnRinominaSedutaButton;
            _schedaForm.NuovoCircuitoButton.Click += OnNuovoCircuitoButton;
            _schedaForm.AnnullaSelezioneButton.Click += OnAnnullaSelezioneButton;
            _schedaForm.FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (_schedaForm.DialogResult == DialogResult.OK && _scheda == null)
            {
                e.Cancel = true;
            }
        }

        protected virtual void OnAnnullaSelezioneButton(object sender, EventArgs e)
        {
            _schedaForm.Nome.Text = String.Empty;
            InizializeScopoCombo();
            _schedaForm.Descrizione.Text = String.Empty;
            _schedaForm.DataInizio.Value = DateTime.Today.Date;
            _schedaForm.DataFine.Value = DateTime.Today.Date;
            _schedaForm.Durata.Text = String.Empty;
            _schedaForm.DataFineRadioButton.Select();
            if (_scheda != null)
            {
                foreach (Seduta s in _scheda.Sedute)
                {
                    _scheda.RimuoviSeduta(s);
                }
                SeduteChanged(this, EventArgs.Empty);
                _scheda = null;
            }
        }

        private void OnNuovoCircuitoButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            if (node != null && node.Tag is Seduta)
            {
                Seduta seduta = (Seduta)node.Tag;
                IList<Esercizio> esercizi = seduta.Esercizi;
                using (NewCircuitoForm form = new NewCircuitoForm())
                {
                    NewCircuitoPresenter presenter = new NewCircuitoPresenter(form, esercizi);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Circuito circuito = presenter.NewCircuito();
                        foreach (Esercizio es in circuito.Esercizi)
                        {
                            seduta.Esercizi.Remove(es);
                        }
                        seduta.Esercizi.Add(circuito);
                    }
                }
                SeduteChanged(this, EventArgs.Empty);
            }
        }

        private void OnRinominaSedutaButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            if (node != null && node.Tag is Seduta)
            {
                Seduta daRinominare = (Seduta)node.Tag;
                using (RinominaSedutaView view = new RinominaSedutaView())
                {
                    RinominaSedutaPresenter presenter = new RinominaSedutaPresenter(view);
                    if (view.ShowDialog() == DialogResult.OK)
                    {
                        string nuovoNome = presenter.NuovoNome();
                        try
                        {
                            daRinominare.Nome = nuovoNome;
                        }
                        catch (Exception exception)
                        {
                            MessageBoxUtils.DisplayError(exception.Message);
                            return;
                        }
                    }
                }
                SeduteChanged(this, EventArgs.Empty);
            }
        }

        private void OnRimuoviSedutaButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            if (node != null && node.Tag is Seduta)
            {
                Seduta sedutaDaEliminare = (Seduta)node.Tag;
                _scheda.RimuoviSeduta(sedutaDaEliminare);
                SeduteChanged(this, EventArgs.Empty);
            }
        }

        private void OnEliminaEsercizioButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            if (node != null && node.Tag is Esercizio)
            {
                Esercizio esercizioDaEliminare = (Esercizio)node.Tag;

                TreeNode superNode = node.Parent;
                if (superNode != null && superNode.Tag is Circuito && (superNode.Tag as Circuito).Esercizi.Length == 2)
                {
                    MessageBoxUtils.DisplayError("Un circuito non può contenere meno di 2 esercizi");
                    return;
                }
                while (!(superNode.Tag is Seduta))
                {
                    superNode = superNode.Parent;
                }
                Seduta seduta = (Seduta)superNode.Tag;

                EliminaEsercizio(seduta.Esercizi, esercizioDaEliminare);

                SeduteChanged(this, EventArgs.Empty);
            }
        }

        private void EliminaEsercizio(IList<Esercizio> esercizi, Esercizio esercizioDaEliminare)
        {
            if (esercizi.Contains(esercizioDaEliminare))
                esercizi.Remove(esercizioDaEliminare);
            else
            {
                foreach (Esercizio es in esercizi)
                {
                    if (es is Circuito)
                    {
                        Circuito circuito = (Circuito)es;
                        EliminaEsercizio(circuito.Esercizi, esercizioDaEliminare);
                    }
                }
            }
        }

        private void OnIdle(object sender, EventArgs e)
        {
            _schedaForm.AnnullaSelezioneButton.Enabled = EnableAnnullaSelezione();
            _schedaForm.NuovaSedutaButton.Enabled = _schedaForm.Nome.Text.Trim() != String.Empty;
            _schedaForm.Buttons.OkButton.Enabled = _schedaForm.Nome.Text.Trim() != String.Empty;

            if (_schedaForm.TreeView.SelectedNode == null) //|| _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta))
            {
                _schedaForm.EliminaEsercizioButton.Enabled = false;

            }
            if (_schedaForm.TreeView.SelectedNode == null)// || _schedaForm.TreeView.SelectedNode.Tag.GetType().IsSubclassOf(typeof(Esercizio)))
            {
                _schedaForm.RinominaSedutaButton.Enabled = false;
                _schedaForm.RimuoviSedutaButton.Enabled = false;
                _schedaForm.NuovoEsercizioButton.Enabled = false;
                _schedaForm.NuovoCircuitoButton.Enabled = false;
            }
        }

        private bool EnableAnnullaSelezione()
        {
            if (_schedaForm.Nome.Text.Trim() != String.Empty)
                return true;
            if (_schedaForm.Descrizione.Text.Trim() != String.Empty)
                return true;
            if ((ScopoDellaScheda)_schedaForm.ScopoComboBox.SelectedItem != ScopoDellaScheda.Nessuno)
                return true;
            if (_schedaForm.DataInizio.Value.Date != DateTime.Today.Date)
                return true;
            if (_schedaForm.DataFine.Value.Date != DateTime.Today.Date)
                return true;
            if (_schedaForm.Durata.Text.Trim() != String.Empty)
                return true;

            return false;
        }

        private void OnNuovoEsercizioButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            Seduta selected = (Seduta)node.Tag;
            using (NewEsercizioForm form = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(form);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Esercizio esercizio = presenter.NewEsercizio();
                    //if (selected.Esercizi.Contains(esercizio))
                    //{
                    //    string messageBoxText = "Non è possibile inserire più volte lo stesso esercizio all'interno della stessa seduta";
                    //    string caption = "Errore";
                    //    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    //    MessageBox.Show(messageBoxText, caption, buttons, icon);
                    //    return;
                    //}
                    selected.Esercizi.Add(esercizio);
                    SeduteChanged(this, EventArgs.Empty);
                }
            }
        }

        private void OnSelectedNode(object sender, EventArgs e)
        {
            _schedaForm.NuovoEsercizioButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta);
            _schedaForm.NuovoCircuitoButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta) && isValida(_schedaForm.TreeView.SelectedNode.Tag);
            _schedaForm.EliminaEsercizioButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag != null && _schedaForm.TreeView.SelectedNode.Tag.GetType().IsSubclassOf(typeof(Esercizio)) && !(_schedaForm.TreeView.SelectedNode.Parent.Tag is Circuito);  //_schedaForm.NuovoEsercizioButton.Enabled = _schedaForm.TreeView.SelectedNode.Parent==null;
            _schedaForm.RinominaSedutaButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta);
            _schedaForm.RimuoviSedutaButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta);
        }

        private bool isValida(object tag)
        {
            if (tag.GetType() == typeof(Seduta))
            {
                Seduta seduta = (Seduta)tag;
                if (seduta.Esercizi.Count >= 2)
                    return true;
            }
            return false;
        }

        protected void OnSeduteChanged(object sender, EventArgs e)
        {
            _presenter.VisualizzaSedute(_scheda.Sedute);
        }

        private void InizializeScopoCombo()
        {
            _schedaForm.ScopoComboBox.DataSource = Enum.GetValues(typeof(ScopoDellaScheda));

        }

        protected Periodo GetPeriodoDiValidita()
        {
            Periodo periodo;
            DateTime dataInizio = _schedaForm.DataInizio.Value;

            if (_schedaForm.DataFineRadioButton.Checked)
            {
                DateTime dataFine = _schedaForm.DataFine.Value;
                periodo = new Periodo(dataInizio, dataFine);
            }
            else
            {
                string durata = _schedaForm.Durata.Text.Trim();
                int giorni = 0;

                giorni = Int32.Parse(durata);

                TimeSpan timeSpanDurata = new TimeSpan(giorni, 0, 0, 0);
                periodo = new Periodo(dataInizio, timeSpanDurata);
            }
            return periodo;
        }

        private Scheda NuovaScheda()
        {
            if (_scheda == null)
            {
                try
                {
                    string nome = _schedaForm.Nome.Text;
                    ScopoDellaScheda scopo = (ScopoDellaScheda)_schedaForm.ScopoComboBox.SelectedItem;
                    string decrizione = _schedaForm.Descrizione.Text;

                    Periodo periodo = GetPeriodoDiValidita();
                    _scheda = new Scheda(nome, scopo, decrizione, periodo);
                }
                catch (Exception exception)
                {
                    string messageBoxText = exception.Message;
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
                }
            }
            return _scheda;
        }

        protected virtual void OKButtonClick(object sender, EventArgs e)
        {
            if (NuovaScheda() != null)
            {
                Trainary.GestoreSchede .GetInstance().GetSchede().Add(_scheda);
            }
        }

        protected virtual void _nuovaSedutaButton_Click(object sender, EventArgs e)
        {
            if (NuovaScheda() != null)
            {
                _schedaForm.Buttons.CancelButton.Enabled = true;
                Seduta seduta = _scheda.AggiungiSeduta(new List<Esercizio>());
                FireSeduteChanged();
            }
        }

        protected void FireSeduteChanged()
        {
            if (SeduteChanged != null)
                SeduteChanged(null, EventArgs.Empty);
        }

        //private void VisualizzaSeduta(Seduta seduta)
        //{
        //    TreeNode node = new TreeNode(seduta.ToString());
        //    node.Tag = seduta;
        //    VisualizzaEserciziSeduta(node,seduta.Esercizi);
        //    _schedaForm.TreeView.Nodes.Add(node);
        //}

        //private void VisualizzaEserciziSeduta(TreeNode node, IList<Esercizio> esercizi)
        //{
        //    if (esercizi.Count == 0)
        //        return;
        //    foreach (Esercizio es in esercizi)
        //    {
        //        TreeNode nodeEs = new TreeNode(es.ToString());
        //        nodeEs.Tag = es;
        //        foreach(Attributo target in es.Targets)
        //        {
        //            TreeNode nodoTarget = new TreeNode(target.ToString());
        //            nodeEs.Nodes.Add(nodoTarget);
        //        }
        //        node.Nodes.Add(nodeEs);
        //        if(es is Circuito)
        //            VisualizzaEserciziSeduta(nodeEs, ((Circuito)es).Esercizi);
        //    }
        //}
    }
}

