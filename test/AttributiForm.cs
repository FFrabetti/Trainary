using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trainary.presenter;

namespace Trainary.test
{
    public partial class AttributiForm : Form
    {
        public AttributiForm()
        {
            InitializeComponent();
            AttributiPresenter presenter = new AttributiPresenter(_attributiControl);
        }

    }
}
