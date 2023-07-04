using TechRepair.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRepair
{
    public partial class PlanesRepForm : Form, IPlanesRepForm
    {
        private string message;
        private bool isSucessfull;
        private bool isEdit;

        public PlanesRepForm()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tcPlanes.TabPages.Remove(tpPlanesDatos);
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

            btnAgregarPlan.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tcPlanes.TabPages.Remove(tpPlanes);
                tcPlanes.TabPages.Add(tpPlanesDatos);
                tpPlanesDatos.Text = "Agregar nuevo plan";
            };

            btnModificar.Click += delegate { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tcPlanes.TabPages.Remove(tpPlanes);
                tcPlanes.TabPages.Add(tpPlanesDatos);
                tpPlanesDatos.Text = "Editar plan";
            };

            btnGuardar.Click += delegate { 
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSucessfull)
                {
                    tcPlanes.TabPages.Remove(tpPlanesDatos);
                    tcPlanes.TabPages.Add(tpPlanes);
                }
                MessageBox.Show(Message);
            };

            btnCancelar.Click += delegate { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tcPlanes.TabPages.Remove(tpPlanesDatos);
                tcPlanes.TabPages.Add(tpPlanes);
            };

            btnEliminarPlan.Click += delegate { 
                
                var result = MessageBox.Show("¿Estas seguro de eliminar el plan seleccionado?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        //properties
        public string PlanId { get => lbPlanId.Text; set => lbPlanId.Text = value; }
        public string PlanReparacion { get => cbxPlanReparacion.Text; set => cbxPlanReparacion.Text = value; }
        public string PlanValor { get => tbxValorPlan.Text; set => tbxValorPlan.Text = value; }
        public string PlanEstado { get => cbxEstadoPlan.Text; set => cbxEstadoPlan.Text = value; }
        public string PlazoEntrega { get => tbxPlazoEntregaPlan.Text; set => tbxPlazoEntregaPlan.Text = value; }
        public string GamaId { get => cbxGama.Text; set => cbxGama.Text = value; }

        public string SearchValue { get => txbBusqueda.Text; set => txbBusqueda.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }

        public bool IsSucessfull { get => isSucessfull; set => isSucessfull = value; }
        public string Message { get => message; set => message = value; }

        //events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Singleton pattern
        private static PlanesRepForm instance;
        public static PlanesRepForm GetInstance(Form parentForm)
        { 
            if (instance == null || instance.IsDisposed)
            {
                PrincipalForm principalForm = (PrincipalForm)parentForm;
                instance = new PlanesRepForm();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                principalForm.ShowChildFormInPanel(instance);
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetPlanesListBindingSource(BindingSource planesList)
        {
            dgvPlanes.DataSource = planesList;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPlanId_Click(object sender, EventArgs e)
        {

        }

        private void cbxPlanReparacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPlanReparacion_Click(object sender, EventArgs e)
        {

        }

        private void cbxGama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGama_Click(object sender, EventArgs e)
        {

        }

        private void cbxEstadoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEstadoPlan_Click(object sender, EventArgs e)
        {

        }

        private void tbxValorPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlanValor_Click(object sender, EventArgs e)
        {

        }

        private void tbxPlazoEntregaPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPlazoEntregaPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txbBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTituloPlanes_Click(object sender, EventArgs e)
        {

        }
    }
}
