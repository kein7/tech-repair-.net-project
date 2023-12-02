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
            this.components = new System.ComponentModel.Container();
            this.lbTituloPlanes = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvPlanes = new System.Windows.Forms.DataGridView();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            this.btnEliminarPlan = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tcPlanes = new System.Windows.Forms.TabControl();
            this.tpPlanesDatos = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblGama = new System.Windows.Forms.Label();
            this.tbxPlazoEntregaPlan = new System.Windows.Forms.TextBox();
            this.cbxPlanReparacion = new System.Windows.Forms.ComboBox();
            this.cbxGama = new System.Windows.Forms.ComboBox();
            this.gamasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbPlanId = new System.Windows.Forms.Label();
            this.tbxValorPlan = new System.Windows.Forms.TextBox();
            this.lblPlazoEntregaPlan = new System.Windows.Forms.Label();
            this.cbxEstadoPlan = new System.Windows.Forms.ComboBox();
            this.lblPlanReparacion = new System.Windows.Forms.Label();
            this.lblEstadoPlan = new System.Windows.Forms.Label();
            this.lblPlanValor = new System.Windows.Forms.Label();
            this.tpPlanes = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.servicio_tecnicoDataSet = new TechRepair.servicio_tecnicoDataSet();
            this.gamasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamasTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.gamasTableAdapter();
            this.fKplanestmgama09A971A2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.planesTableAdapter();
            this.fKplanestmgama09A971A2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gamasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gamasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).BeginInit();
            this.tcPlanes.SuspendLayout();
            this.tpPlanesDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).BeginInit();
            this.tpPlanes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicio_tecnicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKplanestmgama09A971A2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKplanestmgama09A971A2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource3)).BeginInit();
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
            this.lbTituloPlanes.Location = new System.Drawing.Point(241, 29);
            this.lbTituloPlanes.Name = "lbTituloPlanes";
            this.lbTituloPlanes.Size = new System.Drawing.Size(387, 41);
            this.lbTituloPlanes.TabIndex = 0;
            this.lbTituloPlanes.Text = "Planes de Reparación";
            this.lbTituloPlanes.Click += new System.EventHandler(this.lbTituloPlanes_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(737, 94);
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
            this.dgvPlanes.Location = new System.Drawing.Point(33, 109);
            this.dgvPlanes.Name = "dgvPlanes";
            this.dgvPlanes.Size = new System.Drawing.Size(805, 295);
            this.dgvPlanes.TabIndex = 4;
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarPlan.Location = new System.Drawing.Point(171, 424);
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
            this.btnEliminarPlan.Location = new System.Drawing.Point(289, 424);
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
            this.btnModificar.Location = new System.Drawing.Point(400, 424);
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
            this.txbBusqueda.Location = new System.Drawing.Point(33, 83);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(545, 20);
            this.txbBusqueda.TabIndex = 19;
            this.txbBusqueda.TextChanged += new System.EventHandler(this.txbBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(584, 80);
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
            this.tcPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPlanes.Location = new System.Drawing.Point(-7, 0);
            this.tcPlanes.Name = "tcPlanes";
            this.tcPlanes.SelectedIndex = 0;
            this.tcPlanes.Size = new System.Drawing.Size(875, 521);
            this.tcPlanes.TabIndex = 23;
            // 
            // tpPlanesDatos
            // 
            this.tpPlanesDatos.BackColor = System.Drawing.Color.DarkOrange;
            this.tpPlanesDatos.Controls.Add(this.btnCancelar);
            this.tpPlanesDatos.Controls.Add(this.btnCerrar);
            this.tpPlanesDatos.Controls.Add(this.lbTituloPlanes);
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
            this.tpPlanesDatos.Size = new System.Drawing.Size(867, 495);
            this.tpPlanesDatos.TabIndex = 1;
            this.tpPlanesDatos.Text = "Datos planes";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(491, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 23);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(234, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblGama
            // 
            this.lblGama.AutoSize = true;
            this.lblGama.Location = new System.Drawing.Point(134, 221);
            this.lblGama.Name = "lblGama";
            this.lblGama.Size = new System.Drawing.Size(35, 13);
            this.lblGama.TabIndex = 28;
            this.lblGama.Text = "Gama";
            // 
            // tbxPlazoEntregaPlan
            // 
            this.tbxPlazoEntregaPlan.Location = new System.Drawing.Point(491, 258);
            this.tbxPlazoEntregaPlan.Name = "tbxPlazoEntregaPlan";
            this.tbxPlazoEntregaPlan.Size = new System.Drawing.Size(233, 20);
            this.tbxPlazoEntregaPlan.TabIndex = 32;
            // 
            // cbxPlanReparacion
            // 
            this.cbxPlanReparacion.FormattingEnabled = true;
            this.cbxPlanReparacion.Items.AddRange(new object[] {
            "Cambio de pantalla",
            "Cambio de camara",
            "Cambio de bateria ",
            "Ranura SIM/SD",
            "Altavoces y microfono"});
            this.cbxPlanReparacion.Location = new System.Drawing.Point(137, 179);
            this.cbxPlanReparacion.Name = "cbxPlanReparacion";
            this.cbxPlanReparacion.Size = new System.Drawing.Size(218, 21);
            this.cbxPlanReparacion.TabIndex = 24;
            // 
            // cbxGama
            // 
            this.cbxGama.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gamasBindingSource3, "tipo_de_gama", true));
            this.cbxGama.DataSource = this.gamasBindingSource2;
            this.cbxGama.DisplayMember = "tipo_de_gama";
            this.cbxGama.FormattingEnabled = true;
            this.cbxGama.Location = new System.Drawing.Point(137, 237);
            this.cbxGama.Name = "cbxGama";
            this.cbxGama.Size = new System.Drawing.Size(218, 21);
            this.cbxGama.TabIndex = 29;
            this.cbxGama.ValueMember = "tipo_de_gama";
            // 
            // gamasBindingSource
            // 
            this.gamasBindingSource.DataMember = "gamas";
            // 
            // lbPlanId
            // 
            this.lbPlanId.AutoSize = true;
            this.lbPlanId.Location = new System.Drawing.Point(134, 116);
            this.lbPlanId.Name = "lbPlanId";
            this.lbPlanId.Size = new System.Drawing.Size(42, 13);
            this.lbPlanId.TabIndex = 34;
            this.lbPlanId.Text = "Plan ID";
            // 
            // tbxValorPlan
            // 
            this.tbxValorPlan.Location = new System.Drawing.Point(491, 199);
            this.tbxValorPlan.Name = "tbxValorPlan";
            this.tbxValorPlan.Size = new System.Drawing.Size(233, 20);
            this.tbxValorPlan.TabIndex = 31;
            // 
            // lblPlazoEntregaPlan
            // 
            this.lblPlazoEntregaPlan.AutoSize = true;
            this.lblPlazoEntregaPlan.Location = new System.Drawing.Point(488, 242);
            this.lblPlazoEntregaPlan.Name = "lblPlazoEntregaPlan";
            this.lblPlazoEntregaPlan.Size = new System.Drawing.Size(87, 13);
            this.lblPlazoEntregaPlan.TabIndex = 27;
            this.lblPlazoEntregaPlan.Text = "Plazo de entrega";
            // 
            // cbxEstadoPlan
            // 
            this.cbxEstadoPlan.FormattingEnabled = true;
            this.cbxEstadoPlan.Items.AddRange(new object[] {
            "Preparacion",
            "En Reparacion",
            "Listo"});
            this.cbxEstadoPlan.Location = new System.Drawing.Point(491, 140);
            this.cbxEstadoPlan.Name = "cbxEstadoPlan";
            this.cbxEstadoPlan.Size = new System.Drawing.Size(287, 21);
            this.cbxEstadoPlan.TabIndex = 30;
            // 
            // lblPlanReparacion
            // 
            this.lblPlanReparacion.AutoSize = true;
            this.lblPlanReparacion.Location = new System.Drawing.Point(134, 158);
            this.lblPlanReparacion.Name = "lblPlanReparacion";
            this.lblPlanReparacion.Size = new System.Drawing.Size(81, 13);
            this.lblPlanReparacion.TabIndex = 23;
            this.lblPlanReparacion.Text = "Plan reparacion";
            // 
            // lblEstadoPlan
            // 
            this.lblEstadoPlan.AutoSize = true;
            this.lblEstadoPlan.Location = new System.Drawing.Point(488, 116);
            this.lblEstadoPlan.Name = "lblEstadoPlan";
            this.lblEstadoPlan.Size = new System.Drawing.Size(80, 13);
            this.lblEstadoPlan.TabIndex = 26;
            this.lblEstadoPlan.Text = "Estado del plan";
            // 
            // lblPlanValor
            // 
            this.lblPlanValor.AutoSize = true;
            this.lblPlanValor.Location = new System.Drawing.Point(488, 183);
            this.lblPlanValor.Name = "lblPlanValor";
            this.lblPlanValor.Size = new System.Drawing.Size(71, 13);
            this.lblPlanValor.TabIndex = 25;
            this.lblPlanValor.Text = "Valor del plan";
            // 
            // tpPlanes
            // 
            this.tpPlanes.BackColor = System.Drawing.Color.DarkOrange;
            this.tpPlanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpPlanes.Controls.Add(this.label1);
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
            this.tpPlanes.Size = new System.Drawing.Size(867, 495);
            this.tpPlanes.TabIndex = 0;
            this.tpPlanes.Text = "Lista de planes";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(241, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "Planes de Reparación";
            // 
            // servicio_tecnicoDataSet
            // 
            this.servicio_tecnicoDataSet.DataSetName = "servicio_tecnicoDataSet";
            this.servicio_tecnicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamasBindingSource1
            // 
            this.gamasBindingSource1.DataMember = "gamas";
            this.gamasBindingSource1.DataSource = this.servicio_tecnicoDataSet;
            // 
            // gamasTableAdapter
            // 
            this.gamasTableAdapter.ClearBeforeFill = true;
            // 
            // fKplanestmgama09A971A2BindingSource
            // 
            this.fKplanestmgama09A971A2BindingSource.DataMember = "FK__planes_tm__gama___09A971A2";
            this.fKplanestmgama09A971A2BindingSource.DataSource = this.gamasBindingSource1;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // fKplanestmgama09A971A2BindingSource1
            // 
            this.fKplanestmgama09A971A2BindingSource1.DataMember = "FK__planes_tm__gama___09A971A2";
            this.fKplanestmgama09A971A2BindingSource1.DataSource = this.gamasBindingSource1;
            // 
            // gamasBindingSource2
            // 
            this.gamasBindingSource2.DataMember = "gamas";
            this.gamasBindingSource2.DataSource = this.servicio_tecnicoDataSet;
            // 
            // gamasBindingSource3
            // 
            this.gamasBindingSource3.DataMember = "gamas";
            this.gamasBindingSource3.DataSource = this.servicio_tecnicoDataSet;
            // 
            // PlanesRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(859, 508);
            this.Controls.Add(this.tcPlanes);
            this.Name = "PlanesRepForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PlanesRepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanes)).EndInit();
            this.tcPlanes.ResumeLayout(false);
            this.tpPlanesDatos.ResumeLayout(false);
            this.tpPlanesDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).EndInit();
            this.tpPlanes.ResumeLayout(false);
            this.tpPlanes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicio_tecnicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKplanestmgama09A971A2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKplanestmgama09A971A2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource3)).EndInit();
            this.ResumeLayout(false);

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

        private System.Windows.Forms.BindingSource gamasBindingSource;
     
        private System.Windows.Forms.Label label1;
        private servicio_tecnicoDataSet servicio_tecnicoDataSet;
        private System.Windows.Forms.BindingSource gamasBindingSource1;
        private servicio_tecnicoDataSetTableAdapters.gamasTableAdapter gamasTableAdapter;
        private System.Windows.Forms.BindingSource fKplanestmgama09A971A2BindingSource;
        private servicio_tecnicoDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.BindingSource gamasBindingSource3;
        private System.Windows.Forms.BindingSource gamasBindingSource2;
        private System.Windows.Forms.BindingSource fKplanestmgama09A971A2BindingSource1;
    }
}