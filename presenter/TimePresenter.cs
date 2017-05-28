using System;
using System.Windows.Forms;
using Trainary.model.attributi;
using Trainary.utils;

namespace Trainary.presenter
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
            _timePicker.Location = new System.Drawing.Point(0, 4);
            _timePicker.Size = new System.Drawing.Size(121, 20);
        }

        public override void DrawControls(Panel panel)
        {
            Refresh();
            panel.Controls.Add(_timePicker);
        }

        public override Quantita GetNewQuantita()
        {
            Quantita result = null;
            try
            {
                result = QuantitaFactory.NewQuantita(_timePicker.Value.TimeOfDay);

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
            _timePicker.Value = DateTime.Today.Date;
            LastException = null;
        }
    }
}
