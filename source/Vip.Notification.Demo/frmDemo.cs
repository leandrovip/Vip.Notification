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

        private void btnSucess_Click(object sender, EventArgs e)
        {
            Alert.ShowSucess(this, "Registro salvo com sucesso!");
            
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Alert.ShowInformation(this, "Nova atualização disponível!");
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            Alert.ShowWarning(this, "Alerta!! Verifique suas permissões");
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Alert.ShowError(this, "Ops!! Algo não deu certo :(");
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            Alert.ShowCustom(this, "Olá!! Notificação customizada.", color: Color.FromArgb(179, 55, 113));
        }

        #endregion
    }
}