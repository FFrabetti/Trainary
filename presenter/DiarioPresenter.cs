using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Trainary.model;
using Trainary.model.filtri;
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

        private IEnumerable<Allenamento> _listaAllenamenti = new List<Allenamento>();
        private StringBuilder _currentFiltriLabel = new StringBuilder();

        public DiarioPresenter (DiarioControl diarioControl)
        {
            _presenters = new List<FiltroPresenter>();
            _diarioControl = diarioControl;

            ResetListView();
            Inizialize();
            InizializeComboBox();

            diarioControl.OkButton.Click += _okButton_Click;
            diarioControl.AnnullaButton.Click += _annullaButton_Click;
        }

        private void InizializeListView(IEnumerable<Allenamento> listaAllenamenti)
        {
            _diarioControl.ListView.Items.Clear();
            foreach(Allenamento a in listaAllenamenti)
            {
                ListViewItem item = new ListViewItem(ToStringDate(a.Data));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(null, a.ToString()));
                _diarioControl.ListView.Items.Add(item);
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

        private void _okButton_Click(object sender, EventArgs e)
        {
            _currentFiltroPresenter = (FiltroPresenter)_diarioControl.ComboBox.SelectedItem;

            IFiltroAllenamenti filtroAllenamenti = _currentFiltroPresenter.NewFiltro;
            object opzione = _currentFiltroPresenter.GetOpzione();

            _listaAllenamenti = filtroAllenamenti.Filtra(_listaAllenamenti, opzione);
            InizializeListView(_listaAllenamenti);

            SetInfoLabel(filtroAllenamenti);
            SetLabelFiltri(_currentFiltriLabel.ToString());
        }

        private void SetInfoLabel(IFiltroAllenamenti filtroAllenamenti)
        {
            if (_currentFiltriLabel.Length == 0)
            {
                _currentFiltriLabel.Append("Filtri applicati: ");
                _currentFiltriLabel.Append(LabelAttribute(filtroAllenamenti));
            }

            else if (_currentFiltriLabel.Length > 0
                && !_currentFiltriLabel.ToString().Contains(LabelAttribute(filtroAllenamenti)))
            {
                _currentFiltriLabel.Append(", ");
                _currentFiltriLabel.Append(LabelAttribute(filtroAllenamenti));
            }
        }

        private string LabelAttribute(IFiltroAllenamenti filtroAllenamenti)
        {
            return LabelExtensions.GetLabelAttribute(filtroAllenamenti).ToLower();
        }

        private void SetLabelFiltri(string label)
        {
            _diarioControl.FiltriLabel.Text = label;
        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
            ResetListView();
            ResetLabelFiltri();
        }

        private void ResetLabelFiltri()
        {
            _currentFiltriLabel.Clear();
            SetLabelFiltri(_currentFiltriLabel.ToString());
        }

        private void ResetListView()
        {
            _listaAllenamenti = Diario.GetInstance().Allenamenti;
            InizializeListView(_listaAllenamenti);
        }

        private void _listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
