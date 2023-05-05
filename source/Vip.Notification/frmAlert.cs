using System;
using System.Drawing;
using System.Windows.Forms;
using Vip.Notification.Properties;

namespace Vip.Notification
{
    public partial class frmAlert : Form
    {
        #region Properties

        private AlertAction _action;
        private int _interval;
        private int positionX;
        private int positionY;
        protected override bool ShowWithoutActivation => true;

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
                    _action = AlertAction.Close;
                    break;
                case AlertAction.Close:
                    timer.Interval = 1;
                    Opacity -= 0.1;
                    Left -= 3;
                    if (Opacity == 0.0) Close();
                    break;
            }
        }

        #endregion

        #region Methods
        [Obsolete("Use ShowAlert with sender instead")]
        internal void ShowAlert(string message, AlertType alertType, int interval, Image image = null, Color color = default)
        {
            ShowAlert(null, message, alertType, interval, image, color);
        }

        internal void ShowAlert(object sender, string message, AlertType alertType, int interval, Image image = null, Color color = default)
        {
            var screen = Screen.PrimaryScreen;
            Control control = sender as Control;
            if (control != null)
                screen = Screen.FromControl(control);
            StartPosition = FormStartPosition.Manual;
            Opacity = 0.0;

            for (int i = 1; i < 10; i++)
            {
                var formName = "alert" + i;
                var frm = (frmAlert)Application.OpenForms[formName];

                if (frm == null)
                {
                    Name = formName;
                    positionX = screen.WorkingArea.Location.X + screen.WorkingArea.Width - Width;
                    positionY = screen.WorkingArea.Location.Y + screen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(positionX, positionY);
                    break;
                }
            }

            switch (alertType)
            {
                case AlertType.Sucess:
                    ptbLogo.Image = Resources.sucess48px;
                    BackColor = Color.SeaGreen;
                    break;
                case AlertType.Information:
                    ptbLogo.Image = Resources.information48px;
                    BackColor = Color.RoyalBlue;
                    break;
                case AlertType.Warning:
                    ptbLogo.Image = Resources.warning48px;
                    BackColor = Color.FromArgb(230, 126, 34);
                    break;
                case AlertType.Error:
                    ptbLogo.Image = Resources.error48px;
                    BackColor = Color.FromArgb(231, 76, 60);
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
    }
}