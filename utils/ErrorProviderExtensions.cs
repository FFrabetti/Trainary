using System.Windows.Forms;

namespace Trainary.utils
{
    public static class ErrorProviderExtensions
    {

        public static void UnsetError(this ErrorProvider errorProvider, Control control)
        {
            errorProvider.SetError(control, null);
        }
    }
}
