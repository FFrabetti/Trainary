using System;
using Trainary.model;
using Trainary.view;


namespace Trainary.presenter
{
    class SelezionaEserciziSedutaPresenter
    {
        private SelezionaEserciziSeduta _form;
        private Seduta _seduta;
        private TreeViewPresenter _presenter;

        public SelezionaEserciziSedutaPresenter(SelezionaEserciziSeduta form, Seduta seduta)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            if (seduta == null)
                throw new ArgumentNullException("seduta");
            _form = form;
            _seduta = seduta;

            _presenter = new TreeViewPresenter(form.TreeView);
            form.TreeView.AfterSelect += OnTreeNodeSelected;
          
            _presenter.VisualizzaSeduta(_seduta);

            OnTreeNodeSelected(null, EventArgs.Empty);
        }

        private void OnTreeNodeSelected(object sender, EventArgs e)
        {
            _form.Buttons.OkButton.Enabled = _form.TreeView.SelectedNode != null &&
                _form.TreeView.SelectedNode.Tag is Esercizio &&
                !(_form.TreeView.SelectedNode.Parent.Tag is Circuito);
        }

        public Esercizio GetEsercizio()
        {           
            return  (Esercizio)_form.TreeView.SelectedNode.Tag;
        }
    }
}
