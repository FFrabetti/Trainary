using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trainary.test
{
    public partial class TestDialog : Form
    {
        public TestDialog()
        {
            InitializeComponent();
        }

        public void LoadControl(Control control)
        {
            _splitContainer.Panel1.Controls.Add(control);
        }
    }
}
