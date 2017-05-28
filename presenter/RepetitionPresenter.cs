using System;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter
{
    [Label("Ripetizione")]
    public class RepetitionPresenter : QuantitaPresenter
    {
        private TextBox _textBox;

        public RepetitionPresenter()
        {
            _textBox = new TextBox();
            _textBox.Size = new System.Drawing.Size(57, 20);
            _textBox.Location = new System.Drawing.Point(0, 4);
        }

        public override void DrawControls(Panel panel)
        {
            Refresh();
            panel.Controls.Add(_textBox);
        }

        public override Quantita GetNewQuantita()
        {
            Quantita result = null;
            try
            {
                int value = int.Parse(_textBox.Text);
                if (value <= 0)
                    throw new Exception("value <= 0");
                result = QuantitaFactory.NewQuantita(value);

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

        public override void Refresh()
        {
            _textBox.Clear();
            LastException = null;
        }
    }
}
