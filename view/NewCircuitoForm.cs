using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainary.view
{
    public partial class NewCircuitoForm : Form
    {
        public NewCircuitoForm()
        {
            InitializeComponent();

            HideButtons();
        }

        private void HideButtons()
        {
            _listBoxControl.AddButton.Visible = false;
            _listBoxControl.RemoveButton.Visible = false;
        }

        public AttributiControl AttributiControl
        {
            get { return _attributiControl; }
        }

        public ListBoxControl EserciziListBoxControl
        {
            get { return _listBoxControl; }
        }

        public ListBox EserciziListBox
        {
            get { return _listBoxControl.ListBox; }
        }

        public Label EserciziListLabel
        {
            get { return _listBoxControl.TitleLabel; }
        }

        public Button OkButton
        {
            get { return _dialogButtonsControl.OkButton; }
        }
    }
}
