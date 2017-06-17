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
    public partial class NomeUserControl : UserControl
    {
        public NomeUserControl()
        {
            InitializeComponent();
        }
        public TextBox Nome
        {
            get
            {
                return textBox3;
            }
        }
    }
}
