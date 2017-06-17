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

            _control.AggiungiSedutaButton.Click += AggiungiSedutaButtonClick;
            GestoreSchede.GetInstance().SchedeChanged += OnSchedeChanged;

            OnSchedeChanged(this, EventArgs.Empty);
        }

        private void OnSchedeChanged(object sender, EventArgs e)
        {
            VisualizzaSchede();
        }

        private void VisualizzaSchede()
        {
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
        private void AggiungiSedutaButtonClick(object sender, EventArgs e)
        {
            SchedaForm form = new SchedaForm();
            
                NuovaSchedaPresenter presenter = new NuovaSchedaPresenter(form);
                form.Show();
             
            
        }
    }
}
