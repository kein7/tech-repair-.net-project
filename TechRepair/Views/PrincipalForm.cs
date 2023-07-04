using TechRepair.Views;
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

namespace TechRepair
{
    public partial class PrincipalForm : Form, IPrincipalForm
    {
        
        //Constructor
        public PrincipalForm()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            btnPlanesRep.Click += delegate { ShowPlanesForm?.Invoke(this, EventArgs.Empty); };

        }

        public event EventHandler ShowPlanesForm;
        public event EventHandler ShowAdminUsuariosForm;
        public event EventHandler ShowEquiposCelularesForm;
        public event EventHandler ShowSistemaAtencionForm;

        
        public void ShowChildFormInPanel(PlanesRepForm planesForm)
        { 
            // Add the child form to the panel
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(planesForm);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        //

        private const int BorderSize = 8; // Width of the custom border
        private bool isResizing = false;
        private Point lastMousePosition;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the custom border
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Check if the mouse is within the custom border area
            if (e.Button == MouseButtons.Left && e.Location.Y < BorderSize)
            {
                isResizing = true;
                lastMousePosition = e.Location;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // Resize the form while moving the mouse if resizing is enabled
            if (isResizing)
            {
                int deltaX = e.Location.X - lastMousePosition.X;
                int deltaY = e.Location.Y - lastMousePosition.Y;
                Width += deltaX;
                Height += deltaY;
                lastMousePosition = e.Location;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Stop resizing
            if (e.Button == MouseButtons.Left)
            {
                isResizing = false;
            }
        }


    }
}
