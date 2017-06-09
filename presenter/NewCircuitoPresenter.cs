using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Trainary.model;
using Trainary.presenter.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    public class NewCircuitoPresenter
    {
        private NewCircuitoForm _form;

        private ListBoxPresenter<Esercizio> _eserciziPresenter;
        private AttributiPresenter _attributiPresenter;

        public NewCircuitoPresenter(NewCircuitoForm form, List<Esercizio> esercizi)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;
            if (esercizi == null)
                throw new ArgumentNullException("esercizi");

            _eserciziPresenter = new ListBoxPresenter<Esercizio>(_form.EserciziListBoxControl, esercizi);
            _attributiPresenter = new AttributiPresenter(_form.AttributiControl);

            _form.AttributiControl.ListLabel.Text = "Targets";
            _form.EserciziListLabel.Text = "Seleziona gli esercizi (almeno 2):";
            Application.Idle += ApplicationIdle;
        }

        private void ApplicationIdle(object sender, EventArgs e)
        {
            _form.OkButton.Enabled = _eserciziPresenter.SelectedItems.Count() >= 2;
        }

        public Circuito NewCircuito()
        {
            return new Circuito(_attributiPresenter.Attributi.ToArray(), _eserciziPresenter.SelectedItems.ToArray());
        }
    }
}
