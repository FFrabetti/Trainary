using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.view;

namespace Trainary.presenter
{
    class GestioneSchedePresenter
    {
        private GestioneSchedeControl _control;
        public GestioneSchedePresenter(GestioneSchedeControl control)
        {
            if (control == null)
                throw new ArgumentNullException("control");
            _control = control;

            _control.AggiungiSedutaButton.Click += OnAggiungiSchedaButtonClick;
            _control.RimuoviSchedaButton.Click += OnRimuoviSchedaButtonClick;
            _control.ListView.SelectedIndexChanged += OnSelectedScheda;
            _control.ListView.DoubleClick += OnDoubleClick;
            Application.Idle += OnIdle;
            GestoreSchede.GetInstance().SchedeChanged += OnSchedeChanged;

            OnSchedeChanged(this, EventArgs.Empty);
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            using (SchedaForm form = new SchedaForm())
            {
                VisualizzaSchedaPresenter presenter = new VisualizzaSchedaPresenter(form, (Scheda)_control.ListView.SelectedItems[0].Tag);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnSchedeChanged(null, EventArgs.Empty);
                }
                else
                    presenter.CancellaNuoveSedute();
            }
        }

        private void OnSelectedScheda(object sender, EventArgs e)
        {
            _control.RimuoviSchedaButton.Enabled = _control.ListView.SelectedItems.Count > 0;
        }

        private void OnIdle(object sender, EventArgs e)
        {
           if( _control.ListView.SelectedItems.Count == 0)
                _control.RimuoviSchedaButton.Enabled = false;
        }

        private void OnRimuoviSchedaButtonClick(object sender, EventArgs e)
        {
            string messageBoxText = "Sicuro di voler cancellare " +
                (_control.ListView.SelectedItems.Count > 1 ?
                    _control.ListView.SelectedItems.Count + " schede" :
                    "la scheda " + _control.ListView.SelectedItems[0].Tag
                ) + "?";
            string caption = "Conferma cancellazione";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            if (MessageBox.Show(messageBoxText, caption, buttons, icon) == DialogResult.OK)
            {

                foreach (ListViewItem item in _control.ListView.SelectedItems)
                {
                    GestoreSchede.GetInstance().GetSchede().Remove((Scheda)item.Tag);
                }

                OnSchedeChanged(this, EventArgs.Empty);
            }
        }

        private void OnSchedeChanged(object sender, EventArgs e)
        {
            VisualizzaSchede();
        }

        private void VisualizzaSchede()
        {
            _control.ListView.Items.Clear();
            foreach (Scheda s in GestoreSchede.GetInstance().GetSchede().OrderByDescending(scheda => scheda.isValida(DateTime.Today)))
            {
                ListViewItem item = new ListViewItem(s.Nome);
                item.Tag = s;
                
                item.SubItems.Add(s.Scopo.ToString());
                item.SubItems.Add(s.Descrizione);
                item.SubItems.Add(s.PeriodoDiValidita.ToString());
                item.SubItems.Add(s.Sedute.Length.ToString());
                _control.ListView.Items.Add(item);

                if(!s.isValida(DateTime.Today))
                    item.ForeColor = Color.Red;
                else
                    item.ForeColor = Color.Green;
            }
        }

        private void OnAggiungiSchedaButtonClick(object sender, EventArgs e)
        {
            using (SchedaForm form = new SchedaForm())
            {
                NuovaSchedaPresenter presenter = new NuovaSchedaPresenter(form);
                form.ShowDialog();
            }
        }
    }
}
