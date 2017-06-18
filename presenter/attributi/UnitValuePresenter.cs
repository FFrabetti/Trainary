using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Trainary.model.attributi;

namespace Trainary.presenter.attributi
{
    public abstract class UnitValuePresenter : QuantitaPresenter
    {
        private ComboBox _comboBox;
        private TextBox _textBox;

        public UnitValuePresenter()
        {
            _comboBox = new ComboBox();
            _textBox = new TextBox();

            _textBox.Location = new Point(0, 5);
            _textBox.Size = new Size(57, 20);

            _comboBox.Location = new Point(64, 4);
            _comboBox.Size = new Size(57, 20);
        }

        // used by sub-classes to fill the combo box
        protected abstract IList<UnitaDiMisura> UnitaDiMisura
        {
            get;
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_textBox);
            panel.Controls.Add(_comboBox);

            // richiede una IList o una IListSource
            _comboBox.DataSource = UnitaDiMisura;
            _comboBox.DisplayMember = "Simbolo";
        }

        public override void Refresh()
        {
            _textBox.Clear();
            if(_comboBox.Items.Count >= 0)
                _comboBox.SelectedIndex = 0;
        }

        public override Quantita GetNewQuantita()
        {
            double value = double.Parse(_textBox.Text);
            if (value < 0)
                throw new ArgumentException("La quantità non può essere negativa");

            UnitaDiMisura unita = (UnitaDiMisura) _comboBox.SelectedItem;
            return QuantitaFactory.NewQuantita(value, unita);
        }

    }
}
