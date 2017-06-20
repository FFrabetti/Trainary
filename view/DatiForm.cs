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
    public partial class DatiForm : Form
    {
        public DatiForm()
        {
            InitializeComponent();
        }

        public AttributiControl AttributiControl
        {
            get { return _attributiControl; }
        }

        public Label ListLabel
        {
            get { return _attributiControl.ListLabel; }
        }

    }
}
