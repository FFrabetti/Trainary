using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.view;

namespace Trainary.presenter.attributi
{
    public class NewAttributoPresenter
    {
        public event EventHandler Refreshed;

        private NewAttributoControl _control;

        private QuantitaPresenter _currentQPresenter;
        private List<QuantitaPresenter> _presenters;

        public NewAttributoPresenter(NewAttributoControl control)
        {
            if (control == null)
                throw new ArgumentNullException("new attributo control");
            _control = control;

            _presenters = new List<QuantitaPresenter>();
            InizializeQuantitaPresenters();
            InizializeComboBox();
        }

        public NewAttributoControl NewAttributoControl
        {
            get { return _control; }
        }

        private void InizializeComboBox()
        {
            _control.TipoComboBox.DataSource = _presenters;
            _control.TipoComboBox.DisplayMember = "LabelAttribute";

            _control.TipoComboBox.SelectedValueChanged += ComboChangedHandler;
            ComboChangedHandler(_control.TipoComboBox, null);
        }

        private void InizializeQuantitaPresenters()
        {
            QuantitaPresenter presenter = null;
            ConstructorInfo constructor = null;

            foreach(Type tipo in Assembly.GetExecutingAssembly().GetTypes())
            {
                if(
                    tipo.IsSubclassOf(typeof(QuantitaPresenter)) &&
                    !tipo.IsAbstract &&
                    (constructor = tipo.GetConstructor(Type.EmptyTypes)) != null
                )
                {
                    try
                    {
                        presenter = (QuantitaPresenter) constructor.Invoke(null);
                        if (presenter != null)
                            _presenters.Add(presenter);
                    }
                    catch
                    {
                        // skip
                    }
                }
            }
        }

        private void ComboChangedHandler(object sender, EventArgs e)
        {
            ComboBox combo = ((ComboBox)sender);
            _currentQPresenter = (QuantitaPresenter)combo.SelectedValue;

            _control.QuantitaPanel.Controls.Clear();
            _currentQPresenter.DrawControls(_control.QuantitaPanel);
            Refresh();
        }

        public Attributo NewAttributo()
        {
            string nome = _control.NomeTextBox.Text;
            Quantita quantita = _currentQPresenter.GetNewQuantita();
            return new Attributo(nome, quantita);
        }

        public void Refresh()
        {
            _control.NomeTextBox.Clear();
            _currentQPresenter.Refresh();

            if (Refreshed != null)
                Refreshed(this, EventArgs.Empty);
        }
    }
}
