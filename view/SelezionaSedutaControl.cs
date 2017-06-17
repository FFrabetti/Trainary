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
    public partial class SelezionaSedutaControl : UserControl
    {
        public SelezionaSedutaControl()
        {
            InitializeComponent();
        }
        public ComboBox ComboSchede
        {
            get
            {
                return comboBox1;
            }
        }
        public ComboBox ComboSedute
        {
            get
            {
                return comboBox2;
            }
        }
    }
}
