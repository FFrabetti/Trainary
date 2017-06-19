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
    public partial class GestioneSchedeControl : UserControl
    {
        public GestioneSchedeControl()
        {
            InitializeComponent();
        }
        public ListView ListView
        {
            get
            {
                return listView1;
            }
        }
        public Button AggiungiSedutaButton
        {
            get
            {
                return button1;
            }
        }
        public Button RimuoviSchedaButton
        {
            get
            {
                return _rimuoviSchedaButton;
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
