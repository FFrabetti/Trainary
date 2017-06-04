using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.model;
using Trainary.view;

namespace Trainary.presenter
{
    class NewEsercizioPresenter
    {
        private NewEsercizioForm _form;

        public NewEsercizioPresenter(NewEsercizioForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");

            _form = form;

            InitializeTreeView();

        }

        private void InitializeTreeView()
        {
            Categoria root = Documento.GetInstance().GetCategoriaRadice();
            //_form.TreeView...
        }
    }
}
