using System;
using System.Drawing;

namespace Vip.Notification
{
    public class Alert
    {
        #region Properties

        private static readonly int IntervalDefault = 1850;

        #endregion

        #region Sucess

        [Obsolete]
        public static void ShowSucess(string message)
        {
            ShowSucess(message, IntervalDefault);
        }

        [Obsolete]
        public static void ShowSucess(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Sucess, interval);
        }

        public static void ShowSucess(object sender, string message)
        {
            ShowSucess(sender, message, IntervalDefault);
        }

        public static void ShowSucess(object sender, string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(sender, message, AlertType.Sucess, interval);
        }

        #endregion

        #region Information

        [Obsolete]
        public static void ShowInformation(string message)
        {
            ShowInformation(message, IntervalDefault);
        }

        [Obsolete]
        public static void ShowInformation(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Information, interval);
        }

        public static void ShowInformation(object sender, string message)
        {
            ShowInformation(sender, message, IntervalDefault);
        }

        public static void ShowInformation(object sender, string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(sender, message, AlertType.Information, interval);
        }

        #endregion

        #region Warning

        [Obsolete]
        public static void ShowWarning(string message)
        {
            ShowWarning(message, IntervalDefault);
        }

        [Obsolete]
        public static void ShowWarning(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Warning, interval);
        }

        public static void ShowWarning(object sender, string message)
        {
            ShowWarning(sender, message, IntervalDefault);
        }

        public static void ShowWarning(object sender, string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(sender, message, AlertType.Warning, interval);
        }

        #endregion

        #region Error

        [Obsolete]
        public static void ShowError(string message)
        {
            ShowError(message, IntervalDefault);
        }

        [Obsolete]
        public static void ShowError(string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Error, interval);
        }

        public static void ShowError(object sender, string message)
        {
            ShowError(sender, message, IntervalDefault);
        }

        public static void ShowError(object sender, string message, int interval)
        {
            var frm = new frmAlert();
            frm.ShowAlert(sender, message, AlertType.Error, interval);
        }

        #endregion

        #region Custom

        [Obsolete]
        public static void ShowCustom(string message, Image image = null, Color color = default)
        {
            ShowCustom(message, IntervalDefault, image, color);
        }

        [Obsolete]
        public static void ShowCustom(string message, int interval, Image image = null, Color color = default)
        {
            var frm = new frmAlert();
            frm.ShowAlert(message, AlertType.Custom, interval, image, color == default ? Color.FromArgb(83, 92, 104) : color);
        }

        public static void ShowCustom(object sender, string message, Image image = null, Color color = default)
        {
            ShowCustom(sender, message, IntervalDefault, image, color);
        }

        public static void ShowCustom(object sender, string message, int interval, Image image = null, Color color = default)
        {
            var frm = new frmAlert();
            frm.ShowAlert(sender, message, AlertType.Custom, interval, image, color == default ? Color.FromArgb(83, 92, 104) : color);
        }

        #endregion
    }
}