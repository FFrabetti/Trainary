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
    class NuovaSchedaPresenter
    {
        private SchedaForm _schedaForm;
        private ComboBox _comboBox = new ComboBox();
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
        }
        private void OnNuovoCircuitoButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            if (node.Tag.GetType() == typeof(Seduta))
            {
                Seduta seduta = (Seduta) node.Tag;
                IList<Esercizio> esercizi = seduta.Esercizi;
                using(NewCircuitoForm form = new NewCircuitoForm())
                {
                    NewCircuitoPresenter presenter = new NewCircuitoPresenter(form, esercizi);
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        Circuito circuito = presenter.NewCircuito();
                        foreach(Esercizio es in circuito.Esercizi)
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
            if (node.Tag.GetType() == typeof(Seduta))
            {
                Seduta daRinominare = (Seduta) node.Tag;
                using (RinominaSedutaView view = new RinominaSedutaView())
                {
                    RinominaSedutaPresenter presenter = new RinominaSedutaPresenter(view);
                    if(view.ShowDialog() == DialogResult.OK)
                    {
                        string nuovoNome = presenter.NuovoNome();
                        try
                        {
                            daRinominare.Nome = nuovoNome; 
                        }
                        catch(Exception exception)
                        {
                            string messageBoxText = exception.Message;
                            string caption = "Errore";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Warning;

                            MessageBox.Show(messageBoxText, caption, buttons, icon);
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
            if(node.Tag.GetType() == typeof(Seduta))
            {
                Seduta sedutaDaEliminare = (Seduta) node.Tag;
                _scheda.RimuoviSeduta(sedutaDaEliminare);
                SeduteChanged(this, EventArgs.Empty);
            }
        }

        private void OnEliminaEsercizioButton(object sender, EventArgs e)
        {
            TreeNode node = _schedaForm.TreeView.SelectedNode;
            if(node.Tag.GetType().IsSubclassOf(typeof(Esercizio)))
            {
                Esercizio esercizioDaEliminare = (Esercizio)node.Tag;
                
                TreeNode superNode = node.Parent;
                if(superNode.Tag != null && superNode.Tag is Circuito && (superNode.Tag as Circuito).Esercizi.Count == 2)
                {
                    string messageBoxText = "Un circuito non può contenere meno di 2 esercizi";
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
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
            _schedaForm.EliminaEsercizioButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType().IsSubclassOf(typeof(Esercizio));  //_schedaForm.NuovoEsercizioButton.Enabled = _schedaForm.TreeView.SelectedNode.Parent==null;
            _schedaForm.RinominaSedutaButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta);
            _schedaForm.RimuoviSedutaButton.Enabled = _schedaForm.TreeView.SelectedNode.Tag.GetType() == typeof(Seduta);
        }

        private bool isValida(object tag)
        {
            if(tag.GetType() == typeof(Seduta))
            {
                Seduta seduta = (Seduta)tag;
                if (seduta.Esercizi.Count >= 2)
                    return true;
            }
            return false;
        }

        private void OnSeduteChanged(object sender, EventArgs e)
        {
            _schedaForm.TreeView.Nodes.Clear();
            _presenter.VisualizzaSedute(_scheda.Sedute);
        }
        private void InizializeScopoCombo()
        {
            _comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _comboBox.FormattingEnabled = true;
            _comboBox.Dock = DockStyle.Fill;
            _comboBox.TabIndex = 11;
            _comboBox.DataSource = Enum.GetValues(typeof(ScopoDellaScheda));
            _schedaForm.Scopo.Controls.Add(_comboBox);
           
        }
        private Scheda NuovaScheda()
        {
            Periodo periodo;
            
            string nome = _schedaForm.Nome.Text;
            ScopoDellaScheda scopo = (ScopoDellaScheda)_comboBox.SelectedItem;
            string decrizione = _schedaForm.Descrizione.Text;
            DateTime dataInizio = _schedaForm.DataInizio.Value;

            if (_schedaForm.DataFineRadioButton.Checked)
            {
                DateTime dataFine = _schedaForm.DataFine.Value;
                periodo = new Periodo(dataInizio, dataFine);
            }
            else
            {
                string durata = _schedaForm.Durata.Text;
                int giorni = 0;
                try
                {
                    giorni = Int32.Parse(durata);
                }
                catch (Exception exception)
                {
                    string messageBoxText = exception.Message;
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
                    return null;
                }
                TimeSpan timeSpanDurata = new TimeSpan(giorni, 0, 0, 0);
                periodo = new Periodo(dataInizio, timeSpanDurata);
            }
            return new Scheda(nome, scopo, decrizione, periodo);
        }
        private void OKButtonClick(object sender, EventArgs e)
        {
            if (_scheda == null)
            {
                string messageBoxText = "Non è possibile creare una scheda senza aver aggiunto almeno una seduta";
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(messageBoxText, caption, buttons, icon);
                return;
            }
            
                GestoreSchede.GetInstance().GetSchede().Add(_scheda);
                _schedaForm.Close();
            
        }

        private void _nuovaSedutaButton_Click(object sender, EventArgs e)
        {
            if (_scheda == null)
            {
                try
                {
                    _scheda = NuovaScheda();
                    if (_scheda == null) return;
                }
                catch (Exception exception)
                {
                    string messageBoxText = exception.Message;
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
                    return;

                }
            }
           
                Seduta seduta = _scheda.AggiungiSeduta(new List<Esercizio>());
                SeduteChanged(this, EventArgs.Empty);
            

           
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

