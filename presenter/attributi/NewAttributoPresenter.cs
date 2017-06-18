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

        public NewAttributoPresenter(NewAttributoControl control)
        {
            if (control == null)
                throw new ArgumentNullException("new attributo control");
            _control = control;

            InizializeComboBox(GetQuantitaPresenters());
        }

        public NewAttributoControl NewAttributoControl
        {
            get { return _control; }
        }

        public Attributo NewAttributo()
        {
            string nome = _control.NomeTextBox.Text;
            Quantita quantita = _currentQPresenter.GetNewQuantita();
            return new Attributo(nome, quantita);
        }

        private void InizializeComboBox(List<QuantitaPresenter> presenters)
        {
            _control.TipoComboBox.DataSource = presenters;
            _control.TipoComboBox.DisplayMember = "LabelAttribute";

            _control.TipoComboBox.SelectedValueChanged += OnComboChanged;
            OnComboChanged(_control.TipoComboBox, EventArgs.Empty);
        }

        private List<QuantitaPresenter> GetQuantitaPresenters()
        {
            List<QuantitaPresenter> presenters = new List<QuantitaPresenter>();
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
                            presenters.Add(presenter);
                    }
                    catch
                    {
                        // skip
                    }
                }
            }

            return presenters;
        }

        private void OnComboChanged(object sender, EventArgs e)
        {
            ComboBox combo = ((ComboBox)sender);
            _currentQPresenter = (QuantitaPresenter)combo.SelectedValue;

            _control.QuantitaPanel.Controls.Clear();
            _currentQPresenter.DrawControls(_control.QuantitaPanel);
            Refresh();
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
