using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechRepair.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechRepair
{
    public partial class OrdenesForm : Form, IOrdenesForm
    {
        //Properties

        private string message;
        private bool isSucessfull;
        private bool isEdit;

        // Getters and Setters
        public string OrdenId { get => lblOrdenId.Text; set => lblOrdenId.Text = value; }

        public string Marca { get => cbxMarca.Text; set => cbxMarca.Text = value; }
        public string Gama { get => cbxGama.Text; set => cbxGama.Text = value; }
        public string PlanReparacion { get => cbxPlan.Text; set => cbxPlan.Text = value; }
        public string NumSerie { get => tbxNumeroSerie.Text; set => tbxNumeroSerie.Text = value; }
        public string Modelo { get => txbModelo.Text; set => txbModelo.Text = value; }
        public string Color { get => cbxColor.Text; set => cbxColor.Text = value; }

        public string RutCliente { get => txbRutCliente.Text; set => txbRutCliente.Text = value; }
        public string NombresCliente { get => txbNombresCliente.Text; set => txbNombresCliente.Text = value; }
        public string ApellidoPatCliente { get => txbApellidoPat.Text; set => txbApellidoPat.Text = value; }
        public string ApellidoMatCliente { get => txbApellidoMat.Text; set => txbApellidoMat.Text = value; }
        public string NumTelefonoCliente { get => txbNumTelefono.Text; set => txbNumTelefono.Text = value; }
        public string EmailCliente { get => txbEmail.Text; set => txbEmail.Text = value; }
        public string DireccionId { get => lblDireccionId.Text; set => lblDireccionId.Text = value; }
        public string DireccionCliente { get => txbDireccion.Text; set => txbDireccion.Text = value; }
        public string ComunaCliente { get => cbxComuna.Text; set => cbxComuna.Text = value; }
        public string RegionCliente { get => cbxRegion.Text; set => cbxRegion.Text = value; }
        public string NumCalleCliente { get => txbNumCalle.Text; set => txbNumCalle.Text = value; }
        public string NumDptoCliente { get => txbNumDep.Text; set => txbNumDep.Text = value; }
        public string RutTercero { get => txbRutTercero.Text; set => txbRutTercero.Text = value; }
        public string NombresTercero { get => txbNombreTercero.Text; set => txbNombreTercero.Text = value; }
        public string ApellidoPatTercero { get => txbApellidoPaternoTercero.Text; set => txbApellidoPaternoTercero.Text = value; }
        public string ApellidoMatTercero { get => txbApellidoMaternoTercero.Text; set => txbApellidoMaternoTercero.Text = value; }
        public string CodigoTercero { get => txbCodigoTercero.Text; set => txbCodigoTercero.Text = value; }

        public string SearchValue { get => txbBusqueda.Text; set => txbBusqueda.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }

        public bool IsSucessfull { get => isSucessfull; set => isSucessfull = value; }
        public string Message { get => message; set => message = value; }

        public OrdenesForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcOrdenes.TabPages.Remove(tpDatosOrden);
            
            tcDatosOrden.TabPages.Remove(tpCliente);
            tcDatosOrden.TabPages.Remove(tpTercero);
        }

        public void SetOrdenesListBindingSource(BindingSource ordenesList)
        {
            dgvOrdenes.DataSource = ordenesList;
        }

        public void SetRegionesListBindingSource(BindingSource regionesList)
        {
            cbxRegion.DataSource = regionesList;
        }

        private void AssociateAndRaiseViewEvents()
        {
            btnBuscar.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txbBusqueda.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                };
            };
            
            btnAgregarOrden.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tcOrdenes.TabPages.Remove(tpOrdenes);
                tcOrdenes.TabPages.Add(tpDatosOrden);
                tpDatosOrden.Text = "Agregar nueva orden";
            };

            btnModificarOrden.Click += delegate {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tcOrdenes.TabPages.Remove(tpOrdenes);
                tcOrdenes.TabPages.Add(tpDatosOrden);
                tpDatosOrden.Text = "Editar orden";
                tcDatosOrden.TabPages.Remove(tpCliente);
            };

            btnGuardar.Click += delegate {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSucessfull)
                {
                    tcOrdenes.TabPages.Remove(tpDatosOrden);
                    tcOrdenes.TabPages.Add(tpOrdenes);
                    tcDatosOrden.TabPages.Remove(tpTercero);
                    tcDatosOrden.TabPages.Add(tpTelefono);
                }
                MessageBox.Show(Message);
            };

            btnEliminarOrden.Click += delegate {

                var result = MessageBox.Show("¿Estas seguro de eliminar la orden seleccionada?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            cbxComuna.SelectedIndexChanged += delegate
            {
                RefreshRegionCbx?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler RefreshRegionCbx;
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tcDatosOrden.TabPages.Remove(tpTelefono);
            tcDatosOrden.TabPages.Add(tpCliente);
        }
        private void btnSiguiente2_Click(object sender, EventArgs e)
        {
            tcDatosOrden.TabPages.Remove(tpCliente);
            tcDatosOrden.TabPages.Add(tpTercero);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            tcDatosOrden.TabPages.Remove(tpCliente);
            tcDatosOrden.TabPages.Add(tpTelefono);
        }
        private void btnAtras2_Click(object sender, EventArgs e)
        {
            tcDatosOrden.TabPages.Remove(tpTercero);
            tcDatosOrden.TabPages.Add(tpCliente);
        }

        // Singleton pattern
        private static OrdenesForm instance;

        public static OrdenesForm GetInstance(Form parentForm)
        {
            if (instance == null || instance.IsDisposed)
            {
                MainForm mainForm = (MainForm)parentForm;
                instance = new OrdenesForm();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                mainForm.ShowOrdenesFormInPanel(instance);
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void OrdenesForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'servicio_tecnicoDataSet.comunas' Puede moverla o quitarla según sea necesario.
            this.comunasTableAdapter.Fill(this.servicio_tecnicoDataSet.comunas);
            // TODO: esta línea de código carga datos en la tabla 'servicio_tecnicoDataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.servicio_tecnicoDataSet.planes);
            // TODO: esta línea de código carga datos en la tabla 'servicio_tecnicoDataSet.gamas' Puede moverla o quitarla según sea necesario.
            this.gamasTableAdapter.Fill(this.servicio_tecnicoDataSet.gamas);
            // TODO: esta línea de código carga datos en la tabla 'servicio_tecnicoDataSet.marcas' Puede moverla o quitarla según sea necesario.
            this.marcasTableAdapter.Fill(this.servicio_tecnicoDataSet.marcas);

        }
    }
}