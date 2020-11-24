using System.Drawing;

namespace Vip.Notification
{
    public class Alert
    {
        #region Properties

        private static readonly int IntervalDefault = 1850;

        #endregion

        #region Sucess

        public static void ShowSuccess(string message)
        {
            ShowSuccess(message, IntervalDefault);
        }

        public static void ShowSuccess(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Sucess, interval);
        }

        #endregion

        #region Information

        public static void ShowInformation(string message)
        {
            ShowInformation(message, IntervalDefault);
        }

        public static void ShowInformation(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Information, interval);
        }

        #endregion

        #region Warning

        public static void ShowWarning(string message)
        {
            ShowWarning(message, IntervalDefault);
        }

        public static void ShowWarning(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Warning, interval);
        }

        #endregion

        #region Error

        public static void ShowError(string message)
        {
            ShowError(message, IntervalDefault);
        }

        public static void ShowError(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Error, interval);
        }

        #endregion

        #region Custom

        public static void ShowCustom(string message, Image image = null, Color color = default)
        {
            ShowCustom(message, IntervalDefault, image, color);
        }

        public static void ShowCustom(string message, int interval, Image image = null, Color color = default)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Custom, interval, image, color == default ? Color.FromArgb(83, 92, 104) : color);
        }

        #endregion
    }
}