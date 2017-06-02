using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainary.view
{
    public partial class ListBoxControl : UserControl
    {
        public ListBoxControl()
        {
            InitializeComponent();
        }

        public Label TitleLabel
        {
            get { return _label; }
        }

        public Panel ButtonsPanel
        {
            get { return _buttonsPanel; }
        }

        public Button AddButton
        {
            get { return _addButton; }
        }

        public Button RemoveButton
        {
            get { return _removeButton; }
        }

        public ListBox ListBox
        {
            get { return _listBox; }
        }
    }
}
