using System.Windows.Forms;

namespace Trainary.utils
{
    public static class MessageBoxUtils
    {

        public static void DisplayError(string message, string title="Errore")
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            MessageBox.Show(message, title, buttons, icon);
        }

        public static DialogResult AskForConfirmation(string message, string title="Conferma")
        {
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            return MessageBox.Show(message, title, buttons, icon);
        }
    }
}
