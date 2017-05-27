using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    public abstract class UnitValuePresenter : QuantitaPresenter
    {
        private ComboBox _comboBox;
        private TextBox _textBox;

        public UnitValuePresenter()
        {
            _comboBox = new ComboBox();
            _textBox = new TextBox();

            _textBox.Location = new System.Drawing.Point(0, 5);
            _textBox.Size = new System.Drawing.Size(57, 20);

            _comboBox.Location = new System.Drawing.Point(64, 4);
            _comboBox.Size = new System.Drawing.Size(57, 20);

        }

        // used by sub-classes to fill the combo box
        public ComboBox ComboBox
        {
            get { return _comboBox; }
        }

        public TextBox TextBox
        {
            get { return _textBox; }
        }

        public override void DrawControls(Panel panel)
        {
            Refresh();

            panel.Controls.Add(_textBox);
            panel.Controls.Add(_comboBox);
        }

        public override void Refresh()
        {
            _textBox.Clear();
            LastException = null;
            // refresh combo box?
        }

        public override Quantita GetNewQuantita()
        {
            Quantita result = null;
            try
            {
                double value = double.Parse(_textBox.Text);
                UnitaDiMisura unita = (UnitaDiMisura) _comboBox.SelectedItem;
                result = QuantitaFactory.NewQuantita(value, unita);

                if (result == null)
                    throw new Exception("result is null");
                LastException = null;
            }
            catch (Exception e)
            {
                LastException = e;
            }
            return result;
        }

    }
}
