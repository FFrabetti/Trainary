using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.filtri;
using Trainary.Presentation;
using Trainary.presenter.filtri;
using Trainary.utils;
using Trainary.view;

namespace Trainary.presenter
{
    public class DiarioPresenter
    {
        private List<FiltroPresenter> _presenters;
        private DiarioControl _diarioControl;
        private FiltroPresenter _currentFiltroPresenter;

        private IFiltroAllenamenti _lastFiltro;

        object _lastOpzione;
        private IEnumerable<Allenamento> _listaAllenamentiPrec = new List<Allenamento>();
        private IEnumerable<Allenamento> _listaAllenamenti = new List<Allenamento>();
        private Dictionary<object, IFiltroAllenamenti> _filtriApplicati = new Dictionary<object, IFiltroAllenamenti>();

        public DiarioPresenter (DiarioControl diarioControl)
        {
            _presenters = new List<FiltroPresenter>();
            _diarioControl = diarioControl;

            ResetListView();
            Inizialize();
            InizializeComboBox();
            ResetFilterHistory();

            Diario.GetInstance().DiarioChanged += OnDiarioChanged;

            diarioControl.ApplicaFiltroButton.Click += OnApplicaFiltroButton;
            diarioControl.AnnullaButton.Click += _annullaButton_Click;
            diarioControl.ListBox.SelectedIndexChanged += _listView_SelectedIndexChanged;
            Application.Idle += AbilitaBottoni;
        }

        private void OnDiarioChanged(object sender, EventArgs e)
        {
            _listaAllenamenti = Diario.GetInstance().Allenamenti;
            foreach (object opzione in _filtriApplicati.Keys)
            {
                _listaAllenamenti = _filtriApplicati[opzione].Filtra(_listaAllenamenti,opzione); 
            }
            InizializeListView(_listaAllenamenti);
        }

        private void AbilitaBottoni(object sender, EventArgs e)
        {
            _diarioControl.AnnullaButton.Enabled = _lastFiltro != null;
        }

        private void InizializeListView(IEnumerable<Allenamento> listaAllenamenti)
        {
            IEnumerable<Allenamento> allenamentiOrdinati = listaAllenamenti.OrderBy(a => a.Data);
            _diarioControl.ListBox.Items.Clear();
            //_diarioControl.ListBox.DataSource = listaAllenamenti;
            //_diarioControl.ListView.Items.Clear();
            foreach (Allenamento a in allenamentiOrdinati)
            {
                //    //ListViewItem item = new ListViewItem(ToStringDate(a.Data));
                //    //item.SubItems.Add(new ListViewItem.ListViewSubItem(null, a.ToString()));
                //    //item.SubItems.Add(new ListViewItem(a));
                //    //_diarioControl.ListView.Items.Add(item);
                _diarioControl.ListBox.Items.Add(a);
            }
        }

        private string ToStringDate(DateTime dateTime)
        {
            return dateTime.ToString("d");
        }

        private void Inizialize()
        {
            FiltroPresenter presenter = null;
            ConstructorInfo constructor = null;

            foreach (Type tipo in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (
                    tipo.IsSubclassOf(typeof(FiltroPresenter)) &&
                    !tipo.IsAbstract &&
                    (constructor = tipo.GetConstructor(Type.EmptyTypes)) != null
                )
                {
                    try
                    {
                        presenter = (FiltroPresenter)constructor.Invoke(null);
                        if (presenter != null)
                            _presenters.Add(presenter);
                    }
                    catch
                    { }
                }
            }
        }

        private void InizializeComboBox()
        {
            _diarioControl.ComboBox.DataSource = _presenters;
            _diarioControl.ComboBox.DisplayMember = "LabelAttribute";

            SelectedPresenter(_diarioControl.ComboBox);

            _diarioControl.ComboBox.SelectedValueChanged += _comboBox_SelectedIndexChanged;
        }

