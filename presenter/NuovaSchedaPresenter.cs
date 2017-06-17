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
    class NuovaSchedaPresenter
    {
        private SchedaForm _schedaForm;
        private ComboBox _comboBox = new ComboBox();
        private IList<Seduta> _sedute = new List<Seduta>();
        private Scheda _scheda = null;
        public NuovaSchedaPresenter(SchedaForm schedaForm)
        {
            if (schedaForm == null)
                throw new ArgumentNullException("scheda form");
            _schedaForm = schedaForm;
            InizializeScopoCombo();
            _schedaForm.Buttons.OkButton.Click += OKButtonClick;
            _schedaForm.NuovaSedutaButton.Click += _nuovaSedutaButton_Click;
        }

        private void InizializeScopoCombo()
        {
            this._comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(19, 10);
            this._comboBox.Size = new System.Drawing.Size(154, 21);
            this._comboBox.TabIndex = 11;
            _comboBox.DataSource = Enum.GetValues(typeof(ScopoDellaScheda));
            _schedaForm.Scopo.Controls.Add(_comboBox);
        }
        private Scheda NuovaScheda()
        {
            Periodo periodo;
            
            string nome = _schedaForm.Nome.Text;
            ScopoDellaScheda scopo = (ScopoDellaScheda)_comboBox.SelectedItem;
            string decrizione = _schedaForm.Descrizione.Text;
            DateTime dataInizio = _schedaForm.DataInizio.Value;

            if (_schedaForm.DataFineRadioButton.Checked)
            {
                DateTime dataFine = _schedaForm.DataFine.Value;
                periodo = new Periodo(dataInizio, dataFine);
            }
            else
            {
                string durata = _schedaForm.Durata.Text;
                int giorni = 0;
                try
                {
                    giorni = Int32.Parse(durata);
                }
                catch (Exception)
                {
                    // mostrare errore
                }
                TimeSpan timeSpanDurata = new TimeSpan(giorni, 0, 0, 0);
                periodo = new Periodo(dataInizio, timeSpanDurata);
            }
            return new Scheda(nome, scopo, decrizione, periodo);
        }
        private void OKButtonClick(object sender, EventArgs e)
        {
            GestoreSchede.GetInstance().GetSchede().Add(_scheda);
            _schedaForm.Close();
        }

        private void _nuovaSedutaButton_Click(object sender, EventArgs e)
        {
            if (_scheda == null)
            {
                try
                {
                    _scheda = NuovaScheda();
                }
                catch (Exception exception)
                {
                    string messageBoxText = exception.Message;
                    string caption = "Errore";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Warning;

                    MessageBox.Show(messageBoxText, caption, buttons, icon);
                    return;

                }
            }

            Seduta seduta = _scheda.AggiungiSeduta(new List<Esercizio>());
            VisualizzaSeduta(seduta);

            using (NewEsercizioForm form = new NewEsercizioForm())
            {
                NewEsercizioPresenter presenter = new NewEsercizioPresenter(form);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    seduta.Esercizi.Add(presenter.NewEsercizio());
                    // evento per aggiornare la tree view
                }
            }
        }

        private void VisualizzaSeduta(Seduta seduta)
        {
            TreeNode node = new TreeNode(seduta.ToString());
            node.Tag = seduta;
            
            foreach(Esercizio es in seduta.Esercizi)
            {
                TreeNode nodeEs = new TreeNode(es.ToString());
                nodeEs.Tag = es;
                node.Nodes.Add(nodeEs);
            }
            _schedaForm.TreeView.Nodes.Add(node);
        }
    }
    }

