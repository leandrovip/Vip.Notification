using System.Drawing;

namespace Vip.Notification
{
    public class Alert
    {
        #region Static Methods

        public static void ShowSucess(string message)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Sucess);
        }

        public static void ShowInformation(string message)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Information);
        }

        public static void ShowWarning(string message)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Warning);
        }

        public static void ShowError(string message)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Error);
        }

        public static void ShowCustom(string message, Image image = null, Color color = default)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Custom, image, color == default ? Color.FromArgb(83, 92, 104) : color);
        }

        #endregion
    }
}