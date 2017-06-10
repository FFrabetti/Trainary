using System;
using System.Drawing;
using System.Windows.Forms;
using Trainary.model;
using Trainary.presenter.attributi;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter
{
    public class NewEsercizioPresenter
    {
        private NewEsercizioForm _form;
        private AttributiPresenter _attributiPresenter;

        private Attivita _selectedAttivita;

        public NewEsercizioPresenter(NewEsercizioForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;

            _attributiPresenter = new AttributiPresenter(_form.AttributiControl);

            InitializeTreeView();
            InitializeTableLayout();
            InitializeAttributiControl();

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
                _form.ErrorProvider.SetError(_form.AttivitaLabel, "Devi selezionare un'attività");
            }
        }

        private void ApplicationIdle(object sender, EventArgs e)
        {
            _form.OkButton.Enabled = _selectedAttivita != null;

            if (_selectedAttivita != null)
                _form.ErrorProvider.UnsetError(_form.AttivitaLabel);
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
                _form.AttrezziValue.Text = _selectedAttivita.AttrezziToString();
            }
        }

        private void InitializeTableLayout()
        {
            _form.AttivitaValue.Text = 
                _form.DescrizioneValue.Text = 
                    _form.AttrezziValue.Text = String.Empty;
        }

        private void InitializeAttributiControl()
        {
            _form.AttributiControl.ListLabel.Text = "Targets";
        }

        public Esercizio NewEsercizio()
        {
            return new EsercizioSingolo(_selectedAttivita, _attributiPresenter.Attributi.ToArray());
        }

    }
}
