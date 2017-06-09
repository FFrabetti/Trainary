using System;
using System.Windows.Forms;
using Trainary.model.attributi;
using System.Drawing;
using Trainary.utils;

namespace Trainary.presenter.attributi
{
    [Label("Ripetizione")]
    public class RepetitionPresenter : QuantitaPresenter
    {
        private TextBox _textBox;

        public RepetitionPresenter()
        {
            _textBox = new TextBox();
            _textBox.Size = new Size(57, 20);
            _textBox.Location = new Point(0, 4);
        }

        public override void DrawControls(Panel panel)
        {
            panel.Controls.Add(_textBox);
        }

        public override void Refresh()
        {
            _textBox.Clear();
        }

        public override Quantita GetNewQuantita()
        {
            int value = int.Parse(_textBox.Text);
            if (value <= 0)
                throw new ArgumentException("Consentiti solo valori positivi");

            return QuantitaFactory.NewQuantita(value);
        }

    }
}
