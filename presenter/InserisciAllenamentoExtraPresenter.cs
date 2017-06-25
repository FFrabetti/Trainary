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

            Form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioClick;
            Form.AggiungiCircuitoButton.Click += OnAggiungiCircuitoClick;
            Form.Buttons.OkButton.Click += OkButtonClick;
        }

        private void OnAggiungiCircuitoClick(object sender, EventArgs e)
        {
            IList<Esercizio> esDisponibili = new List<Esercizio>();
            foreach(EsercizioSvolto es in EserciziSvolti)
                esDisponibili.Add(es.Esercizio);

            using (NewCircuitoForm form = new NewCircuitoForm())
            {
                NewCircuitoPresenter presenter = new NewCircuitoPresenter(form, esDisponibili);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Circuito circuito = presenter.NewCircuito();

                    if (EserciziSvolti.Any(esSvolto => esSvolto.Esercizio.Equals(circuito)))
                        MessageBoxUtils.DisplayError("Circuito già inserito come svolto nell'allenamento");

                    SvolgiVisitor sv = new SvolgiVisitor();
                    circuito.Accept(sv);
                    CircuitoSvolto cSvolto = (CircuitoSvolto)sv.EsercizioSvolto;

                    // Devo rimuovere dagli esercizi svolti quelli che ho usato per creare il circuito
                    // Non posso modificare direttamente la lista mentre la scorro con foreach
                    List<EsercizioSvolto> nuovaListaEsSvolti = new List<EsercizioSvolto>();
                    foreach(EsercizioSvolto es in EserciziSvolti)
                    {
                        if (!circuito.Esercizi.Contains(es.Esercizio))
                            nuovaListaEsSvolti.Add(es);
                    }

                    nuovaListaEsSvolti.Add(cSvolto);
                    EserciziSvolti.Clear();
                    EserciziSvolti.AddRange(nuovaListaEsSvolti);

                    AggiornaTreeView();
                }
            }
        }

        private void OnAggiungiEsercizioClick(object sender, EventArgs e)
        {
            using (NewEsercizioForm newEsForm = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(newEsForm);

                if (newEsForm.ShowDialog() == DialogResult.OK)
                {
                    Esercizio esercizio = presenter.NewEsercizio();

                    SvolgiVisitor sv = new SvolgiVisitor();
                    esercizio.Accept(sv);
                    EsercizioSvolto ev = sv.EsercizioSvolto;
                    EserciziSvolti.Add(ev);
                    AggiornaTreeView();
                }
            }
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            try
            {
                DateTime data = Form.Data.Value;
                string nome = _control.Nome.Text;
                Allenamento allenamentoExtra = new AllenamentoExtra(data, EserciziSvolti.ToArray(), nome);
                Diario.GetInstance().Allenamenti.Add(allenamentoExtra);
                Form.Close();
            }
            catch (Exception ex)
            {
                MessageBoxUtils.DisplayError(ex.Message);
            }
        }
    }
}