        private void SelectedPresenter(ComboBox combo)
        {
            _currentFiltroPresenter = (FiltroPresenter)combo.SelectedItem;

            _diarioControl.Panel.Controls.Clear();
            _currentFiltroPresenter.DrawControls(_diarioControl.Panel);
        }

        private void _comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPresenter((ComboBox)sender);
        }

        private void OnApplicaFiltroButton(object sender, EventArgs e)
        {
            _currentFiltroPresenter = (FiltroPresenter)_diarioControl.ComboBox.SelectedItem;

            IFiltroAllenamenti filtroAllenamenti = _currentFiltroPresenter.NewFiltro;
            object opzione = _currentFiltroPresenter.GetOpzione();
           
            IEnumerable<Allenamento> allenamentiDaFiltrare;
            try
            {
                if (filtroAllenamenti == _lastFiltro)
                {
                    // se è esattamente lo stesso (quindi anche stessa opzione)
                    // non faccio niente
                    if (opzione == _lastOpzione)
                        return;

                    // altrimenti applico il filtro alla vecchia selezione
                    _filtriApplicati.Remove(_lastOpzione);
                    _filtriApplicati.Add(opzione, filtroAllenamenti);
                    allenamentiDaFiltrare = _listaAllenamentiPrec;
                }
                else
                {
                    // filtro diverso:
                    //  applicarlo alla selezione corrente
                    SetInfoLabel(filtroAllenamenti);
                    allenamentiDaFiltrare = _listaAllenamenti;

                    _listaAllenamentiPrec = _listaAllenamenti;
                    if(!_filtriApplicati.ContainsKey(opzione))
                    _filtriApplicati.Add(opzione, filtroAllenamenti);
                }

                _lastOpzione = opzione;
                _lastFiltro = filtroAllenamenti;


                _listaAllenamenti = filtroAllenamenti.Filtra(allenamentiDaFiltrare, opzione);

               
            }
            catch(Exception)
            {
                string messageBoxText = "Impossibile applicare l'opzione di filtraggio richiesta";
                string caption = "Errore";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(messageBoxText, caption, buttons, icon);
                _filtriApplicati.Remove(opzione);
                ResetInfoLabel();
                
                return;
            }
            InizializeListView(_listaAllenamenti);
        }

        private void SetInfoLabel(IFiltroAllenamenti filtroAllenamenti)
        {
            if (_lastFiltro != null)
                _diarioControl.FiltriLabel.Text += ", ";

            _diarioControl.FiltriLabel.Text += filtroAllenamenti.GetLabelAttribute().ToLower();
       }
        private void ResetInfoLabel()
        {
            _diarioControl.FiltriLabel.Text = "Filtri applicati: ";
            foreach(IFiltroAllenamenti filtro in _filtriApplicati.Values)
            {
                _diarioControl.FiltriLabel.Text += filtro.GetLabelAttribute().ToLower();
                if(!filtro.Equals(_filtriApplicati.Values.Last()))
                 _diarioControl.FiltriLabel.Text += ", ";
            }
        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
            ResetListView();
            ResetFilterHistory();
        }

        private void ResetFilterHistory()
        {
            _diarioControl.FiltriLabel.Text = "Filtri applicati: ";
            _lastFiltro = null;
            _lastOpzione = null;
            _listaAllenamentiPrec = null;
            _filtriApplicati.Clear();
        }

        private void ResetListView()
        {
            _listaAllenamenti = Diario.GetInstance().Allenamenti;
            InizializeListView(_listaAllenamenti);
        }

        private void _listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            Allenamento allenamento = (Allenamento)listBox.SelectedItem;
            AllenamentoForm form = new AllenamentoForm();
            if (allenamento is AllenamentoExtra)
            {
                
                VisualizzaAllenamentoExtraPresenter presenter = new VisualizzaAllenamentoExtraPresenter(form, allenamento as AllenamentoExtra);
                
            }
            else
            {
                VisualizzaAllenamentoProgrammatoPresenter presenter = new VisualizzaAllenamentoProgrammatoPresenter(form, allenamento as AllenamentoProgrammato);
            }
            form.Show();
        }
    }
}
