using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Vip.Notification.Demo
{
    public partial class frmDemo : Form
    {
        #region Constructor

        public frmDemo()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void linkProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/leandrovip");
        }

        private void btnSuccess_Click(object sender, EventArgs e)
        {
            if ( sender == btnSuccessAppScreen )
                Alert.ShowSuccess("Registro salvo com sucesso!", this);   
            else 
                Alert.ShowSuccess("Registro salvo com sucesso!");
            
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            if (sender == btnInformationAppScreen)
                Alert.ShowInformation("Nova atualização disponível!", this);
            else
                Alert.ShowInformation("Nova atualização disponível!");
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            if (sender == btnWarningAppScreen)
                Alert.ShowWarning("Alerta!! Verifique suas permissões", this);
            else
                Alert.ShowWarning("Alerta!! Verifique suas permissões");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            if (sender == btnErrorAppScreen)
                Alert.ShowError("Ops!! Algo não deu certo :(", this);
            else
                Alert.ShowError("Ops!! Algo não deu certo :(");
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (sender == btnCustomAppScreen)
                Alert.ShowCustom("Olá!! Notificação customizada.", color: Color.FromArgb(179, 55, 113), parent: this);
            else
                Alert.ShowCustom("Olá!! Notificação customizada.", color: Color.FromArgb(179, 55, 113));
        }

        #endregion
    }
}