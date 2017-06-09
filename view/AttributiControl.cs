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
    public partial class AttributiControl : UserControl
    {
        public AttributiControl()
        {
            InitializeComponent();
        }

        public Label TitleLabel
        {
            get { return _titleLabel; }
        }

        public NewAttributoControl NewAttributoControl
        {
            get { return _newAttributoControl; }
        }

        public ListBoxControl ListBoxControl
        {
            get { return _listBoxControl; }
        }

        public Button AddButton
        {
            get { return _listBoxControl.AddButton; }
        }

        public Button RemoveButton
        {
            get { return _listBoxControl.RemoveButton; }
        }

        public Label ListLabel
        {
            get { return _listBoxControl.TitleLabel; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return _errorProvider; }
        }
    }
}
