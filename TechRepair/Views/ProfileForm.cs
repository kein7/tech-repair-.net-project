using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Common.Cache;

namespace TechRepair.Views
{
    public partial class ProfileForm : Form, IProfileForm
    {
        private string message;
        private bool isSucessfull;
        private bool isEdit;
        private bool actualizaContra = false;

        public string UsuarioLb { get => lbUsuarioDb.Text; set => lbUsuarioDb.Text = value; }
        public string NombreLb { get => lbNombreDb.Text; set => lbNombreDb.Text = value; }
        public string ApellidoLb { get => lbApellidoDb.Text; set => lbApellidoDb.Text = value; }
        public string CargoLb { get => lbCargoDb.Text; set => lbCargoDb.Text = value; }

        public string UsuarioId { get; set; }
        public string Usuario {  get => tbUsuario.Text ; set => tbUsuario.Text = value; }
        public string Password { get => tbContraseña.Text; set => tbContraseña.Text = value; }
        public string ConfirmarPass { get => tbConfirmarContra.Text; set => tbConfirmarContra.Text = value; }
        public string PassActual { get => tbContraActual.Text; set => tbContraActual.Text = value; }
        public string Nombre { get => tbNombre.Text; set => tbNombre.Text = value; }
        public string ApellidoPaterno { get => tbApellidoPaterno.Text; set => tbApellidoPaterno.Text = value; }
        public string ApellidoMaterno { get => tbApellidoMaterno.Text; set => tbApellidoMaterno.Text = value; }
        public string Email { get => tbEmail.Text; set => tbEmail.Text = value; }

        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSucessfull { get => isSucessfull; set => isSucessfull = value; }
        public string Message { get => message; set => message = value; }
        public bool ActualizaContra { get => actualizaContra; set => actualizaContra = value; }

        public ProfileForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnGuardar.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSucessfull)
                {
                    panelRight.Visible = false;
                }
                MessageBox.Show(Message);
            };

            lbkEditarPerfil.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbContraseña.Visible = false;
                tbConfirmarContra.Visible = false;
                lbEditarContraseña.Visible = false;
                lbEditarConfirmarContra.Visible = false;
                tbContraseña.UseSystemPasswordChar = true;
                tbConfirmarContra.UseSystemPasswordChar = true;
                tbContraActual.UseSystemPasswordChar = true;
            };
            UsuarioLb = UserLoginCache.Usuario;
            NombreLb = UserLoginCache.Nombre;
            ApellidoLb = UserLoginCache.ApellidoPaterno + " " + UserLoginCache.ApellidoMaterno;
            CargoLb = Enum.GetName(typeof(Cargos), UserLoginCache.CargoId);
        }

        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler CancelEvent;

        // Singleton pattern
        private static ProfileForm instance;

        public static ProfileForm GetInstance(Form parentForm)
        {
            if (instance == null || instance.IsDisposed)
            {
                MainForm mainForm = (MainForm)parentForm;
                instance = new ProfileForm();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                mainForm.ShowProfileFormInPanel(instance);
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRight.Visible = true;
        }

        private void lkbModificarContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            actualizaContra = true;
            tbContraseña.Visible = true;
            tbConfirmarContra.Visible = true;
            lbEditarContraseña.Visible = true;
            lbEditarConfirmarContra.Visible = true;
            lbEditarContraActual.Visible = true;
            lkbModificarContra.Visible = false;
        }
    }
}
