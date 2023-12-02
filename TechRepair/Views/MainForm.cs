using ModernGUI;
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
using TechRepair.Common.Cache;
using TechRepair.Presenters;
using TechRepair.Presenters.Common;
using TechRepair.Views;

namespace TechRepair.Views
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            btnOrdenes.Click += delegate { ShowOrdenesForm?.Invoke(this, EventArgs.Empty); };
            btnPlanesRep.Click += delegate { ShowPlanesForm?.Invoke(this, EventArgs.Empty); };
            lklbEditarPerfil.Click += delegate { ShowProfileForm?.Invoke(this, EventArgs.Empty); };
            btnAdminUsuarios.Click += delegate { ShowAdminUsuariosForm?.Invoke(this, EventArgs.Empty); };

            if(UserLoginCache.CargoId == 2)
            {
                btnPlanesRep.Enabled = false;
                btnAdminUsuarios.Enabled = false;
            }
            else if(UserLoginCache.CargoId == 3)
            {
                btnAdminUsuarios.Enabled = false;
                btnPlanesRep.Enabled = false;
                btnOrdenes.Enabled = false;
                btnModificarCliente.Enabled = false;
            }

        }
        public event EventHandler ShowOrdenesForm;
        public event EventHandler ShowClientesForm;
        public event EventHandler ShowPlanesForm;
        public event EventHandler ShowAdminUsuariosForm;
        public event EventHandler ShowProfileForm;


        private void CloseAllOtherForms()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != this && !form.IsDisposed) // Exclude the current parent form and check if the form is not disposed
                {
                    form.Close();
                }
            }
        }



        public void ShowOrdenesFormInPanel(OrdenesForm ordenesForm)
        {
            
            //CloseAllOtherForms();
            
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(ordenesForm);
        }
        public void ShowPlanesFormInPanel(PlanesRepForm planesForm)
        {
            //CloseAllOtherForms();
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(planesForm);
        }

        public void ShowAdminUsuariosFormInPanel(AdminUsuariosForm adminUsuariosForm)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(adminUsuariosForm);
        }

        public void ShowProfileFormInPanel(ProfileForm profileForm)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(profileForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            lbNombre.Text = UserLoginCache.Nombre + " " + UserLoginCache.ApellidoPaterno + " " + UserLoginCache.ApellidoMaterno;
            lblCargo.Text = ((Cargos)UserLoginCache.CargoId).ToString();
            lbEmail.Text = UserLoginCache.Email;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                this.Size = new Size(sw, sh);
                this.Location = new Point(lx, ly);
            }
            else
            {
                lx = this.Location.X;
                ly = this.Location.Y;
                sw = this.Size.Width;
                sh = this.Size.Height;

                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            }
        }
        
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar la aplicación?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Estas seguro de cerrar la sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Mover form manteniendo el click izq presionado 

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
