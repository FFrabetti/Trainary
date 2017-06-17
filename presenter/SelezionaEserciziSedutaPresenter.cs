using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainary.model;
using Trainary.view;

namespace Trainary.presenter
{
    class SelezionaEserciziSedutaPresenter
    {
        private SelezionaEserciziSeduta _form;
        private Seduta _seduta;
        public SelezionaEserciziSedutaPresenter(SelezionaEserciziSeduta form,Seduta seduta)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            if (seduta == null)
                throw new ArgumentNullException("seduta");
            _form = form;
            _seduta = seduta;
            //_form.OkButton.Click += Ok_Click;
            VisualizzaSeduta();
        }

        private void VisualizzaSeduta()
        {
            _form.ListBox.DataSource = _seduta.Esercizi;
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            _form.Close();
        }
        public EsercizioSvolto GetEsercizioSvolto()
        {
            Esercizio esercizio = (Esercizio)_form.ListBox.SelectedItem;
            SvolgiVisitor sv = new SvolgiVisitor();
            esercizio.Accept(sv);
            EsercizioSvolto eSvolto = sv.EsercizioSvolto;
            // eSvolto.AddDati();
            return eSvolto;
        }
    }
}
