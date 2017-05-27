using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    public class AttributiPresenter
    {
        private AttributiControl _control;
        private QuantitaPresenter _currentQPresenter;

        public AttributiPresenter(AttributiControl control)
        {
            if (control == null)
                throw new ArgumentNullException("control");

            _control = control;

            Inizialize();
            SelectedPresenter(_control.TipoComboBox);
        }

        public AttributiControl Control
        {
            get { return _control; }
        }

        private void Inizialize()
        {
            QuantitaPresenter presenter = null;
            List<QuantitaPresenter> presenters = new List<QuantitaPresenter>();
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
                    catch(Exception e)
                    {
                        // skip
                    }
                }
            }

            _control.TipoComboBox.DataSource = presenters;
            _control.TipoComboBox.DisplayMember = "Label";

            _control.TipoComboBox.SelectedValueChanged += ComboChangeHandler;
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
