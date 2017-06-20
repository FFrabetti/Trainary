using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.Presentation;
using Trainary.presenter.attributi;
using Trainary.view;

namespace Trainary.presenter
{
    class InserisciAllenamentoExtraPresenter : InserisciAllenamentoPresenter
    {
        private NomeUserControl _control = new NomeUserControl();

        public InserisciAllenamentoExtraPresenter(AllenamentoForm form)
            : base(form)
        {
            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioButton;
            Form.AggiungiCircuitoButton.Click += OnAggiungiCircuitoButton;
            Form.Buttons.OkButton.Click += OkButton_Click;
            Form.Panel.Controls.Add(_control);
            Form.AllenamentoLabel.Text = "Allenamento Extra";

            Application.Idle += OnIdle;
        }


        private void OnIdle(object sender, EventArgs e)
        {
            Form.AggiungiCircuitoButton.Enabled = EserciziSvolti.Count >= 2;
        }

        private void OnAggiungiCircuitoButton(object sender, EventArgs e)
        {
            IList<Esercizio> esercizi = new List<Esercizio>();
            foreach(EsercizioSvolto es in EserciziSvolti)
            {
                esercizi.Add(es.Esercizio);
            }
            SvolgiVisitor sv = new SvolgiVisitor();

            using (NewCircuitoForm form = new NewCircuitoForm())
            {
                NewCircuitoPresenter presenter = new NewCircuitoPresenter(form,esercizi);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Circuito circuito = presenter.NewCircuito();
                    foreach (EsercizioSvolto ev in EserciziSvolti)
                    {
                        if (ev.Esercizio.Equals(circuito))
                        {
                            string messageBoxText = "Non è possibile aggiungere un esercizio più volte nello stesso allenamento";
                            string caption = "Errore";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBoxIcon icon = MessageBoxIcon.Warning;

                            MessageBox.Show(messageBoxText, caption, buttons, icon);
                            return;
                        }
                    }
                    foreach (Esercizio es in circuito.Esercizi)
                    {
                        esercizi.Remove(es);
                    }
                    circuito.Accept(sv);
                    CircuitoSvolto cSvolto = (CircuitoSvolto)sv.EsercizioSvolto;
                    EserciziSvolti.Clear();
                    foreach(Esercizio es in esercizi)
                    {
                        es.Accept(sv);
                        EsercizioSvolto eSvolto = sv.EsercizioSvolto;
                        EserciziSvolti.Add(eSvolto);
                    }
                    
                    //foreach(EsercizioSvolto es in cSvolto.SottoEserciziSvolti)
                    //{
                    //    _eserciziSvolti.Remove(es);
                    //}
                    EserciziSvolti.Add(cSvolto);
                    AggiornaTreeView();
                }
            }
            
        }

        private void OnAggiungiEsercizioButton(object sender, EventArgs e)
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

       

        private void OkButton_Click(object sender, EventArgs e)
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
    }
}
