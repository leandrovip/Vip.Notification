using System.Drawing;
using System.Windows.Forms;

namespace Vip.Notification
{
    public class Alert
    {
        #region Properties

        private static readonly int IntervalDefault = 1850;

        #endregion

        #region Success

        public static void ShowSuccess(string message, Form parent = null)
        {
            ShowSuccess(message, IntervalDefault, parent);
        }

        public static void ShowSuccess(string message, int interval, Form parent = null)
        {
            var frm = new frmAlert();
            frm.ParentForm = parent;
            frm.ShowAlert(message, AlertType.Sucess, interval);
        }

        #endregion

        #region Information

        public static void ShowInformation(string message, Form parent = null)
        {
            ShowInformation(message, IntervalDefault, parent);
        }

        public static void ShowInformation(string message, int interval, Form parent = null)
        {
            var frm = new frmAlert();
            frm.ParentForm = parent;
            frm.ShowAlert(message, AlertType.Information, interval);
        }

        #endregion

        #region Warning

        public static void ShowWarning(string message, Form parent = null)
        {
            ShowWarning(message, IntervalDefault, parent);
        }

        public static void ShowWarning(string message, int interval, Form parent = null)
        {
            var frm = new frmAlert();
            frm.ParentForm = parent;
            frm.ShowAlert(message, AlertType.Warning, interval);
        }

        #endregion

        #region Error

        public static void ShowError(string message, Form parent = null)
        {
            ShowError(message, IntervalDefault, parent);
        }

        public static void ShowError(string message, int interval, Form parent = null)
        {
            var frm = new frmAlert();
            frm.ParentForm = parent;
            frm.ShowAlert(message, AlertType.Error, interval);
        }

        #endregion

        #region Custom

        public static void ShowCustom(string message, Image image = null, Color color = default, Form parent = null)
        {
            ShowCustom(message, IntervalDefault, image, color, parent);
        }

        public static void ShowCustom(string message, int interval, Image image = null, Color color = default, Form parent = null)
        {
            var frm = new frmAlert();
            frm.ParentForm = parent;
            frm.ShowAlert(message, AlertType.Custom, interval, image, color == default ? Color.FromArgb(83, 92, 104) : color);
        }

        #endregion
    }
}