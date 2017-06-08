using System;
using System.Drawing;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter.attributi
{
    [Label("Durata")]
    public class TimePresenter : QuantitaPresenter
    {
        private DateTimePicker _timePicker;

        public TimePresenter()
        {
            _timePicker = new DateTimePicker();
            _timePicker.Format = DateTimePickerFormat.Time;
            _timePicker.ShowUpDown = true;
            _timePicker.Location = new Point(0, 4);
            _timePicker.Size = new Size(121, 20);
            _timePicker.Margin = new Padding(3);
        }

        public override void DrawControls(Panel panel)
        {
            Refresh();
            panel.Controls.Add(_timePicker);
        }

        public override void Refresh()
        {
            _timePicker.Value = DateTime.Today.Date;
        }

        public override Quantita GetNewQuantita()
        {
            return QuantitaFactory.NewQuantita(_timePicker.Value.TimeOfDay);
        }

    }
}
