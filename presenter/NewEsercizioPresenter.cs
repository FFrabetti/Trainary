using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.presenter.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    class NewEsercizioPresenter
    {
        private NewEsercizioForm _form;

        private AttributiPresenter _attributiPresenter;
        private ListBoxPresenter<Attributo> _listBoxPresenter;

        private Attivita _selectedAttivita;

        public NewEsercizioPresenter(NewEsercizioForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;

            _attributiPresenter = new AttributiPresenter(_form.AttributiControl);
            _listBoxPresenter = new ListBoxPresenter<Attributo>(_form.ListBoxControl);

            InitializeTreeView();
            InitializeTableLayout();
            InitializeAttributiControl();
            InitializeListBoxControl();

            // abilito/disabilito pulsanti e rimuovo eventuali error providers
            Application.Idle += ApplicationIdle;
            // controlli in chiusura, validazione
            _form.FormClosing += FormClosingHandler;
        }

        private void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            if(_form.DialogResult == DialogResult.OK && _selectedAttivita == null)
            {
                e.Cancel = true;
                SetError(_form.AttivitaLabel, "Devi selezionare un'attività");
            }
        }

        private void ApplicationIdle(object sender, EventArgs e)
        {
            _form.DialogButtonsControl.OkButton.Enabled = _selectedAttivita != null;
            _form.ListBoxControl.AddButton.Enabled = _form.AttributiControl.NomeTextBox.Text.Length > 0;
            // RemoveButton gestito da ListBoxPresenter

            if (_selectedAttivita != null)
                RemoveError(_form.AttivitaLabel);
        }

        private void InitializeTreeView()
        {
            Categoria root = Documento.GetInstance().GetCategoriaRadice();

            PopulateTree(_form.TreeView.Nodes, root);
            _form.TreeView.ExpandAll();

            _form.TreeView.AfterSelect += OnSelectNode;
        }

        private void PopulateTree(TreeNodeCollection nodes, Categoria categoria)
        {
            TreeNode node = new TreeNode(categoria.ToString());
            node.NodeFont = new Font(_form.TreeView.Font, FontStyle.Bold);
            nodes.Add(node);

            foreach(Categoria subCat in categoria.SottoCategorie)
            {
                PopulateTree(node.Nodes, subCat);
            }

            foreach(Attivita attivita in categoria.Attivita)
            {
                TreeNode attivitaNode = new TreeNode(attivita.ToString());
                attivitaNode.Tag = attivita;
                node.Nodes.Add(attivitaNode);
            }
        }

        private void OnSelectNode(object sender, TreeViewEventArgs e)
        {
            TreeView treeView = (TreeView)sender;
            if(treeView.SelectedNode.Tag is Attivita)
            {
                _selectedAttivita = (Attivita)treeView.SelectedNode.Tag;
                _form.AttivitaValue.Text = _selectedAttivita.Nome;
                _form.DescrizioneValue.Text = _selectedAttivita.Descrizione;
                _form.AttrezziValue.Text = AttrezziToString(_selectedAttivita.Attrezzi);
            }
        }

        private string AttrezziToString(string[] attrezzi)
        {
            if (attrezzi.Length == 0)
                return String.Empty;

            StringBuilder sb = new StringBuilder();

            for(int i=0; i<attrezzi.Length; i++)
            {
                if (i != 0)
                    sb.Append(", ");
                sb.Append(attrezzi[i]);
            }

            return sb.ToString();
        }

        private void InitializeTableLayout()
        {
            _form.AttivitaValue.Text = 
                _form.DescrizioneValue.Text = 
                    _form.AttrezziValue.Text = String.Empty;
        }

        private void InitializeAttributiControl()
        {
            _attributiPresenter.Refreshed += AttributiRefreshed;
        }

        private void AttributiRefreshed(object sender, EventArgs e)
        {
            RemoveError(_form.AttributiControl.ValoreLabel);
        }

        private void InitializeListBoxControl()
        {
            _form.ListBoxControl.TitleLabel.Text = "Atttributi target";
            _form.ListBoxControl.AddButton.Click += AddTargetHandler;
            _form.ListBoxControl.ListBox.SelectionMode = SelectionMode.One;
        }

        private void AddTargetHandler(object sender, EventArgs e)
        {
            try
            {
                Attributo attributo = _attributiPresenter.NewAttributo();
                _listBoxPresenter.AddItem(attributo);

                _attributiPresenter.Refresh();
            }
            catch (Exception ex)
            {
                SetError(_form.AttributiControl.ValoreLabel, ex.Message);
            }
        }
        
        public Esercizio NewEsercizio()
        {
            return new EsercizioSingolo(_selectedAttivita, _listBoxPresenter.Items.ToArray());
        }

        private void SetError(Control control, string message)
        {
            _form.ErrorProvider.SetError(control, message);
        }

        private void RemoveError(Control control)
        {
            _form.ErrorProvider.SetError(control, null);
        }
    }
}
