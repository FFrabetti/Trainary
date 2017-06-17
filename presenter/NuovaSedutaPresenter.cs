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
    class NuovaSedutaPresenter
    {
        private NuovaSedutaView _form;
        private ListBoxControl _control = new ListBoxControl();
        private List<Esercizio> _esercizi = new List<Esercizio>();
        private ListBoxPresenter<Esercizio> _presenter;
        public NuovaSedutaPresenter(NuovaSedutaView form)
        {
            _form = form;
           _presenter = new ListBoxPresenter<Esercizio>(_control);
            _form.Panel.Controls.Add(_control);
            _control.AutoSize = true;
            _control.AddButton.Click += AddClick;
            _control.TitleLabel.Text = "Esercizi";
            _form.Buttons.OkButton.Click += OkClick;
            
    }

        private void AddClick(object sender, EventArgs e)
        {
            Esercizio esercizio;
            using (NewEsercizioForm newEsForm = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(newEsForm);

                if (newEsForm.ShowDialog() == DialogResult.OK)
                {
                    esercizio = presenter.NewEsercizio();
                    _esercizi.Add(esercizio);
                    _presenter.AddItem(esercizio);
                }
                newEsForm.Close();
            }
        }
        private void OkClick(object sender, EventArgs e)
        {
            _form.Close();
        }



       
        public List<Esercizio> Esercizi
        {
            get
            {
                return _esercizi;
            }
        }
    }
}
