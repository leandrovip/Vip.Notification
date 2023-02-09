using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Vip.Notification
{
    public class Alert
    {
        #region Windows API
        private const int SW_SHOWNOACTIVATE = 4;
        private const int HWND_TOPMOST = -1;
        private const uint SWP_NOACTIVATE = 0x0010;
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]

        static extern bool SetWindowPos(
         int hWnd,             // Window handle
         int hWndInsertAfter,  // Placement-order handle
         int X,                // Horizontal position
         int Y,                // Vertical position
         int cx,               // Width
         int cy,               // Height
         uint uFlags);         // Window positioning flags

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        static void ShowInactiveTopmost(Form frm)
        {
            ShowWindow(frm.Handle, SW_SHOWNOACTIVATE);
            SetWindowPos(frm.Handle.ToInt32(), HWND_TOPMOST,
            frm.Left, frm.Top, frm.Width, frm.Height,
            SWP_NOACTIVATE);
        }

        #endregion


        #region Properties

        private static readonly int IntervalDefault = 1850;

        public static Color Color_Sucess = Color.FromArgb(13, 148, 0);
        public static Color Color_Information = Color.FromArgb(0, 125, 255);
        public static Color Color_Warning = Color.FromArgb(255, 170, 34);
        public static Color Color_Error = Color.FromArgb(255, 0, 0);

        private static ConcurrentDictionary<object,frmAlert> internalList = new ConcurrentDictionary<object,frmAlert>();

        #endregion

        private static void createNewForm(string message, AlertType alertType, int interval, Form parent = null, bool autoClose = true, object requester = null, Image image = null, Color customColor = default)
        {
            if (parent != null && parent.InvokeRequired)
            {
                createNewFormCallback del = new createNewFormCallback(createNewForm);
                parent.Invoke(del, new object[] { message, alertType, interval, parent, autoClose, requester, image, customColor });
            }
            else
            {
                //Prüfe, ob es einen Requester für dieses Fenster gibt, wenn nicht, dann generiere eine GUID
                if (requester == null)
                    requester = Guid.NewGuid();

                frmAlert existingForm;
                //Prüfe, ob bereits ein Fenster von diesem Requester existiert
                if (internalList.TryGetValue(requester, out existingForm) == true)
                {
                    //Prüfe, ob die Meldung ident ist, wenn ja, dann abbruch, sonst wird das offene Fenster geschlossen
                    if (existingForm.Message.Equals(message))
                        return; //Abbruch
                    else
                        existingForm.Close(); //Schließe das geöffnete Fenster und öffne ein neues
                }

                //Generiere ein neues Fenster
                frmAlert frm = new frmAlert();
                frm.ParentForm = parent;
                frm.Tag = requester; //Speichere Requester in Tag

                frm.FormClosed += frmFormClosed;
                frm.Load += Frm_Load;
                internalList.TryAdd(frm.Tag, frm); //Speichere Fenster in Liste

                //Zeige Fenster an
                frm.ShowAlert(message, alertType, interval, autoClose, image, customColor);
            }
        }
        delegate void createNewFormCallback(string message, AlertType alertType, int interval, Form parent = null, bool autoClose = true, object requester = null, Image image = null, Color customColor = default);

        private static void Frm_Load(object sender, EventArgs e)
        {
            ShowInactiveTopmost(sender as Form);
        }

        /// <summary>
        /// Wird aufgerufen, wenn das Fenster geschlossen wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void frmFormClosed(object sender, FormClosedEventArgs e)
        {
            //Entferne Fenster aus Liste
            frmAlert form;
            internalList.TryRemove((sender as frmAlert).Tag, out form);
        }

        #region Success

        public static void ShowSuccess(string message, Form parent = null, bool autoClose = true, object requester = null)
        {
            ShowSuccess(message, IntervalDefault, parent, autoClose, requester);
        }

        public static void ShowSuccess(string message, int interval, Form parent = null, bool autoClose = true, object requester = null)
        {
            createNewForm(message, AlertType.Success, interval, parent, autoClose, requester);
        }

        #endregion

        #region Information

        public static void ShowInformation(string message, Form parent = null, bool autoClose = true, object requester = null)
        {
            ShowInformation(message, IntervalDefault, parent, autoClose, requester);
        }

        public static void ShowInformation(string message, int interval, Form parent = null, bool autoClose = true, object requester = null)
        {
            createNewForm(message, AlertType.Information, interval, parent, autoClose, requester);
        }

        #endregion

        #region Warning

        public static void ShowWarning(string message, Form parent = null, bool autoClose = false, object requester = null)
        {
            ShowWarning(message, IntervalDefault, parent, autoClose, requester);
        }

        public static void ShowWarning(string message, int interval, Form parent = null, bool autoClose = false, object requester = null)
        {
            createNewForm(message, AlertType.Warning, interval, parent, autoClose, requester);
        }

        #endregion

        #region Error

        public static void ShowError(string message, Form parent = null, bool autoClose = false, object requester = null)
        {
            ShowError(message, IntervalDefault, parent, autoClose, requester);
        }

        public static void ShowError(string message, int interval, Form parent = null, bool autoClose = false, object requester = null)
        {
            createNewForm(message, AlertType.Error, interval, parent, autoClose, requester);
        }

        #endregion

        #region Custom

        public static void ShowCustom(string message, bool autoClose = true, object requester = null, Image image = null, Color color = default, Form parent = null)
        {
            ShowCustom(message, IntervalDefault, autoClose, requester, image, color, parent);
        }

        public static void ShowCustom(string message, int interval, bool autoClose = true, object requester = null, Image image = null, Color color = default, Form parent = null)
        {
            createNewForm(message, AlertType.Custom, interval, parent, autoClose, requester, image, color == default ? Color.FromArgb(83, 92, 104) : color);
        }

        #endregion
    }
}