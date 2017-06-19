using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.attributi;
using Trainary.Presentation;
using Trainary.view;

namespace Trainary.presenter
{
    class InserisciAllenamentoExtraPresenter
    {
        private AllenamentoForm _form;
        private TreeViewPresenter _presenter;
        private IList<EsercizioSvolto> _eserciziSvolti = new List<EsercizioSvolto>();
        private NomeUserControl _control = new NomeUserControl();
        public InserisciAllenamentoExtraPresenter(AllenamentoForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;
            _presenter = new TreeViewPresenter(_form.TreeView);
            _form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioButton;
            _form.AggiungiCircuitoButton.Click += OnAggiungiCircuitoButton;
            _form.Buttons.OkButton.Click += OkButton_Click;
            _form.Panel.Controls.Add(_control);
            _form.AllenamentoLabel.Text = "Allenamento Extra";
            Application.Idle += OnIdle;
            _form.TreeView.AfterSelect += OnSelectedNode;
            _form.AggiungiDatiButton.Click += OnAggiungiDatiButton;
        }

        private void OnAggiungiDatiButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnSelectedNode(object sender, TreeViewEventArgs e)
        {
            _form.AggiungiDatiButton.Enabled = _form.TreeView.SelectedNode.Tag != null;
           
        }

        private void OnIdle(object sender, EventArgs e)
        {
            if (_form.TreeView.SelectedNode == null )
                _form.AggiungiDatiButton.Enabled = false;
            _form.AggiungiCircuitoButton.Enabled = _eserciziSvolti.Count >= 2;
        }

        private void OnAggiungiCircuitoButton(object sender, EventArgs e)
        {
            IList<Esercizio> esercizi = new List<Esercizio>();
            foreach(EsercizioSvolto es in _eserciziSvolti)
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
                    foreach (EsercizioSvolto ev in _eserciziSvolti)
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
                    _eserciziSvolti.Clear();
                    foreach(Esercizio es in esercizi)
                    {
                        es.Accept(sv);
                        EsercizioSvolto eSvolto = sv.EsercizioSvolto;
                        _eserciziSvolti.Add(eSvolto);
                    }
                    
                    //foreach(EsercizioSvolto es in cSvolto.SottoEserciziSvolti)
                    //{
                    //    _eserciziSvolti.Remove(es);
                    //}
                    _eserciziSvolti.Add(cSvolto);
                    
                }
            }
            _presenter.VisualizzaEserciziSvolti(_eserciziSvolti.ToArray());
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
                    foreach (EsercizioSvolto svolto in _eserciziSvolti)
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
                    _eserciziSvolti.Add(ev);
                    _presenter.VisualizzaEserciziSvolti(_eserciziSvolti.ToArray());
                }
               
            }
          
            
        }

       

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime data = _form.Data.Value;
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
