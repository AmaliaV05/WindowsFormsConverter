using System.Windows.Forms;

namespace WindowsFormsConverter.Common
{
    public static class Alert
    {
        public static void ShowValidationError(string message)
        {
            MessageBox.Show(
                message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
    }
}
