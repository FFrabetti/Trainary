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
            _textBox.Margin = new Padding(3);

            _comboBox.Location = new Point(64, 4);
            _comboBox.Size = new Size(57, 20);
            _comboBox.Margin = new Padding(3);
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
            panel.Controls.Add(_textBox);
            panel.Controls.Add(_comboBox);
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
            UnitaDiMisura unita = (UnitaDiMisura) _comboBox.SelectedItem;
            return QuantitaFactory.NewQuantita(value, unita);
        }

    }
}
