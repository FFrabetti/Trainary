using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Trainary.model;
using Trainary.view;

namespace Trainary.presenter
{
    public class DiarioPresenter
    {
        private List<FiltroPresenter> _presenters;
        private FormDiario _formDiario;
        private FiltroPresenter _currentFiltroPresenter;

        private IEnumerable<Allenamento> _listaAllenamenti = new List<Allenamento>();

        public DiarioPresenter (FormDiario formDiario)
        {
            _presenters = new List<FiltroPresenter>();
            _formDiario = formDiario;
            ResetListView();

            Inizialize();
            InizializeComboBox();
          
            formDiario.Ok_button.Click += _okButton_Click;
            formDiario.AnnullaButton_button.Click += _annullaButton_Click;
        }

        private void InizializeListView(IEnumerable<Allenamento> listaAllenamenti)
        {
            _formDiario.ListView.Items.Clear();
            foreach(Allenamento a in listaAllenamenti)
            {
                ListViewItem item = new ListViewItem(ToStringDate(a.Data));
                _formDiario.ListView.Items.Add(item);
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
                    catch (Exception e)
                    {
                        // skip
                    }
                }
            }
        }

        private void InizializeComboBox()
        {
            _formDiario.ComboBox.DataSource = _presenters;
            _formDiario.ComboBox.DisplayMember = "LabelAttribute";

            SelectedPresenter(_formDiario.ComboBox);

            _formDiario.ComboBox.SelectedValueChanged += _comboBox_SelectedIndexChanged;
        }

        private void SelectedPresenter(ComboBox combo)
        {
            _currentFiltroPresenter = (FiltroPresenter)combo.SelectedItem;

            _formDiario.Panel.Controls.Clear();
            _currentFiltroPresenter.DrawControls(_formDiario.Panel);
        }

        private void _comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedPresenter((ComboBox)sender);
        }

        private void _okButton_Click(object sender, EventArgs e)
        {
            _currentFiltroPresenter = (FiltroPresenter)_formDiario.ComboBox.SelectedItem;

            IFiltroAllenamenti filtroAllenamenti = _currentFiltroPresenter.NewFiltro;
            object opzione = _currentFiltroPresenter.GetOpzione();

            _listaAllenamenti = filtroAllenamenti.Filtra(_listaAllenamenti, opzione);
            InizializeListView(_listaAllenamenti);
        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {
            ResetListView();
        }

        private void ResetListView()
        {
            _listaAllenamenti = Diario.GetInstance().Allenamenti;
            InizializeListView(_listaAllenamenti);
        }

        private void _listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void SelectedListViewPresenter(ComboBox combo)
        //{
        //    _currentFiltroPresenter = (FiltroPresenter)combo.SelectedItem;

        //    _formDiario.Panel.Controls.Clear();
        //    _currentFiltroPresenter.DrawControls(_formDiario.Panel);
        //}

        //private void _comboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SelectedPresenter((ComboBox)sender);
        //}
    }
}
