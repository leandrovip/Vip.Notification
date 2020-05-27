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
            this.btnSucess = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.linkProject = new System.Windows.Forms.LinkLabel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSucess
            // 
            this.btnSucess.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSucess.FlatAppearance.BorderSize = 0;
            this.btnSucess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucess.ForeColor = System.Drawing.Color.White;
            this.btnSucess.Location = new System.Drawing.Point(16, 26);
            this.btnSucess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSucess.Name = "btnSucess";
            this.btnSucess.Size = new System.Drawing.Size(173, 57);
            this.btnSucess.TabIndex = 0;
            this.btnSucess.Text = "Sucess";
            this.btnSucess.UseVisualStyleBackColor = false;
            this.btnSucess.Click += new System.EventHandler(this.btnSucess_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.White;
            this.btnInformation.Location = new System.Drawing.Point(16, 101);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(173, 57);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnWarning.FlatAppearance.BorderSize = 0;
            this.btnWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarning.ForeColor = System.Drawing.Color.White;
            this.btnWarning.Location = new System.Drawing.Point(197, 26);
            this.btnWarning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(173, 57);
            this.btnWarning.TabIndex = 0;
            this.btnWarning.Text = "Warning";
            this.btnWarning.UseVisualStyleBackColor = false;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnError
            // 
            this.btnError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnError.FlatAppearance.BorderSize = 0;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.ForeColor = System.Drawing.Color.White;
            this.btnError.Location = new System.Drawing.Point(197, 101);
            this.btnError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(173, 57);
            this.btnError.TabIndex = 0;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = false;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(55)))), ((int)(((byte)(113)))));
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.ForeColor = System.Drawing.Color.White;
            this.btnCustom.Location = new System.Drawing.Point(379, 26);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(173, 57);
            this.btnCustom.TabIndex = 0;
            this.btnCustom.Text = "Custom";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // linkProject
            // 
            this.linkProject.AutoSize = true;
            this.linkProject.Location = new System.Drawing.Point(101, 190);
            this.linkProject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkProject.Name = "linkProject";
            this.linkProject.Size = new System.Drawing.Size(108, 16);
            this.linkProject.TabIndex = 1;
            this.linkProject.TabStop = true;
            this.linkProject.Text = "Leandro Ferreira";
            this.linkProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProject_LinkClicked);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(16, 190);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(81, 16);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "Develop by:";
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 223);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.linkProject);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnInformation);
            this.Controls.Add(this.btnSucess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDemo";
            this.Text = "Demo Vip.Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSucess;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.LinkLabel linkProject;
        private System.Windows.Forms.Label lblCaption;
    }
}