using System.Windows.Forms;

namespace Trainary.test.view
{
    interface IControlPresenter
    {
        Control UserControl { get; }
        object Item { get; }
    }
}
