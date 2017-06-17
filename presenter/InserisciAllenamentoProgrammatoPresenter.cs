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
    class InserisciAllenamentoProgrammatoPresenter
    {
        private AllenamentoForm _form;
        private SelezionaSedutaControl _control = new SelezionaSedutaControl();
        private List<EsercizioSvolto> _eserciziSvolti = new List<EsercizioSvolto>();
        private List<Scheda> _schede = new List<Scheda>();
        private List<Seduta> _sedute = new List<Seduta>();
        private Seduta _seduta;
        public InserisciAllenamentoProgrammatoPresenter(AllenamentoForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;
            _form.Panel.Controls.Add(_control);
            _form.ButtonPiu.Click += ButtonPiu_Click;
            _form.Buttons.OkButton.Click += OkButton_Click;
            _form.AllenamentoLabel.Text = "Allenamento Programmato";

            InizializeSchedeCombo();
        }
        private Seduta Seduta
        {
            get
            {
                _seduta = (Seduta)_control.ComboSedute.SelectedItem;
                return _seduta;
            }
        }
        private void InizializeSchedeCombo()
        {
            foreach (Scheda scheda in GestoreSchede.GetInstance().GetSchede())
                _schede.Add(scheda);

            _control.ComboSchede.DataSource = _schede;
            _control.ComboSchede.SelectedIndexChanged += SelectedSchedaCombo;
            SelectedSchedaCombo(this, EventArgs.Empty);
        }
        private void InizializeSeduteCombo()
        {
            Scheda scheda = (Scheda)_control.ComboSchede.SelectedItem;
            _control.ComboSedute.DataSource = scheda.Sedute;
        }

        private void SelectedSchedaCombo(object sender, EventArgs e)
        {
            InizializeSeduteCombo();
        }
        private void ButtonPiu_Click(object sender, EventArgs e)
        {

           // _seduta = Seduta;
            using (SelezionaEserciziSeduta form = new SelezionaEserciziSeduta())
            {
                SelezionaEserciziSedutaPresenter presenter;
                try
                {
                    presenter = new SelezionaEserciziSedutaPresenter(form, Seduta);
                }
                catch(Exception ex)
                {
                    string messageBoxText = ex.Message;
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
                    return;
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                    EsercizioSvolto ev = presenter.GetEsercizioSvolto();
                    _eserciziSvolti.Add(ev);

                    _form.DataEsercizi.EserciziListBox.Items.Add(ev);
                }
               
            }
            
            

        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime data = _form.DataEsercizi.Data.Value;
            AllenamentoProgrammato allenamento;
            try
            {
                allenamento = new AllenamentoProgrammato(data, _eserciziSvolti.ToArray(), _seduta);
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
            Diario.GetInstance().Allenamenti.Add(allenamento);
            _form.Close();
        }
    }
}
