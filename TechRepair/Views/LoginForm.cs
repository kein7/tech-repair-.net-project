using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TechRepair.Views
{
    public partial class LoginForm : Form, ILoginForm
    {
        //Properties

        private string message;
        private bool isSucessfull;

        // Getters and Setters

        public string Usuario { get => txbUsuario.Text; set => txbUsuario.Text = value; }
        public string Password { get => txbPassword.Text; set => txbPassword.Text = value; }
        public string MessageError { get => lbErrorMessage.Text; set => lbErrorMessage.Text = value; }
        public bool IsSucessfull { get => isSucessfull; set => isSucessfull = value; }
        public string Message { get => message; set => message = value; }


        public LoginForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

        }

        private void AssociateAndRaiseViewEvents()
        {
            btnAcceder.Click += delegate 
            { 
                ValidateLoginEvent?.Invoke(this, EventArgs.Empty);
                if (isSucessfull)
                {
                    lbErrorMessage.Visible = false;
                }
                else
                {
                    lbErrorMessage.Visible = true;
                }
            };

            lklbRecuperarContra.Click += delegate
            {
                RecoverPassEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler ValidateLoginEvent;
        public event EventHandler RecoverPassEvent;

        public void SetFocusToUsername()
        {
            txbUsuario.Focus();
        }

        public void SetDefaultPasswordTextbox()
        {
            txbPassword.Text = "Password";
            txbPassword.ForeColor = Color.DimGray;
            txbPassword.UseSystemPasswordChar = false;
        }
        public void LogOut()
        {
            txbUsuario.Text = "Usuario";
            txbPassword.Text = "Password";
            txbUsuario.ForeColor = Color.DimGray;
            txbPassword.ForeColor = Color.DimGray;
            txbPassword.UseSystemPasswordChar = false;
            lbErrorMessage.Visible = false;
            this.Show();
            txbUsuario.Focus();
        }
        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "Usuario")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = Color.Black;
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if(txbUsuario.Text == "")
            {
                txbUsuario.Text = "Usuario";
                txbUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "Password")
            {
                txbPassword.Text = "";
                txbPassword.ForeColor = Color.Black;
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == "")
            {
                txbPassword.Text = "Password";
                txbPassword.ForeColor = Color.DimGray;
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
