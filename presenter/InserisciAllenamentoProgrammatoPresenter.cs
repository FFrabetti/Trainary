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
        private InserisciDataEserciziPresenter _presenter;
        private List<EsercizioSvolto> _eserciziSvolti = new List<EsercizioSvolto>();
        private List<Scheda> _schede;
        //private List<Seduta> _sedute = new List<Seduta>();
        private Seduta _seduta;
        public InserisciAllenamentoProgrammatoPresenter(AllenamentoForm form)
        {
            if (form == null)
                throw new ArgumentNullException("form");
            _form = form;
            _presenter = new InserisciDataEserciziPresenter(_form.TreeView);
            _form.Panel.Controls.Add(_control);
            _form.AggiungiEsercizioButton.Click += OnAggiungiEsercizioButton;
            _form.AggiungiCircuitoButton.Visible = false;
            _form.Buttons.OkButton.Click += OkButton_Click;
            _form.Data.ValueChanged += OnDataValueChanged;
            _form.AllenamentoLabel.Text = "Allenamento Programmato";
            _form.AggiungiDatiButton.Click += OnAggiungiDatiButton;
            Application.Idle += OnIdle;
            _form.TreeView.AfterSelect += OnSelectedNode;
            OnDataValueChanged(this, EventArgs.Empty);
        }

        private void OnIdle(object sender, EventArgs e)
        {
            if (_form.TreeView.SelectedNode == null)
                _form.AggiungiDatiButton.Enabled = false;
        }
        private void OnSelectedNode(object sender, TreeViewEventArgs e)
        {
            _form.AggiungiDatiButton.Enabled = _form.TreeView.SelectedNode.Tag != null;

        }

        private void OnAggiungiDatiButton(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnDataValueChanged(object sender, EventArgs e)
        {
            InizializeSchedeCombo(_form.Data.Value);
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
                    foreach(EsercizioSvolto ev in _eserciziSvolti)
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
                    _eserciziSvolti.Add(eSvolto);
                    _presenter.VisualizzaEserciziSvolti(_eserciziSvolti.ToArray());
                   
                }
               
            }
            
            

        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime data = _form.Data.Value;
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
