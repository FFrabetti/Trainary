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
        public TreeView EserciziTreeView
        {
            get
            {
                return treeView1;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
