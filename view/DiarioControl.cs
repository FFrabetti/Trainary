using System;
using System.Windows.Forms;
using Trainary.presenter;

namespace Trainary.view
{
    public partial class DiarioControl : UserControl
    {
        public DiarioControl()
        {
            InitializeComponent();
            DiarioPresenter dp = new DiarioPresenter(this);
        }

        public Panel Panel
        {
            get
            {
                return _panel;
            }
        }

        public ComboBox ComboBox
        {
            get
            {
                return _comboBox;
            }
        }

        public ListBox ListBox
        {
            get
            {
                return listBox2;
            }
        }

        public Button OkButton
        {
            get
            {
                return _okButton;
            }
        }

        public Button AnnullaButton
        {
            get
            {
                return _annullaButton;
            }
        }

        public Label FiltriLabel
        {
            get
            {
                return _filtriLabel;
            }
        }

        private void _comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void _okButton_Click(object sender, EventArgs e)
        {

        }

        private void _annullaButton_Click(object sender, EventArgs e)
        {

        }

        private void _listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}