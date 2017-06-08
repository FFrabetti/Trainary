using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.presenter;
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

            _form.ListBoxControl.TitleLabel.Text = "Atttributi target";
            InitializeTreeView();
            InitializeTableLayout();

            // abilito/disabilito pulsanti e rimuovo eventuali error providers
            Application.Idle += ApplicationIdle;
            // controlli in chiusura --- come farli solo se OK è stato premuto?
            _form.FormClosing += FormClosingHandler;
        }

        private void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            // da sistemare
            Console.WriteLine("FormClosing: " + sender);

            if(
                //sender is Button && ((Button)sender) == _form.DialogButtonsControl.OkButton &&
                _selectedAttivita == null
            )
            {
                e.Cancel = true;
                _form.ErrorProvider.SetError(_form.AttivitaLabel, "Devi selezionare un'attivita'");
            }
        }

        private void ApplicationIdle(object sender, EventArgs e)
        {
            _form.DialogButtonsControl.OkButton.Enabled = _selectedAttivita != null;
            _form.ListBoxControl.AddButton.Enabled = _form.AttributiControl.NomeTextBox.Text.Length > 0;
            _form.ListBoxControl.RemoveButton.Enabled = _form.ListBoxControl.ListBox.SelectedItems.Count == 1;

            if(_selectedAttivita != null)
                _form.ErrorProvider.SetError(_form.AttivitaLabel, "");
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
            node.ForeColor = Color.Gray;
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
                return "";

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
            _form.AttivitaValue.Text = "";
            _form.DescrizioneValue.Text = "";
            _form.AttrezziValue.Text = "";
        }

        public Esercizio NewEsercizio()
        {
            // da sistemare
            return new EsercizioSingolo(_selectedAttivita);
        }
    }
}
