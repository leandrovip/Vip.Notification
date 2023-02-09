using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Vip.Notification.Properties;

namespace Vip.Notification
{
    public partial class frmAlert : Form
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

        private AlertAction _action;
        private int _interval;
        private int positionX;
        private int positionY;
        private bool _autoClose = true; 

        /// <summary>
        /// Override ParentForm to be Writeable
        /// </summary>
        public new Form ParentForm
        {
            get;
            set;
        }

        /// <summary>
        /// Fenster anzeigen, ohne Focus zu klauen
        /// </summary>
        protected new bool ShowWithoutActivation
        {
            get => true;
        }

        /// <summary>
        /// Aktuelle Meldung
        /// </summary>
        public string Message
        {
            get => lblMessage.Text;
        }

        #endregion

        #region Constructor

        public frmAlert()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void CloseAlert_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            _action = AlertAction.Close;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (_action)
            {
                case AlertAction.Start:
                    timer.Interval = 1;
                    Opacity += 0.1;

                    if (positionX < Location.X) Left--;
                    else if (Opacity == 1.0) _action = AlertAction.Wait;

                    break;
                case AlertAction.Wait:
                    timer.Interval = _interval;

                    if (_autoClose == true)
                        _action = AlertAction.Close;

                    break;
                case AlertAction.Close:
                    timer.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;

                    if (Opacity == 0.0)
                        Close();
                    break;
            }
        }

        #endregion

        #region Methods

        internal void ShowAlert(string message, AlertType alertType, int interval, bool autoClose, Image image = null, Color color = default)
        {
            _autoClose = autoClose;
            ShowAlert(message, alertType, interval, image, color);
        }

        internal void ShowAlert(string message, AlertType alertType, int interval, Image image = null, Color color = default)
        {
            Opacity = 0.0;

            //WorkingArea on Primary Screen as Default
            var screenWorkingArea = Screen.PrimaryScreen.WorkingArea;

            //If parent is set, than get Screen of Parent
            if ( ParentForm != null )
            {
                //Get Screen WorkingArea where ParentForm is located
                screenWorkingArea = Screen.FromControl(ParentForm).WorkingArea;
            }

            StartPosition = FormStartPosition.Manual;

            for (int i = 1; i < 10; i++)
            {
                var formName = "alert" + i;
                var frm = (frmAlert) Application.OpenForms[formName];

                if (frm == null)
                {
                    Name = formName;
                    positionX = screenWorkingArea.X + screenWorkingArea.Width - Width + 15;
                    positionY = screenWorkingArea.Y + screenWorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(positionX, positionY);
                    break;
                }
            }

            positionX = screenWorkingArea.X + screenWorkingArea.Width - Width - 5;

            switch (alertType)
            {
                case AlertType.Success:
                    ptbLogo.Image = Resources.sucess48px;
                    BackColor = Alert.Color_Sucess;
                    break;
                case AlertType.Information:
                    ptbLogo.Image = Resources.information48px;
                    BackColor = Alert.Color_Information;
                    break;
                case AlertType.Warning:
                    ptbLogo.Image = Resources.warning48px;
                    BackColor = Alert.Color_Warning;
                    break;
                case AlertType.Error:
                    ptbLogo.Image = Resources.error48px;
                    BackColor = Alert.Color_Error;
                    break;
                case AlertType.Custom:
                    ptbLogo.Image = image ?? Resources.information48px;
                    BackColor = color;
                    break;
            }

            lblMessage.Text = message;
            _interval = interval;
            _action = AlertAction.Start;
            timer.Interval = 1;
            timer.Start();

            Show();
        }

        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;

                const int WS_EX_NOACTIVATE = 0x08000000;
                const int WS_EX_TOOLWINDOW = 0x00000080;
                baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);

                return baseParams;
            }
        }

        private void frmAlert_Load(object sender, EventArgs e)
        {
            ShowInactiveTopmost(this);
        }
    }
}