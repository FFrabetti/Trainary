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
    class InserisciAllenamentoProgrammatoPresenter : InserisciAllenamentoPresenter
    {

        private SelezionaSedutaControl _control = new SelezionaSedutaControl();
        private List<Scheda> _schede;
        //private List<Seduta> _sedute = new List<Seduta>();
        private Seduta _seduta;

        public InserisciAllenamentoProgrammatoPresenter(AllenamentoForm form)
            : base(form)
        {
            Form.Panel.Controls.Add(_control);
            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioButton;
            Form.AggiungiCircuitoButton.Visible = false;
            Form.Buttons.OkButton.Click += OkButton_Click;
            Form.Data.ValueChanged += OnDataValueChanged;
            Form.AllenamentoLabel.Text = "Allenamento Programmato";

            OnDataValueChanged(this, EventArgs.Empty);
        }

        private void OnDataValueChanged(object sender, EventArgs e)
        {
            InizializeSchedeCombo(Form.Data.Value);
        }

        private Seduta Seduta
        {
            get
            {
                _seduta = (Seduta)_control.ComboSedute.SelectedItem;
                return _seduta;
            }
        }

        private void InizializeSchedeCombo(DateTime value)
        {
            _schede = new List<Scheda>();
            foreach (Scheda scheda in GestoreSchede.GetInstance().GetSchedeValide(value))
                _schede.Add(scheda);

            _control.ComboSchede.DataSource = _schede;
            _control.ComboSchede.SelectedIndexChanged += SelectedSchedaCombo;
            SelectedSchedaCombo(this, EventArgs.Empty);
        }

        private void InizializeSeduteCombo()
        {
            if (_control.ComboSchede.SelectedItem != null)
            {
                Scheda scheda = (Scheda)_control.ComboSchede.SelectedItem;
                _control.ComboSedute.DataSource = scheda.Sedute;
            }
            else
            {
                _control.ComboSedute.DataSource = new List<Seduta>();

            }
        }

        private void SelectedSchedaCombo(object sender, EventArgs e)
        {
            InizializeSeduteCombo();
        }

        private void OnAggiungiEsercizioButton(object sender, EventArgs e)
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
                    
                    Esercizio es = presenter.GetEsercizio();
                    if(es == null)
                    {
                        string messageBoxText = "Non è possibile svolgere solo alcuni esercizi di un circuito. Devi svolgere l'intero circuito per poterlo inserire in un allenamento!";
                        string caption = "Errore";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBoxIcon icon = MessageBoxIcon.Warning;

                        MessageBox.Show(messageBoxText, caption, buttons, icon);
                        return;
                    }
                    foreach(EsercizioSvolto ev in EserciziSvolti)
                    {
                        if (ev.Esercizio.Equals(es))
                        {
                            string messageBoxText = "Non è possibile aggiungere un esercizio più volte nello stesso allenamento";
                            string caption = "Errore";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Warning;

                            MessageBox.Show(messageBoxText, caption, buttons, icon);
                            return;
                        }
                    }
                    SvolgiVisitor sv = new SvolgiVisitor();
                    es.Accept(sv);
                    EsercizioSvolto eSvolto = sv.EsercizioSvolto;
                    EserciziSvolti.Add(eSvolto);
                    TreeViewPresenter.VisualizzaEserciziSvolti(EserciziSvolti.ToArray());
                   
                }
               
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime data = Form.Data.Value;
            AllenamentoProgrammato allenamento;
            try
            {
                allenamento = new AllenamentoProgrammato(data, EserciziSvolti.ToArray(), _seduta);
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
            Form.Close();
        }
    }
}
