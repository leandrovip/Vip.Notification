namespace Vip.Notification
{
    partial class frmAlert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlert));
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Vip.Notification.Properties.Resources.sucess48px;
            this.ptbLogo.Location = new System.Drawing.Point(12, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(63, 57);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            this.ptbLogo.Click += new System.EventHandler(this.CloseAlert_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(81, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(275, 57);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Test message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Click += new System.EventHandler(this.CloseAlert_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClose.Image = global::Vip.Notification.Properties.Resources.close48px;
            this.ptbClose.Location = new System.Drawing.Point(362, 24);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(26, 33);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.CloseAlert_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmAlert
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(400, 81);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbLogo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlert";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.Text = "frmAlert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAlert_Load);
            this.Click += new System.EventHandler(this.CloseAlert_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Timer timer;
    }
}