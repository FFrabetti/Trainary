using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    public class AttributiPresenter
    {
        private AttributiControl _control;
        private QuantitaPresenter _currentQPresenter;
        private List<QuantitaPresenter> _presenters;

        public AttributiPresenter(AttributiControl control)
        {
            _presenters = new List<QuantitaPresenter>();
            Inizialize();
            UserControl = control;
        }

        public AttributiControl UserControl
        {
            get { return _control; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("user control");

                _control = value;
                InizializeComboBox();
            }
        }

        private void InizializeComboBox()
        {
            _control.TipoComboBox.DataSource = _presenters;
            _control.TipoComboBox.DisplayMember = "LabelAttribute";

            SelectedPresenter(_control.TipoComboBox);

            _control.TipoComboBox.SelectedValueChanged += ComboChangeHandler;
        }

        private void Inizialize()
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

        private void ComboChangeHandler(object sender, EventArgs e)
        {
            SelectedPresenter((ComboBox)sender);
        }

        private void SelectedPresenter(ComboBox combo)
        {
            _currentQPresenter = (QuantitaPresenter)combo.SelectedValue;

            _control.QuantitaPanel.Controls.Clear();
            _currentQPresenter.DrawControls(_control.QuantitaPanel);
        }

        public Attributo NewAttributo()
        {
            string nome = _control.NomeTextBox.Text;
            Quantita quantita = _currentQPresenter.GetNewQuantita();
            return new Attributo(nome, quantita);
        }

    }
}
