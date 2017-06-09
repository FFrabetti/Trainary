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
    public partial class NewAttributoControl : UserControl
    {
        public NewAttributoControl()
        {
            InitializeComponent();
        }

        public Label NomeLabel
        {
            get { return _nameLabel; }
        }

        public Label TipoLabel
        {
            get { return _typeLabel; }
        }

        public Label ValoreLabel
        {
            get { return _valueLabel; }
        }

        public TextBox NomeTextBox
        {
            get { return _nameTextBox; }
        }

        public ComboBox TipoComboBox
        {
            get { return _typeComboBox; }
        }

        public Panel QuantitaPanel
        {
            get { return _valuePanel; }
        }

    }
}
