using System;
using System.Collections.Generic;
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

            _control.AggiungiSedutaButton.Click += OnAggiungiSedutaButtonClick;
            _control.RimuoviSchedaButton.Click += OnRimuoviSchedaButtonClick;
            _control.ListView.SelectedIndexChanged += OnSelectedScheda;
            _control.ListView.DoubleClick += OnDoubleClick;
            Application.Idle += OnIdle;
            GestoreSchede.GetInstance().SchedeChanged += OnSchedeChanged;

            OnSchedeChanged(this, EventArgs.Empty);
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            SchedaForm form = new SchedaForm();
            VisualizzaSchedaPresenter presenter = new VisualizzaSchedaPresenter(form, (Scheda)_control.ListView.SelectedItems[0].Tag);
                form.Show();
            
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

            foreach (ListViewItem item in _control.ListView.SelectedItems)
            {
                GestoreSchede.GetInstance().GetSchede().Remove((Scheda)item.Tag);
            }
            
            
            OnSchedeChanged(this,EventArgs.Empty);
        }

        private void OnSchedeChanged(object sender, EventArgs e)
        {
            VisualizzaSchede();
        }

        private void VisualizzaSchede()
        {
            _control.ListView.Items.Clear();
            foreach (Scheda s in GestoreSchede.GetInstance().GetSchede())
            {
                ListViewItem item = new ListViewItem(s.Nome);
                item.Tag = s;
                
                item.SubItems.Add(s.Scopo.ToString());
                item.SubItems.Add(s.Descrizione);
                item.SubItems.Add(s.PeriodoDiValidita.ToString());
                _control.ListView.Items.Add(item);
            }
        }
        private void OnAggiungiSedutaButtonClick(object sender, EventArgs e)
        {
            SchedaForm form = new SchedaForm();
            
                NuovaSchedaPresenter presenter = new NuovaSchedaPresenter(form);
                form.Show();
             
            
        }
    }
}
