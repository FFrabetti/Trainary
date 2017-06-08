using System.Windows.Forms;

namespace Trainary.view
{
    public partial class DialogButtonsControl : UserControl
    {
        public DialogButtonsControl()
        {
            InitializeComponent();
        }

        public Button OkButton
        {
            get { return _okButton; }
        }

        public Button CancelButton
        {
            get { return _cancelButton; }
        }
    }
}
