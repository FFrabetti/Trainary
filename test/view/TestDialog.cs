using System.Windows.Forms;

namespace Trainary.test.view
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
