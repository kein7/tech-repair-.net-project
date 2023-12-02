using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Views;

namespace ModernGUI
{
    public partial class AdminUsuariosForm : Form, IAdminUsuariosForm
    {
        //Properties

        private string message;
        private bool isSucessfull;
        private bool isEdit;

        // Getters and Setters
        public string ModificarCargo { get => cbxModCargo.Text; set => cbxModCargo.Text = value; }
        public string CargoActual { get => lbCargoActualDb.Text; set => lbCargoActualDb.Text = value; }
        public string UsuarioCargo { get => lbUsuarioCargoDb.Text; set => lbUsuarioCargoDb.Text = value; }
        public string Usuario { get => txbUsuario.Text; set => txbUsuario.Text = value; }
        public string PasswordUsuario { get => txbContraUsuario.Text; set => txbContraUsuario.Text = value; }
        public string NombreUsuario { get => txbNombresUsuario.Text; set => txbNombresUsuario.Text = value; }
        public string ApellidoPaternoUsuario { get => txbApellidoPatUsuario.Text; set => txbApellidoPatUsuario.Text = value; }
        public string ApellidoMaternoUsuario { get => txbApellidoMatUsuario.Text; set => txbApellidoMatUsuario.Text = value; }
        public string EmailUsuario { get => txbEmailUsuario.Text; set => txbEmailUsuario.Text = value; }
        public string UsuarioTecnico { get => txbUsuarioTecnico.Text; set => txbUsuarioTecnico.Text = value; }
        public string PasswordTecnico { get => txbContraseñaTecnico.Text; set => txbContraseñaTecnico.Text = value; }
        public string NombreTecnico { get => txbNombresTecnico.Text; set => txbNombresTecnico.Text = value; }
        public string ApellidoPaternoTecnico { get => txbApellidoPatTecnico.Text; set => txbApellidoPatTecnico.Text = value; }
        public string ApellidoMaternoTecnico { get => txbApellidoMatTecnico.Text; set => txbApellidoMatTecnico.Text = value; }
        public string RutTecnico { get => txbRut.Text; set => txbRut.Text = value; }
        public string TelefonoTecnico { get => txbTelefono.Text; set => txbTelefono.Text = value; }
        public string EmailTecnico { get => txbEmailTecnico.Text; set => txbEmailTecnico.Text = value; }
        public string Cargo { get => cbxAgregarCargo.Text; set => cbxAgregarCargo.Text = value; }

        public string SearchValue { get => txbBusqueda.Text; set => txbBusqueda.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }

        public bool IsSucessfull { get => isSucessfull; set => isSucessfull = value; }
        public string Message { get => message; set => message = value; }

        public AdminUsuariosForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcUsuarios.TabPages.Remove(tpAdmUsuarios);

            tcAdmUsuarios.TabPages.Remove(tpModPrivilegiosUsuario);
            tcAdmUsuarios.TabPages.Remove(tpAgregarCargo);
            tcAdmUsuarios.TabPages.Remove(tpAgregarUsuario);
            tcAdmUsuarios.TabPages.Remove(tpAgregarTecnico);
        }

        public void SetUsuariosListBindingSource(BindingSource usuariosList)
        {
            dgvUsuarios.DataSource = usuariosList;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            btnAgregar.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tcUsuarios.TabPages.Remove(tpListaUsuarios);
                tcUsuarios.TabPages.Add(tpAdmUsuarios);
                tcAdmUsuarios.TabPages.Add(tpAgregarCargo);
            };
            btnModificar.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tcUsuarios.TabPages.Remove(tpListaUsuarios);
                tcUsuarios.TabPages.Add(tpAdmUsuarios);
                tcAdmUsuarios.TabPages.Add(tpModPrivilegiosUsuario);
            };

            btnGuardarUsuario.Click += delegate
            {
                SaveUsuarioEvent?.Invoke(this, EventArgs.Empty);
                if (isSucessfull)
                {
                    tcAdmUsuarios.TabPages.Remove(tpAgregarUsuario);
                    tcUsuarios.TabPages.Remove(tpAdmUsuarios);
                    tcUsuarios.TabPages.Add(tpListaUsuarios);
                }
                MessageBox.Show(Message);
            };
            btnGuardarTecnico.Click += delegate
            {
                SaveTecnicoEvent?.Invoke(this, EventArgs.Empty);
                if (isSucessfull)
                {
                    tcAdmUsuarios.TabPages.Remove(tpAgregarCargo);
                    tcUsuarios.TabPages.Remove(tpAdmUsuarios);
                    tcUsuarios.TabPages.Add(tpListaUsuarios);
                }
                MessageBox.Show(Message);
            };
            btnGuardarCargo.Click += delegate
            {
                SaveCargoEvent?.Invoke(this, EventArgs.Empty);
                if (isSucessfull)
                {
                    tcAdmUsuarios.TabPages.Remove(tpModPrivilegiosUsuario);
                    tcUsuarios.TabPages.Remove(tpAdmUsuarios);
                    tcUsuarios.TabPages.Add(tpListaUsuarios);
                }
                MessageBox.Show(Message);
            };
            btnEliminar.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                MessageBox.Show(Message);
            };
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(cbxAgregarCargo.Text == "Tecnico")
            {
                tcAdmUsuarios.TabPages.Remove(tpAgregarCargo);
                tcAdmUsuarios.TabPages.Add(tpAgregarTecnico);
            }
            else
            {
                tcAdmUsuarios.TabPages.Remove(tpAgregarCargo);
                tcAdmUsuarios.TabPages.Add(tpAgregarUsuario);
            }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveCargoEvent;
        public event EventHandler SaveUsuarioEvent;
        public event EventHandler SaveTecnicoEvent;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Singleton pattern
        private static AdminUsuariosForm instance;

        public static AdminUsuariosForm GetInstance(Form parentForm)
        {
            if (instance == null || instance.IsDisposed)
            {
                MainForm mainForm = (MainForm)parentForm;
                instance = new AdminUsuariosForm();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                mainForm.ShowAdminUsuariosFormInPanel(instance);
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void AdminUsuariosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'servicio_tecnicoDataSet.cargo' Puede moverla o quitarla según sea necesario.
            this.cargoTableAdapter.Fill(this.servicio_tecnicoDataSet.cargo);

        }

        
    }
}
