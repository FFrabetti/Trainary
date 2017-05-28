using System.Windows.Forms;
using Trainary.presenter;

namespace Trainary.test.view
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
