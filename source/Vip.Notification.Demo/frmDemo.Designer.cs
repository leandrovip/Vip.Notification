namespace Vip.Notification.Demo
{
    partial class frmDemo
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
            this.btnSuccessPrimary = new System.Windows.Forms.Button();
            this.btnInformationPrimary = new System.Windows.Forms.Button();
            this.btnWarningPrimary = new System.Windows.Forms.Button();
            this.btnErrorPrimary = new System.Windows.Forms.Button();
            this.btnCustomPrimary = new System.Windows.Forms.Button();
            this.linkProject = new System.Windows.Forms.LinkLabel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblCaptionOnPrimary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnErrorAppScreen = new System.Windows.Forms.Button();
            this.btnCustomAppScreen = new System.Windows.Forms.Button();
            this.btnWarningAppScreen = new System.Windows.Forms.Button();
            this.btnInformationAppScreen = new System.Windows.Forms.Button();
            this.btnSuccessAppScreen = new System.Windows.Forms.Button();
            this.btnErrorAppScreenStayOpen = new System.Windows.Forms.Button();
            this.btnErrorPrimaryStayOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuccessPrimary
            // 
            this.btnSuccessPrimary.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSuccessPrimary.FlatAppearance.BorderSize = 0;
            this.btnSuccessPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccessPrimary.ForeColor = System.Drawing.Color.White;
            this.btnSuccessPrimary.Location = new System.Drawing.Point(12, 21);
            this.btnSuccessPrimary.Name = "btnSuccessPrimary";
            this.btnSuccessPrimary.Size = new System.Drawing.Size(130, 46);
            this.btnSuccessPrimary.TabIndex = 0;
            this.btnSuccessPrimary.Text = "Success";
            this.btnSuccessPrimary.UseVisualStyleBackColor = false;
            this.btnSuccessPrimary.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnInformationPrimary
            // 
            this.btnInformationPrimary.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInformationPrimary.FlatAppearance.BorderSize = 0;
            this.btnInformationPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformationPrimary.ForeColor = System.Drawing.Color.White;
            this.btnInformationPrimary.Location = new System.Drawing.Point(12, 82);
            this.btnInformationPrimary.Name = "btnInformationPrimary";
            this.btnInformationPrimary.Size = new System.Drawing.Size(130, 46);
            this.btnInformationPrimary.TabIndex = 0;
            this.btnInformationPrimary.Text = "Information";
            this.btnInformationPrimary.UseVisualStyleBackColor = false;
            this.btnInformationPrimary.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnWarningPrimary
            // 
            this.btnWarningPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnWarningPrimary.FlatAppearance.BorderSize = 0;
            this.btnWarningPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarningPrimary.ForeColor = System.Drawing.Color.White;
            this.btnWarningPrimary.Location = new System.Drawing.Point(148, 21);
            this.btnWarningPrimary.Name = "btnWarningPrimary";
            this.btnWarningPrimary.Size = new System.Drawing.Size(130, 46);
            this.btnWarningPrimary.TabIndex = 0;
            this.btnWarningPrimary.Text = "Warning";
            this.btnWarningPrimary.UseVisualStyleBackColor = false;
            this.btnWarningPrimary.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnErrorPrimary
            // 
            this.btnErrorPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnErrorPrimary.FlatAppearance.BorderSize = 0;
            this.btnErrorPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorPrimary.ForeColor = System.Drawing.Color.White;
            this.btnErrorPrimary.Location = new System.Drawing.Point(148, 82);
            this.btnErrorPrimary.Name = "btnErrorPrimary";
            this.btnErrorPrimary.Size = new System.Drawing.Size(130, 46);
            this.btnErrorPrimary.TabIndex = 0;
            this.btnErrorPrimary.Text = "Error";
            this.btnErrorPrimary.UseVisualStyleBackColor = false;
            this.btnErrorPrimary.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnCustomPrimary
            // 
            this.btnCustomPrimary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnCustomPrimary.FlatAppearance.BorderSize = 0;
            this.btnCustomPrimary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomPrimary.ForeColor = System.Drawing.Color.White;
            this.btnCustomPrimary.Location = new System.Drawing.Point(284, 21);
            this.btnCustomPrimary.Name = "btnCustomPrimary";
            this.btnCustomPrimary.Size = new System.Drawing.Size(130, 46);
            this.btnCustomPrimary.TabIndex = 0;
            this.btnCustomPrimary.Text = "Custom";
            this.btnCustomPrimary.UseVisualStyleBackColor = false;
            this.btnCustomPrimary.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // linkProject
            // 
            this.linkProject.AutoSize = true;
            this.linkProject.Location = new System.Drawing.Point(73, 441);
            this.linkProject.Name = "linkProject";
            this.linkProject.Size = new System.Drawing.Size(84, 13);
            this.linkProject.TabIndex = 1;
            this.linkProject.TabStop = true;
            this.linkProject.Text = "Leandro Ferreira";
            this.linkProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProject_LinkClicked);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(9, 441);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(64, 13);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Develop by:";
            // 
            // lblCaptionOnPrimary
            // 
            this.lblCaptionOnPrimary.AutoSize = true;
            this.lblCaptionOnPrimary.Location = new System.Drawing.Point(12, 5);
            this.lblCaptionOnPrimary.Name = "lblCaptionOnPrimary";
            this.lblCaptionOnPrimary.Size = new System.Drawing.Size(78, 13);
            this.lblCaptionOnPrimary.TabIndex = 3;
            this.lblCaptionOnPrimary.Text = "Primary Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Application Screen";
            // 
            // btnErrorAppScreen
            // 
            this.btnErrorAppScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnErrorAppScreen.FlatAppearance.BorderSize = 0;
            this.btnErrorAppScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorAppScreen.ForeColor = System.Drawing.Color.White;
            this.btnErrorAppScreen.Location = new System.Drawing.Point(148, 224);
            this.btnErrorAppScreen.Name = "btnErrorAppScreen";
            this.btnErrorAppScreen.Size = new System.Drawing.Size(130, 46);
            this.btnErrorAppScreen.TabIndex = 5;
            this.btnErrorAppScreen.Text = "Error";
            this.btnErrorAppScreen.UseVisualStyleBackColor = false;
            this.btnErrorAppScreen.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnCustomAppScreen
            // 
            this.btnCustomAppScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnCustomAppScreen.FlatAppearance.BorderSize = 0;
            this.btnCustomAppScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomAppScreen.ForeColor = System.Drawing.Color.White;
            this.btnCustomAppScreen.Location = new System.Drawing.Point(284, 163);
            this.btnCustomAppScreen.Name = "btnCustomAppScreen";
            this.btnCustomAppScreen.Size = new System.Drawing.Size(130, 46);
            this.btnCustomAppScreen.TabIndex = 6;
            this.btnCustomAppScreen.Text = "Custom";
            this.btnCustomAppScreen.UseVisualStyleBackColor = false;
            this.btnCustomAppScreen.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnWarningAppScreen
            // 
            this.btnWarningAppScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnWarningAppScreen.FlatAppearance.BorderSize = 0;
            this.btnWarningAppScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarningAppScreen.ForeColor = System.Drawing.Color.White;
            this.btnWarningAppScreen.Location = new System.Drawing.Point(148, 163);
            this.btnWarningAppScreen.Name = "btnWarningAppScreen";
            this.btnWarningAppScreen.Size = new System.Drawing.Size(130, 46);
            this.btnWarningAppScreen.TabIndex = 7;
            this.btnWarningAppScreen.Text = "Warning";
            this.btnWarningAppScreen.UseVisualStyleBackColor = false;
            this.btnWarningAppScreen.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnInformationAppScreen
            // 
            this.btnInformationAppScreen.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInformationAppScreen.FlatAppearance.BorderSize = 0;
            this.btnInformationAppScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformationAppScreen.ForeColor = System.Drawing.Color.White;
            this.btnInformationAppScreen.Location = new System.Drawing.Point(12, 224);
            this.btnInformationAppScreen.Name = "btnInformationAppScreen";
            this.btnInformationAppScreen.Size = new System.Drawing.Size(130, 46);
            this.btnInformationAppScreen.TabIndex = 8;
            this.btnInformationAppScreen.Text = "Information";
            this.btnInformationAppScreen.UseVisualStyleBackColor = false;
            this.btnInformationAppScreen.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnSuccessAppScreen
            // 
            this.btnSuccessAppScreen.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSuccessAppScreen.FlatAppearance.BorderSize = 0;
            this.btnSuccessAppScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccessAppScreen.ForeColor = System.Drawing.Color.White;
            this.btnSuccessAppScreen.Location = new System.Drawing.Point(12, 163);
            this.btnSuccessAppScreen.Name = "btnSuccessAppScreen";
            this.btnSuccessAppScreen.Size = new System.Drawing.Size(130, 46);
            this.btnSuccessAppScreen.TabIndex = 9;
            this.btnSuccessAppScreen.Text = "Success";
            this.btnSuccessAppScreen.UseVisualStyleBackColor = false;
            this.btnSuccessAppScreen.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // btnErrorAppScreenStayOpen
            // 
            this.btnErrorAppScreenStayOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnErrorAppScreenStayOpen.FlatAppearance.BorderSize = 0;
            this.btnErrorAppScreenStayOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorAppScreenStayOpen.ForeColor = System.Drawing.Color.White;
            this.btnErrorAppScreenStayOpen.Location = new System.Drawing.Point(284, 224);
            this.btnErrorAppScreenStayOpen.Name = "btnErrorAppScreenStayOpen";
            this.btnErrorAppScreenStayOpen.Size = new System.Drawing.Size(130, 46);
            this.btnErrorAppScreenStayOpen.TabIndex = 10;
            this.btnErrorAppScreenStayOpen.Text = "Error (stay open)";
            this.btnErrorAppScreenStayOpen.UseVisualStyleBackColor = false;
            this.btnErrorAppScreenStayOpen.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnErrorPrimaryStayOpen
            // 
            this.btnErrorPrimaryStayOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnErrorPrimaryStayOpen.FlatAppearance.BorderSize = 0;
            this.btnErrorPrimaryStayOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErrorPrimaryStayOpen.ForeColor = System.Drawing.Color.White;
            this.btnErrorPrimaryStayOpen.Location = new System.Drawing.Point(284, 82);
            this.btnErrorPrimaryStayOpen.Name = "btnErrorPrimaryStayOpen";
            this.btnErrorPrimaryStayOpen.Size = new System.Drawing.Size(130, 46);
            this.btnErrorPrimaryStayOpen.TabIndex = 11;
            this.btnErrorPrimaryStayOpen.Text = "Error";
            this.btnErrorPrimaryStayOpen.UseVisualStyleBackColor = false;
            this.btnErrorPrimaryStayOpen.Click += new System.EventHandler(this.btnError_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 463);
            this.Controls.Add(this.btnErrorPrimaryStayOpen);
            this.Controls.Add(this.btnErrorAppScreenStayOpen);
            this.Controls.Add(this.btnErrorAppScreen);
            this.Controls.Add(this.btnCustomAppScreen);
            this.Controls.Add(this.btnWarningAppScreen);
            this.Controls.Add(this.btnInformationAppScreen);
            this.Controls.Add(this.btnSuccessAppScreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCaptionOnPrimary);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.linkProject);
            this.Controls.Add(this.btnErrorPrimary);
            this.Controls.Add(this.btnCustomPrimary);
            this.Controls.Add(this.btnWarningPrimary);
            this.Controls.Add(this.btnInformationPrimary);
            this.Controls.Add(this.btnSuccessPrimary);
            this.Name = "frmDemo";
            this.Text = "Demo Vip.Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuccessPrimary;
        private System.Windows.Forms.Button btnInformationPrimary;
        private System.Windows.Forms.Button btnWarningPrimary;
        private System.Windows.Forms.Button btnErrorPrimary;
        private System.Windows.Forms.Button btnCustomPrimary;
        private System.Windows.Forms.LinkLabel linkProject;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblCaptionOnPrimary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnErrorAppScreen;
        private System.Windows.Forms.Button btnCustomAppScreen;
        private System.Windows.Forms.Button btnWarningAppScreen;
        private System.Windows.Forms.Button btnInformationAppScreen;
        private System.Windows.Forms.Button btnSuccessAppScreen;
        private System.Windows.Forms.Button btnErrorAppScreenStayOpen;
        private System.Windows.Forms.Button btnErrorPrimaryStayOpen;
    }
}