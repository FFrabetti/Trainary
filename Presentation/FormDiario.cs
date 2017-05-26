using System;
using System.Windows.Forms;

namespace Trainary
{
    public partial class FormDiario : Form
    {
        public FormDiario()
        {
            InitializeComponent();
            DiarioPresenter dp = new DiarioPresenter(_comboBox, FiltroFactory.GetNomeFiltri);
        }
    }
}
