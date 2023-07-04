namespace TechRepair
{
    partial class PlanesRepForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTituloPlanes = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            this.btnEliminarPlan = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tcPlanes = new System.Windows.Forms.TabControl();
            this.tpPlanes = new System.Windows.Forms.TabPage();
            this.tpPlanesDatos = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblGama = new System.Windows.Forms.Label();
            this.tbxPlazoEntregaPlan = new System.Windows.Forms.TextBox();
            this.cbxPlanReparacion = new System.Windows.Forms.ComboBox();
            this.cbxGama = new System.Windows.Forms.ComboBox();
            this.lbPlanId = new System.Windows.Forms.Label();
            this.tbxValorPlan = new System.Windows.Forms.TextBox();
            this.lblPlazoEntregaPlan = new System.Windows.Forms.Label();
            this.cbxEstadoPlan = new System.Windows.Forms.ComboBox();
            this.lblPlanReparacion = new System.Windows.Forms.Label();
            this.lblEstadoPlan = new System.Windows.Forms.Label();
            this.lblPlanValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.tcPlanes.SuspendLayout();
            this.tpPlanes.SuspendLayout();
            this.tpPlanesDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloPlanes
            // 
            this.lbTituloPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTituloPlanes.AutoSize = true;
            this.lbTituloPlanes.BackColor = System.Drawing.Color.DarkOrange;
            this.lbTituloPlanes.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPlanes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTituloPlanes.Location = new System.Drawing.Point(225, 30);
            this.lbTituloPlanes.Name = "lbTituloPlanes";
            this.lbTituloPlanes.Size = new System.Drawing.Size(387, 41);
            this.lbTituloPlanes.TabIndex = 0;
            this.lbTituloPlanes.Text = "Planes de Reparación";
            this.lbTituloPlanes.Click += new System.EventHandler(this.lbTituloPlanes_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(756, 45);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvPlanes
            // 
            this.dgvPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPlanes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanes.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvPlanes.Location = new System.Drawing.Point(33, 38);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.Size = new System.Drawing.Size(804, 315);
            this.dgvPlanes.TabIndex = 4;
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarPlan.Location = new System.Drawing.Point(171, 373);
            this.btnAgregarPlan.Name = "btnAgregarPlan";
            this.btnAgregarPlan.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPlan.TabIndex = 5;
            this.btnAgregarPlan.Text = "Agregar";
            this.btnAgregarPlan.UseVisualStyleBackColor = true;
            this.btnAgregarPlan.Click += new System.EventHandler(this.btnAgregarPlan_Click);
            // 
            // btnEliminarPlan
            // 
            this.btnEliminarPlan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarPlan.Location = new System.Drawing.Point(289, 373);
            this.btnEliminarPlan.Name = "btnEliminarPlan";
            this.btnEliminarPlan.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPlan.TabIndex = 6;
            this.btnEliminarPlan.Text = "Eliminar";
            this.btnEliminarPlan.UseVisualStyleBackColor = true;
            this.btnEliminarPlan.Click += new System.EventHandler(this.btnEliminarPlan_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(400, 373);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBusqueda.Location = new System.Drawing.Point(33, 12);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(544, 20);
            this.txbBusqueda.TabIndex = 19;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(583, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tcPlanes
            // 
            this.tcPlanes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPlanes.Controls.Add(this.tpPlanesDatos);
            this.tcPlanes.Controls.Add(this.tpPlanes);
            this.tcPlanes.Location = new System.Drawing.Point(-6, 74);
            this.tcPlanes.Name = "tcPlanes";
            this.tcPlanes.SelectedIndex = 0;
            this.tcPlanes.Size = new System.Drawing.Size(874, 447);
            this.tcPlanes.TabIndex = 23;
            // 
            // tpPlanes
            // 
            this.tpPlanes.BackColor = System.Drawing.Color.DarkOrange;
            this.tpPlanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpPlanes.Controls.Add(this.btnBuscar);
            this.tpPlanes.Controls.Add(this.txbBusqueda);
            this.tpPlanes.Controls.Add(this.btnAgregarPlan);
            this.tpPlanes.Controls.Add(this.dgvPlanes);
            this.tpPlanes.Controls.Add(this.btnEliminarPlan);
            this.tpPlanes.Controls.Add(this.btnModificar);
            this.tpPlanes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tpPlanes.Location = new System.Drawing.Point(4, 22);
            this.tpPlanes.Name = "tpPlanes";
            this.tpPlanes.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlanes.Size = new System.Drawing.Size(866, 421);
            this.tpPlanes.TabIndex = 0;
            this.tpPlanes.Text = "Lista de planes";
            // 
            // tpPlanesDatos
            // 
            this.tpPlanesDatos.BackColor = System.Drawing.Color.DarkOrange;
            this.tpPlanesDatos.Controls.Add(this.btnCancelar);
            this.tpPlanesDatos.Controls.Add(this.btnGuardar);
            this.tpPlanesDatos.Controls.Add(this.lblGama);
            this.tpPlanesDatos.Controls.Add(this.tbxPlazoEntregaPlan);
            this.tpPlanesDatos.Controls.Add(this.cbxPlanReparacion);
            this.tpPlanesDatos.Controls.Add(this.cbxGama);
            this.tpPlanesDatos.Controls.Add(this.lbPlanId);
            this.tpPlanesDatos.Controls.Add(this.tbxValorPlan);
            this.tpPlanesDatos.Controls.Add(this.lblPlazoEntregaPlan);
            this.tpPlanesDatos.Controls.Add(this.cbxEstadoPlan);
            this.tpPlanesDatos.Controls.Add(this.lblPlanReparacion);
            this.tpPlanesDatos.Controls.Add(this.lblEstadoPlan);
            this.tpPlanesDatos.Controls.Add(this.lblPlanValor);
            this.tpPlanesDatos.Location = new System.Drawing.Point(4, 22);
            this.tpPlanesDatos.Name = "tpPlanesDatos";
            this.tpPlanesDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPlanesDatos.Size = new System.Drawing.Size(866, 421);
            this.tpPlanesDatos.TabIndex = 1;
            this.tpPlanesDatos.Text = "Datos planes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(479, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(222, 324);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblGama
            // 
            this.lblGama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGama.AutoSize = true;
            this.lblGama.Location = new System.Drawing.Point(89, 162);
            this.lblGama.Name = "lblGama";
            this.lblGama.Size = new System.Drawing.Size(35, 13);
            this.lblGama.TabIndex = 28;
            this.lblGama.Text = "Gama";
            // 
            // tbxPlazoEntregaPlan
            // 
            this.tbxPlazoEntregaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPlazoEntregaPlan.Location = new System.Drawing.Point(541, 194);
            this.tbxPlazoEntregaPlan.Name = "tbxPlazoEntregaPlan";
            this.tbxPlazoEntregaPlan.Size = new System.Drawing.Size(100, 20);
            this.tbxPlazoEntregaPlan.TabIndex = 32;
            // 
            // cbxPlanReparacion
            // 
            this.cbxPlanReparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPlanReparacion.FormattingEnabled = true;
            this.cbxPlanReparacion.Items.AddRange(new object[] {
            "Cambio de pantalla",
            "Cambio de camara",
            "Cambio de bateria ",
            "Ranura SIM/SD",
            "Altavoces y microfono"});
            this.cbxPlanReparacion.Location = new System.Drawing.Point(92, 122);
            this.cbxPlanReparacion.Name = "cbxPlanReparacion";
            this.cbxPlanReparacion.Size = new System.Drawing.Size(121, 21);
            this.cbxPlanReparacion.TabIndex = 24;
            // 
            // cbxGama
            // 
            this.cbxGama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGama.FormattingEnabled = true;
            this.cbxGama.Items.AddRange(new object[] {
            "Alta",
            "Media Alta",
            "Media ",
            "Baja"});
            this.cbxGama.Location = new System.Drawing.Point(92, 178);
            this.cbxGama.Name = "cbxGama";
            this.cbxGama.Size = new System.Drawing.Size(121, 21);
            this.cbxGama.TabIndex = 29;
            // 
            // lbPlanId
            // 
            this.lbPlanId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlanId.AutoSize = true;
            this.lbPlanId.Location = new System.Drawing.Point(105, 68);
            this.lbPlanId.Name = "lbPlanId";
            this.lbPlanId.Size = new System.Drawing.Size(42, 13);
            this.lbPlanId.TabIndex = 34;
            this.lbPlanId.Text = "Plan ID";
            // 
            // tbxValorPlan
            // 
            this.tbxValorPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxValorPlan.Location = new System.Drawing.Point(544, 138);
            this.tbxValorPlan.Name = "tbxValorPlan";
            this.tbxValorPlan.Size = new System.Drawing.Size(100, 20);
            this.tbxValorPlan.TabIndex = 31;
            // 
            // lblPlazoEntregaPlan
            // 
            this.lblPlazoEntregaPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlazoEntregaPlan.AutoSize = true;
            this.lblPlazoEntregaPlan.Location = new System.Drawing.Point(544, 178);
            this.lblPlazoEntregaPlan.Name = "lblPlazoEntregaPlan";
            this.lblPlazoEntregaPlan.Size = new System.Drawing.Size(87, 13);
            this.lblPlazoEntregaPlan.TabIndex = 27;
            this.lblPlazoEntregaPlan.Text = "Plazo de entrega";
            // 
            // cbxEstadoPlan
            // 
            this.cbxEstadoPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstadoPlan.FormattingEnabled = true;
            this.cbxEstadoPlan.Items.AddRange(new object[] {
            "Preparacion",
            "En Reparacion",
            "Listo"});
            this.cbxEstadoPlan.Location = new System.Drawing.Point(547, 96);
            this.cbxEstadoPlan.Name = "cbxEstadoPlan";
            this.cbxEstadoPlan.Size = new System.Drawing.Size(121, 21);
            this.cbxEstadoPlan.TabIndex = 30;
            // 
            // lblPlanReparacion
            // 
            this.lblPlanReparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlanReparacion.AutoSize = true;
            this.lblPlanReparacion.Location = new System.Drawing.Point(105, 104);
            this.lblPlanReparacion.Name = "lblPlanReparacion";
            this.lblPlanReparacion.Size = new System.Drawing.Size(81, 13);
            this.lblPlanReparacion.TabIndex = 23;
            this.lblPlanReparacion.Text = "Plan reparacion";
            // 
            // lblEstadoPlan
            // 
            this.lblEstadoPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoPlan.AutoSize = true;
            this.lblEstadoPlan.Location = new System.Drawing.Point(560, 68);
            this.lblEstadoPlan.Name = "lblEstadoPlan";
            this.lblEstadoPlan.Size = new System.Drawing.Size(80, 13);
            this.lblEstadoPlan.TabIndex = 26;
            this.lblEstadoPlan.Text = "Estado del plan";
            // 
            // lblPlanValor
            // 
            this.lblPlanValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlanValor.AutoSize = true;
            this.lblPlanValor.Location = new System.Drawing.Point(560, 122);
            this.lblPlanValor.Name = "lblPlanValor";
            this.lblPlanValor.Size = new System.Drawing.Size(71, 13);
            this.lblPlanValor.TabIndex = 25;
            this.lblPlanValor.Text = "Valor del plan";
            // 
            // PlanesRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(859, 508);
            this.Controls.Add(this.tcPlanes);
            this.Controls.Add(this.lbTituloPlanes);
            this.Controls.Add(this.btnCerrar);
            this.Name = "PlanesRepForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.tcPlanes.ResumeLayout(false);
            this.tpPlanes.ResumeLayout(false);
            this.tpPlanes.PerformLayout();
            this.tpPlanesDatos.ResumeLayout(false);
            this.tpPlanesDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloPlanes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.Button btnAgregarPlan;
        private System.Windows.Forms.Button btnEliminarPlan;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabControl tcPlanes;
        private System.Windows.Forms.TabPage tpPlanesDatos;
        private System.Windows.Forms.Label lblGama;
        private System.Windows.Forms.TextBox tbxPlazoEntregaPlan;
        private System.Windows.Forms.ComboBox cbxPlanReparacion;
        private System.Windows.Forms.ComboBox cbxGama;
        private System.Windows.Forms.Label lbPlanId;
        private System.Windows.Forms.TextBox tbxValorPlan;
        private System.Windows.Forms.Label lblPlazoEntregaPlan;
        private System.Windows.Forms.ComboBox cbxEstadoPlan;
        private System.Windows.Forms.Label lblPlanReparacion;
        private System.Windows.Forms.Label lblEstadoPlan;
        private System.Windows.Forms.Label lblPlanValor;
        private System.Windows.Forms.TabPage tpPlanes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}