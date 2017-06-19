using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.view;


namespace Trainary.presenter
{
    class SelezionaEserciziSedutaPresenter
    {
        private SelezionaEserciziSeduta _form;
        private Seduta _seduta;
        private TreeViewPresenter _presenter;
        public SelezionaEserciziSedutaPresenter(SelezionaEserciziSeduta form,Seduta seduta)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            if (seduta == null)
                throw new ArgumentNullException("seduta");
            _form = form;
            _seduta = seduta;
            _presenter = new TreeViewPresenter(form.TreeView);
            Application.Idle += OnIdle;
          
            _presenter.VisualizzaSeduta(_seduta);
        }

        private void OnIdle(object sender, EventArgs e)
        {
            _form.Buttons.OkButton.Enabled = _form.TreeView.SelectedNode != null && _form.TreeView.SelectedNode.Tag != null && _form.TreeView.SelectedNode.Tag.GetType().IsSubclassOf(typeof(Esercizio));
        }

        public Esercizio GetEsercizio()
        {
            return  (Esercizio)_form.TreeView.SelectedNode.Tag;
        }
    }
}
