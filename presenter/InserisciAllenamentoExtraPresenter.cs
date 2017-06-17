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
    class InserisciAllenamentoExtraPresenter
    {
        private AllenamentoForm _form;
        private List<EsercizioSvolto> _eserciziSvolti = new List<EsercizioSvolto>();
        private NomeUserControl _control = new NomeUserControl();
        public InserisciAllenamentoExtraPresenter(AllenamentoForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;
            _form.ButtonPiu.Click += ButtonPiu_Click;
            _form.Buttons.OkButton.Click += OkButton_Click;
            _form.Panel.Controls.Add(_control);
            _form.AllenamentoLabel.Text = "Allenamento Extra";

        }
        private void ButtonPiu_Click(object sender, EventArgs e)
        {
           // NewEsercizioForm newEsercizioForm = new NewEsercizioForm();
            //NewEsercizioPresenter nep = new NewEsercizioPresenter(newEsercizioForm);
            //newEsercizioForm.Show();
            SvolgiVisitor sv = new SvolgiVisitor();
            //while (newEsercizioForm.DialogResult != DialogResult.OK) ;
            Esercizio esercizio;
            using (NewEsercizioForm newEsForm = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(newEsForm);

                if (newEsForm.ShowDialog() == DialogResult.OK)
                {
                    esercizio = presenter.NewEsercizio();
                    esercizio.Accept(sv);
                    EsercizioSvolto ev = sv.EsercizioSvolto;
                    _eserciziSvolti.Add(ev);
                    
                    _form.DataEsercizi.EserciziListBox.Items.Add(ev);
                }
                newEsForm.Close();
            }
            //Esercizio esercizio = nep.NewEsercizio();
           
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime data = _form.DataEsercizi.Data.Value;
            string nome = _control.Nome.Text;
            AllenamentoExtra allenamentoExtra;
            try
            {
                allenamentoExtra = new AllenamentoExtra(data, _eserciziSvolti.ToArray(), nome);
            }
            catch (Exception ex)
            {
                string messageBoxText = ex.Message;
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(messageBoxText, caption, buttons, icon);
                return;
            }
            Diario.GetInstance().Allenamenti.Add(allenamentoExtra);
            _form.Close();
        }
    }
}
