using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair.Views
{
    public partial class PasswordRecoverForm : Form, IPasswordRecoverForm
    {
        public string userOrEmail {  get => txbUsuarioEmail.Text; set => txbUsuarioEmail.Text = value; }
        public string result { get => lbResultado.Text; set => lbResultado.Text = value; }
        public PasswordRecoverForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnEnviar.Click += delegate
            {
                RecoverPasswordEvent?.Invoke(this, EventArgs.Empty);
                lbResultado.Visible = true;
            };
        }
        public event EventHandler RecoverPasswordEvent;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
