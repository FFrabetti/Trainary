using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Trainary.model;
using Trainary.Presentation;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter
{
    public class InserisciAllenamentoExtraPresenter : InserisciAllenamentoPresenter
    {
        private NomeUserControl _control = new NomeUserControl();

        public InserisciAllenamentoExtraPresenter(AllenamentoForm form)
            : base(form)
        {
            Form.AllenamentoLabel.Text = "Allenamento Extra";
            Form.Panel.Controls.Add(_control);

            Form.AnnullaSelezioneButton.Visible = false;

            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioClick;
            Form.AggiungiCircuitoButton.Click += OnAggiungiCircuitoClick;
            Form.Buttons.OkButton.Click += OkButtonClick;
        }

        private void OnAggiungiCircuitoClick(object sender, EventArgs e)
        {
            IList<Esercizio> esercizi = new List<Esercizio>();
            foreach(EsercizioSvolto es in EserciziSvolti)
                esercizi.Add(es.Esercizio);

            using (NewCircuitoForm form = new NewCircuitoForm())
            {
                NewCircuitoPresenter presenter = new NewCircuitoPresenter(form, esercizi);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Circuito circuito = presenter.NewCircuito();

                    if (EserciziSvolti.Any(esSvolto => esSvolto.Esercizio.Equals(circuito)))
                        MessageBoxUtils.DisplayError("Circuito già inserito come svolto nell'allenamento");

                    SvolgiVisitor sv = new SvolgiVisitor();
                    circuito.Accept(sv);
                    CircuitoSvolto cSvolto = (CircuitoSvolto)sv.EsercizioSvolto;

                    // Devo rimuovere dagli esercizi svolti quelli che ho usato per creare il circuito
                    foreach(EsercizioSvolto es in EserciziSvolti)
                    {
                        if (circuito.Esercizi.Contains(es.Esercizio))
                            EserciziSvolti.Remove(es);
                    }

                    EserciziSvolti.Add(cSvolto);
                    AggiornaTreeView();
                }
            }
            
        }

        private void OnAggiungiEsercizioClick(object sender, EventArgs e)
        {
           
            SvolgiVisitor sv = new SvolgiVisitor();
          
            Esercizio esercizio;
            using (NewEsercizioForm newEsForm = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(newEsForm);

                if (newEsForm.ShowDialog() == DialogResult.OK)
                {
                    esercizio = presenter.NewEsercizio();
                    foreach (EsercizioSvolto svolto in EserciziSvolti)
                    {
                        if (svolto.Esercizio.Equals(esercizio))
                        {
                            string messageBoxText = "Non è possibile aggiungere un esercizio più volte nello stesso allenamento";
                            string caption = "Errore";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Warning;

                            MessageBox.Show(messageBoxText, caption, buttons, icon);
                            return;
                        }
                    }
                    esercizio.Accept(sv);
                    EsercizioSvolto ev = sv.EsercizioSvolto;
                    EserciziSvolti.Add(ev);
                    AggiornaTreeView();
                }
               
            }
          
            
        }

       

        private void OkButtonClick(object sender, EventArgs e)
        {
            DateTime data = Form.Data.Value;
            string nome = _control.Nome.Text;
            AllenamentoExtra allenamentoExtra;
            try
            {
                allenamentoExtra = new AllenamentoExtra(data, EserciziSvolti.ToArray(), nome);
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
            Form.Close();
        }
        protected override void OnAnnullaSelezioneButtonClick(object sender, EventArgs e)
        {
            base.OnAnnullaSelezioneButtonClick(sender, e);
            _control.Nome.Text = String.Empty;
        }
        protected override void OnApplicationIdle(object sender, EventArgs e)
        {
            base.OnApplicationIdle(sender, e);
            Form.AnnullaSelezioneButton.Enabled = Form.Data.Value.Date != DateTime.Today.Date || EserciziSvolti.Count > 0 || _control.Nome.Text != String.Empty;

        }
    }
}
