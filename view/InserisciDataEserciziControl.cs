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
    public partial class InserisciDataEserciziControl : UserControl
    {
        public InserisciDataEserciziControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public DateTimePicker Data
        {
            get
            {
                return dateTimePicker1;
            }
        }
        public ListBox EserciziListBox
        {
            get
            {
                return listBox1;
            }
        }
    }
}
