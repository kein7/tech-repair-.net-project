namespace TechRepair
{
    partial class OrdenesForm
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
            this.tpOrdenes = new System.Windows.Forms.TabPage();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.lbTituloOrdenes = new System.Windows.Forms.Label();
            this.tcOrdenes = new System.Windows.Forms.TabControl();
            this.tpDatosOrden = new System.Windows.Forms.TabPage();
            this.lblOrdenId = new System.Windows.Forms.Label();
            this.tcDatosOrden = new System.Windows.Forms.TabControl();
            this.tpTelefono = new System.Windows.Forms.TabPage();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicio_tecnicoDataSet = new TechRepair.servicio_tecnicoDataSet();
            this.cbxPlan = new System.Windows.Forms.ComboBox();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblGama = new System.Windows.Forms.Label();
            this.cbxGama = new System.Windows.Forms.ComboBox();
            this.gamasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxNumeroSerie = new System.Windows.Forms.TextBox();
            this.lblPlanReparacion = new System.Windows.Forms.Label();
            this.lblEstadoPlan = new System.Windows.Forms.Label();
            this.lblPlanValor = new System.Windows.Forms.Label();
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblDireccionId = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.txbRutCliente = new System.Windows.Forms.TextBox();
            this.txbNumDep = new System.Windows.Forms.TextBox();
            this.lbNumDep = new System.Windows.Forms.Label();
            this.txbNumCalle = new System.Windows.Forms.TextBox();
            this.lbNumCalle = new System.Windows.Forms.Label();
            this.cbxComuna = new System.Windows.Forms.ComboBox();
            this.comunasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbApellidoMat = new System.Windows.Forms.TextBox();
            this.lbApellidoMat = new System.Windows.Forms.Label();
            this.txbApellidoPat = new System.Windows.Forms.TextBox();
            this.lbApellidoPat = new System.Windows.Forms.Label();
            this.txbNombresCliente = new System.Windows.Forms.TextBox();
            this.lbComuna = new System.Windows.Forms.Label();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNumTelefono = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbRut = new System.Windows.Forms.Label();
            this.lblNumTelefono = new System.Windows.Forms.Label();
            this.tpTercero = new System.Windows.Forms.TabPage();
            this.btnAtras2 = new System.Windows.Forms.Button();
            this.txbRutTercero = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbApellidoMaternoTercero = new System.Windows.Forms.TextBox();
            this.lbApellidoMaternoTercero = new System.Windows.Forms.Label();
            this.txbApellidoPaternoTercero = new System.Windows.Forms.TextBox();
            this.lbApellidoPaternoTercero = new System.Windows.Forms.Label();
            this.txbNombreTercero = new System.Windows.Forms.TextBox();
            this.lbNombretercero = new System.Windows.Forms.Label();
            this.txbCodigoTercero = new System.Windows.Forms.TextBox();
            this.lbRutTercero = new System.Windows.Forms.Label();
            this.lbCodigoTercero = new System.Windows.Forms.Label();
            this.lbDatosOrden = new System.Windows.Forms.Label();
            this.comunasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comunasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gamasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciotecnicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comunasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.marcasTableAdapter();
            this.gamasTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.gamasTableAdapter();
            this.planesTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.planesTableAdapter();
            this.comunasTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.comunasTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.tcOrdenes.SuspendLayout();
            this.tpDatosOrden.SuspendLayout();
            this.tcDatosOrden.SuspendLayout();
            this.tpTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicio_tecnicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource2)).BeginInit();
            this.tpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource3)).BeginInit();
            this.tpTercero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciotecnicoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpOrdenes
            // 
            this.tpOrdenes.BackColor = System.Drawing.Color.DarkOrange;
            this.tpOrdenes.Controls.Add(this.button1);
            this.tpOrdenes.Controls.Add(this.btnModificarOrden);
            this.tpOrdenes.Controls.Add(this.btnEliminarOrden);
            this.tpOrdenes.Controls.Add(this.btnAgregarOrden);
            this.tpOrdenes.Controls.Add(this.dgvOrdenes);
            this.tpOrdenes.Controls.Add(this.btnBuscar);
            this.tpOrdenes.Controls.Add(this.txbBusqueda);
            this.tpOrdenes.Controls.Add(this.lbTituloOrdenes);
            this.tpOrdenes.Location = new System.Drawing.Point(4, 22);
            this.tpOrdenes.Name = "tpOrdenes";
            this.tpOrdenes.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrdenes.Size = new System.Drawing.Size(897, 512);
            this.tpOrdenes.TabIndex = 0;
            this.tpOrdenes.Text = "Ordenes";
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Location = new System.Drawing.Point(360, 383);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(75, 23);
            this.btnModificarOrden.TabIndex = 26;
            this.btnModificarOrden.Text = "Modificar";
            this.btnModificarOrden.UseVisualStyleBackColor = true;
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.Location = new System.Drawing.Point(503, 383);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarOrden.TabIndex = 25;
            this.btnEliminarOrden.Text = "Eliminar";
            this.btnEliminarOrden.UseVisualStyleBackColor = true;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(216, 383);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarOrden.TabIndex = 24;
            this.btnAgregarOrden.Text = "Agregar orden";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Location = new System.Drawing.Point(37, 110);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(791, 252);
            this.dgvOrdenes.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(795, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBusqueda.Location = new System.Drawing.Point(37, 84);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(752, 20);
            this.txbBusqueda.TabIndex = 21;
            // 
            // lbTituloOrdenes
            // 
            this.lbTituloOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTituloOrdenes.AutoSize = true;
            this.lbTituloOrdenes.BackColor = System.Drawing.Color.DarkOrange;
            this.lbTituloOrdenes.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloOrdenes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTituloOrdenes.Location = new System.Drawing.Point(218, 20);
            this.lbTituloOrdenes.Name = "lbTituloOrdenes";
            this.lbTituloOrdenes.Size = new System.Drawing.Size(412, 41);
            this.lbTituloOrdenes.TabIndex = 1;
            this.lbTituloOrdenes.Text = "Ordenes de reparación";
            // 
            // tcOrdenes
            // 
            this.tcOrdenes.Controls.Add(this.tpDatosOrden);
            this.tcOrdenes.Controls.Add(this.tpOrdenes);
            this.tcOrdenes.Location = new System.Drawing.Point(-7, 1);
            this.tcOrdenes.Name = "tcOrdenes";
            this.tcOrdenes.SelectedIndex = 0;
            this.tcOrdenes.Size = new System.Drawing.Size(905, 538);
            this.tcOrdenes.TabIndex = 2;
            // 
            // tpDatosOrden
            // 
            this.tpDatosOrden.BackColor = System.Drawing.Color.DarkOrange;
            this.tpDatosOrden.Controls.Add(this.lblOrdenId);
            this.tpDatosOrden.Controls.Add(this.btnCerrar);
            this.tpDatosOrden.Controls.Add(this.tcDatosOrden);
            this.tpDatosOrden.Controls.Add(this.lbDatosOrden);
            this.tpDatosOrden.Location = new System.Drawing.Point(4, 22);
            this.tpDatosOrden.Name = "tpDatosOrden";
            this.tpDatosOrden.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosOrden.Size = new System.Drawing.Size(897, 512);
            this.tpDatosOrden.TabIndex = 1;
            this.tpDatosOrden.Text = "Datos Orden";
            // 
            // lblOrdenId
            // 
            this.lblOrdenId.AutoSize = true;
            this.lblOrdenId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblOrdenId.Location = new System.Drawing.Point(609, 34);
            this.lblOrdenId.Name = "lblOrdenId";
            this.lblOrdenId.Size = new System.Drawing.Size(0, 24);
            this.lblOrdenId.TabIndex = 55;
            // 
            // tcDatosOrden
            // 
            this.tcDatosOrden.Controls.Add(this.tpTelefono);
            this.tcDatosOrden.Controls.Add(this.tpCliente);
            this.tcDatosOrden.Controls.Add(this.tpTercero);
            this.tcDatosOrden.Location = new System.Drawing.Point(6, 83);
            this.tcDatosOrden.Name = "tcDatosOrden";
            this.tcDatosOrden.Padding = new System.Drawing.Point(0, 0);
            this.tcDatosOrden.SelectedIndex = 0;
            this.tcDatosOrden.Size = new System.Drawing.Size(860, 413);
            this.tcDatosOrden.TabIndex = 5;
            // 
            // tpTelefono
            // 
            this.tpTelefono.BackColor = System.Drawing.Color.DarkOrange;
            this.tpTelefono.Controls.Add(this.cbxMarca);
            this.tpTelefono.Controls.Add(this.cbxPlan);
            this.tpTelefono.Controls.Add(this.cbxColor);
            this.tpTelefono.Controls.Add(this.lblColor);
            this.tpTelefono.Controls.Add(this.txbModelo);
            this.tpTelefono.Controls.Add(this.lblModelo);
            this.tpTelefono.Controls.Add(this.btnSiguiente);
            this.tpTelefono.Controls.Add(this.lblGama);
            this.tpTelefono.Controls.Add(this.cbxGama);
            this.tpTelefono.Controls.Add(this.tbxNumeroSerie);
            this.tpTelefono.Controls.Add(this.lblPlanReparacion);
            this.tpTelefono.Controls.Add(this.lblEstadoPlan);
            this.tpTelefono.Controls.Add(this.lblPlanValor);
            this.tpTelefono.Location = new System.Drawing.Point(4, 22);
            this.tpTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.tpTelefono.Name = "tpTelefono";
            this.tpTelefono.Size = new System.Drawing.Size(852, 387);
            this.tpTelefono.TabIndex = 0;
            this.tpTelefono.Text = "Telefono";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataSource = this.marcasBindingSource1;
            this.cbxMarca.DisplayMember = "marca_telefono";
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(74, 112);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(218, 21);
            this.cbxMarca.TabIndex = 1;
            this.cbxMarca.ValueMember = "marca_telefono";
            // 
            // marcasBindingSource1
            // 
            this.marcasBindingSource1.DataMember = "marcas";
            this.marcasBindingSource1.DataSource = this.servicio_tecnicoDataSet;
            // 
            // servicio_tecnicoDataSet
            // 
            this.servicio_tecnicoDataSet.DataSetName = "servicio_tecnicoDataSet";
            this.servicio_tecnicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPlan
            // 
            this.cbxPlan.DataSource = this.planesBindingSource;
            this.cbxPlan.DisplayMember = "plan_reparacion";
            this.cbxPlan.FormattingEnabled = true;
            this.cbxPlan.Location = new System.Drawing.Point(74, 224);
            this.cbxPlan.Name = "cbxPlan";
            this.cbxPlan.Size = new System.Drawing.Size(218, 21);
            this.cbxPlan.TabIndex = 3;
            this.cbxPlan.ValueMember = "plan_reparacion";
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.servicio_tecnicoDataSet;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Purple",
            "Orange",
            "Pink",
            "Black",
            "White",
            "Brown",
            "Gray",
            "Cyan",
            "Magenta",
            "Lime",
            "Teal",
            "Silver",
            "Gold",
            "Navy",
            "Maroon",
            "Indigo"});
            this.cbxColor.Location = new System.Drawing.Point(432, 224);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(287, 21);
            this.cbxColor.TabIndex = 6;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(426, 197);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 52;
            this.lblColor.Text = "Color";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(432, 151);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(233, 20);
            this.txbModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(426, 132);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 50;
            this.lblModelo.Text = "Modelo";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(543, 291);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(90, 23);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblGama
            // 
            this.lblGama.AutoSize = true;
            this.lblGama.Location = new System.Drawing.Point(68, 148);
            this.lblGama.Name = "lblGama";
            this.lblGama.Size = new System.Drawing.Size(35, 13);
            this.lblGama.TabIndex = 42;
            this.lblGama.Text = "Gama";
            // 
            // cbxGama
            // 
            this.cbxGama.DataSource = this.gamasBindingSource2;
            this.cbxGama.DisplayMember = "tipo_de_gama";
            this.cbxGama.FormattingEnabled = true;
            this.cbxGama.Location = new System.Drawing.Point(74, 167);
            this.cbxGama.Name = "cbxGama";
            this.cbxGama.Size = new System.Drawing.Size(218, 21);
            this.cbxGama.TabIndex = 2;
            this.cbxGama.ValueMember = "tipo_de_gama";
            // 
            // gamasBindingSource2
            // 
            this.gamasBindingSource2.DataMember = "gamas";
            this.gamasBindingSource2.DataSource = this.servicio_tecnicoDataSet;
            // 
            // tbxNumeroSerie
            // 
            this.tbxNumeroSerie.Location = new System.Drawing.Point(432, 66);
            this.tbxNumeroSerie.Name = "tbxNumeroSerie";
            this.tbxNumeroSerie.Size = new System.Drawing.Size(233, 20);
            this.tbxNumeroSerie.TabIndex = 4;
            // 
            // lblPlanReparacion
            // 
            this.lblPlanReparacion.AutoSize = true;
            this.lblPlanReparacion.Location = new System.Drawing.Point(68, 85);
            this.lblPlanReparacion.Name = "lblPlanReparacion";
            this.lblPlanReparacion.Size = new System.Drawing.Size(37, 13);
            this.lblPlanReparacion.TabIndex = 37;
            this.lblPlanReparacion.Text = "Marca";
            // 
            // lblEstadoPlan
            // 
            this.lblEstadoPlan.AutoSize = true;
            this.lblEstadoPlan.Location = new System.Drawing.Point(68, 197);
            this.lblEstadoPlan.Name = "lblEstadoPlan";
            this.lblEstadoPlan.Size = new System.Drawing.Size(96, 13);
            this.lblEstadoPlan.TabIndex = 40;
            this.lblEstadoPlan.Text = "Plan de reparación";
            // 
            // lblPlanValor
            // 
            this.lblPlanValor.AutoSize = true;
            this.lblPlanValor.Location = new System.Drawing.Point(426, 47);
            this.lblPlanValor.Name = "lblPlanValor";
            this.lblPlanValor.Size = new System.Drawing.Size(84, 13);
            this.lblPlanValor.TabIndex = 39;
            this.lblPlanValor.Text = "Numero de serie";
            // 
            // tpCliente
            // 
            this.tpCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.tpCliente.Controls.Add(this.cbxRegion);
            this.tpCliente.Controls.Add(this.lblRegion);
            this.tpCliente.Controls.Add(this.lblDireccionId);
            this.tpCliente.Controls.Add(this.btnAtras);
            this.tpCliente.Controls.Add(this.txbRutCliente);
            this.tpCliente.Controls.Add(this.txbNumDep);
            this.tpCliente.Controls.Add(this.lbNumDep);
            this.tpCliente.Controls.Add(this.txbNumCalle);
            this.tpCliente.Controls.Add(this.lbNumCalle);
            this.tpCliente.Controls.Add(this.cbxComuna);
            this.tpCliente.Controls.Add(this.txbEmail);
            this.tpCliente.Controls.Add(this.lbEmail);
            this.tpCliente.Controls.Add(this.txbApellidoMat);
            this.tpCliente.Controls.Add(this.lbApellidoMat);
            this.tpCliente.Controls.Add(this.txbApellidoPat);
            this.tpCliente.Controls.Add(this.lbApellidoPat);
            this.tpCliente.Controls.Add(this.txbNombresCliente);
            this.tpCliente.Controls.Add(this.lbComuna);
            this.tpCliente.Controls.Add(this.btnSiguiente2);
            this.tpCliente.Controls.Add(this.lbNombre);
            this.tpCliente.Controls.Add(this.txbDireccion);
            this.tpCliente.Controls.Add(this.txbNumTelefono);
            this.tpCliente.Controls.Add(this.lbDireccion);
            this.tpCliente.Controls.Add(this.lbRut);
            this.tpCliente.Controls.Add(this.lblNumTelefono);
            this.tpCliente.Location = new System.Drawing.Point(4, 22);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(852, 387);
            this.tpCliente.TabIndex = 1;
            this.tpCliente.Text = "Cliente";
            // 
            // cbxRegion
            // 
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Location = new System.Drawing.Point(430, 139);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(233, 21);
            this.cbxRegion.TabIndex = 9;
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(427, 123);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 86;
            this.lblRegion.Text = "Region";
            // 
            // lblDireccionId
            // 
            this.lblDireccionId.AutoSize = true;
            this.lblDireccionId.Location = new System.Drawing.Point(427, 267);
            this.lblDireccionId.Name = "lblDireccionId";
            this.lblDireccionId.Size = new System.Drawing.Size(66, 13);
            this.lblDireccionId.TabIndex = 85;
            this.lblDireccionId.Text = "Direccion ID";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(478, 320);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(90, 23);
            this.btnAtras.TabIndex = 84;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // txbRutCliente
            // 
            this.txbRutCliente.Location = new System.Drawing.Point(72, 47);
            this.txbRutCliente.Name = "txbRutCliente";
            this.txbRutCliente.Size = new System.Drawing.Size(233, 20);
            this.txbRutCliente.TabIndex = 1;
            // 
            // txbNumDep
            // 
            this.txbNumDep.Location = new System.Drawing.Point(430, 227);
            this.txbNumDep.Name = "txbNumDep";
            this.txbNumDep.Size = new System.Drawing.Size(233, 20);
            this.txbNumDep.TabIndex = 11;
            // 
            // lbNumDep
            // 
            this.lbNumDep.AutoSize = true;
            this.lbNumDep.Location = new System.Drawing.Point(427, 211);
            this.lbNumDep.Name = "lbNumDep";
            this.lbNumDep.Size = new System.Drawing.Size(127, 13);
            this.lbNumDep.TabIndex = 81;
            this.lbNumDep.Text = "Numero de departamento";
            // 
            // txbNumCalle
            // 
            this.txbNumCalle.Location = new System.Drawing.Point(430, 179);
            this.txbNumCalle.Name = "txbNumCalle";
            this.txbNumCalle.Size = new System.Drawing.Size(233, 20);
            this.txbNumCalle.TabIndex = 10;
            // 
            // lbNumCalle
            // 
            this.lbNumCalle.AutoSize = true;
            this.lbNumCalle.Location = new System.Drawing.Point(427, 163);
            this.lbNumCalle.Name = "lbNumCalle";
            this.lbNumCalle.Size = new System.Drawing.Size(84, 13);
            this.lbNumCalle.TabIndex = 79;
            this.lbNumCalle.Text = "Numero de calle";
            // 
            // cbxComuna
            // 
            this.cbxComuna.DataSource = this.comunasBindingSource3;
            this.cbxComuna.DisplayMember = "nombre_comuna";
            this.cbxComuna.FormattingEnabled = true;
            this.cbxComuna.Location = new System.Drawing.Point(430, 94);
            this.cbxComuna.Name = "cbxComuna";
            this.cbxComuna.Size = new System.Drawing.Size(233, 21);
            this.cbxComuna.TabIndex = 8;
            this.cbxComuna.ValueMember = "nombre_comuna";
            // 
            // comunasBindingSource3
            // 
            this.comunasBindingSource3.DataMember = "comunas";
            this.comunasBindingSource3.DataSource = this.servicio_tecnicoDataSet;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(72, 277);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(233, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(69, 261);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 75;
            this.lbEmail.Text = "Email";
            // 
            // txbApellidoMat
            // 
            this.txbApellidoMat.Location = new System.Drawing.Point(72, 179);
            this.txbApellidoMat.Name = "txbApellidoMat";
            this.txbApellidoMat.Size = new System.Drawing.Size(233, 20);
            this.txbApellidoMat.TabIndex = 4;
            // 
            // lbApellidoMat
            // 
            this.lbApellidoMat.AutoSize = true;
            this.lbApellidoMat.Location = new System.Drawing.Point(69, 163);
            this.lbApellidoMat.Name = "lbApellidoMat";
            this.lbApellidoMat.Size = new System.Drawing.Size(86, 13);
            this.lbApellidoMat.TabIndex = 73;
            this.lbApellidoMat.Text = "Apellido Materno";
            // 
            // txbApellidoPat
            // 
            this.txbApellidoPat.Location = new System.Drawing.Point(72, 137);
            this.txbApellidoPat.Name = "txbApellidoPat";
            this.txbApellidoPat.Size = new System.Drawing.Size(233, 20);
            this.txbApellidoPat.TabIndex = 3;
            // 
            // lbApellidoPat
            // 
            this.lbApellidoPat.AutoSize = true;
            this.lbApellidoPat.Location = new System.Drawing.Point(69, 121);
            this.lbApellidoPat.Name = "lbApellidoPat";
            this.lbApellidoPat.Size = new System.Drawing.Size(84, 13);
            this.lbApellidoPat.TabIndex = 71;
            this.lbApellidoPat.Text = "Apellido Paterno";
            // 
            // txbNombresCliente
            // 
            this.txbNombresCliente.Location = new System.Drawing.Point(72, 94);
            this.txbNombresCliente.Name = "txbNombresCliente";
            this.txbNombresCliente.Size = new System.Drawing.Size(233, 20);
            this.txbNombresCliente.TabIndex = 2;
            // 
            // lbComuna
            // 
            this.lbComuna.AutoSize = true;
            this.lbComuna.Location = new System.Drawing.Point(427, 78);
            this.lbComuna.Name = "lbComuna";
            this.lbComuna.Size = new System.Drawing.Size(46, 13);
            this.lbComuna.TabIndex = 66;
            this.lbComuna.Text = "Comuna";
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Location = new System.Drawing.Point(583, 320);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(90, 23);
            this.btnSiguiente2.TabIndex = 12;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(69, 78);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(49, 13);
            this.lbNombre.TabIndex = 59;
            this.lbNombre.Text = "Nombres";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(430, 53);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(233, 20);
            this.txbDireccion.TabIndex = 7;
            // 
            // txbNumTelefono
            // 
            this.txbNumTelefono.Location = new System.Drawing.Point(72, 227);
            this.txbNumTelefono.Name = "txbNumTelefono";
            this.txbNumTelefono.Size = new System.Drawing.Size(233, 20);
            this.txbNumTelefono.TabIndex = 5;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(427, 37);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 58;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbRut
            // 
            this.lbRut.AutoSize = true;
            this.lbRut.Location = new System.Drawing.Point(69, 31);
            this.lbRut.Name = "lbRut";
            this.lbRut.Size = new System.Drawing.Size(59, 13);
            this.lbRut.TabIndex = 54;
            this.lbRut.Text = "Rut Cliente";
            // 
            // lblNumTelefono
            // 
            this.lblNumTelefono.AutoSize = true;
            this.lblNumTelefono.Location = new System.Drawing.Point(69, 211);
            this.lblNumTelefono.Name = "lblNumTelefono";
            this.lblNumTelefono.Size = new System.Drawing.Size(100, 13);
            this.lblNumTelefono.TabIndex = 56;
            this.lblNumTelefono.Text = "Numero de telefono";
            // 
            // tpTercero
            // 
            this.tpTercero.BackColor = System.Drawing.Color.DarkOrange;
            this.tpTercero.Controls.Add(this.btnAtras2);
            this.tpTercero.Controls.Add(this.txbRutTercero);
            this.tpTercero.Controls.Add(this.btnGuardar);
            this.tpTercero.Controls.Add(this.txbApellidoMaternoTercero);
            this.tpTercero.Controls.Add(this.lbApellidoMaternoTercero);
            this.tpTercero.Controls.Add(this.txbApellidoPaternoTercero);
            this.tpTercero.Controls.Add(this.lbApellidoPaternoTercero);
            this.tpTercero.Controls.Add(this.txbNombreTercero);
            this.tpTercero.Controls.Add(this.lbNombretercero);
            this.tpTercero.Controls.Add(this.txbCodigoTercero);
            this.tpTercero.Controls.Add(this.lbRutTercero);
            this.tpTercero.Controls.Add(this.lbCodigoTercero);
            this.tpTercero.Location = new System.Drawing.Point(4, 22);
            this.tpTercero.Name = "tpTercero";
            this.tpTercero.Padding = new System.Windows.Forms.Padding(3);
            this.tpTercero.Size = new System.Drawing.Size(852, 387);
            this.tpTercero.TabIndex = 2;
            this.tpTercero.Text = "Tercero";
            // 
            // btnAtras2
            // 
            this.btnAtras2.Location = new System.Drawing.Point(396, 288);
            this.btnAtras2.Name = "btnAtras2";
            this.btnAtras2.Size = new System.Drawing.Size(90, 23);
            this.btnAtras2.TabIndex = 87;
            this.btnAtras2.Text = "Atras";
            this.btnAtras2.UseVisualStyleBackColor = true;
            this.btnAtras2.Click += new System.EventHandler(this.btnAtras2_Click);
            // 
            // txbRutTercero
            // 
            this.txbRutTercero.Location = new System.Drawing.Point(106, 85);
            this.txbRutTercero.Name = "txbRutTercero";
            this.txbRutTercero.Size = new System.Drawing.Size(233, 20);
            this.txbRutTercero.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(506, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txbApellidoMaternoTercero
            // 
            this.txbApellidoMaternoTercero.Location = new System.Drawing.Point(409, 108);
            this.txbApellidoMaternoTercero.Name = "txbApellidoMaternoTercero";
            this.txbApellidoMaternoTercero.Size = new System.Drawing.Size(233, 20);
            this.txbApellidoMaternoTercero.TabIndex = 4;
            // 
            // lbApellidoMaternoTercero
            // 
            this.lbApellidoMaternoTercero.AutoSize = true;
            this.lbApellidoMaternoTercero.Location = new System.Drawing.Point(406, 92);
            this.lbApellidoMaternoTercero.Name = "lbApellidoMaternoTercero";
            this.lbApellidoMaternoTercero.Size = new System.Drawing.Size(86, 13);
            this.lbApellidoMaternoTercero.TabIndex = 83;
            this.lbApellidoMaternoTercero.Text = "Apellido Materno";
            // 
            // txbApellidoPaternoTercero
            // 
            this.txbApellidoPaternoTercero.Location = new System.Drawing.Point(409, 66);
            this.txbApellidoPaternoTercero.Name = "txbApellidoPaternoTercero";
            this.txbApellidoPaternoTercero.Size = new System.Drawing.Size(233, 20);
            this.txbApellidoPaternoTercero.TabIndex = 3;
            // 
            // lbApellidoPaternoTercero
            // 
            this.lbApellidoPaternoTercero.AutoSize = true;
            this.lbApellidoPaternoTercero.Location = new System.Drawing.Point(406, 50);
            this.lbApellidoPaternoTercero.Name = "lbApellidoPaternoTercero";
            this.lbApellidoPaternoTercero.Size = new System.Drawing.Size(84, 13);
            this.lbApellidoPaternoTercero.TabIndex = 81;
            this.lbApellidoPaternoTercero.Text = "Apellido Paterno";
            // 
            // txbNombreTercero
            // 
            this.txbNombreTercero.Location = new System.Drawing.Point(106, 124);
            this.txbNombreTercero.Name = "txbNombreTercero";
            this.txbNombreTercero.Size = new System.Drawing.Size(233, 20);
            this.txbNombreTercero.TabIndex = 2;
            // 
            // lbNombretercero
            // 
            this.lbNombretercero.AutoSize = true;
            this.lbNombretercero.Location = new System.Drawing.Point(103, 108);
            this.lbNombretercero.Name = "lbNombretercero";
            this.lbNombretercero.Size = new System.Drawing.Size(49, 13);
            this.lbNombretercero.TabIndex = 78;
            this.lbNombretercero.Text = "Nombres";
            // 
            // txbCodigoTercero
            // 
            this.txbCodigoTercero.Location = new System.Drawing.Point(409, 156);
            this.txbCodigoTercero.Name = "txbCodigoTercero";
            this.txbCodigoTercero.Size = new System.Drawing.Size(233, 20);
            this.txbCodigoTercero.TabIndex = 5;
            // 
            // lbRutTercero
            // 
            this.lbRutTercero.AutoSize = true;
            this.lbRutTercero.Location = new System.Drawing.Point(103, 61);
            this.lbRutTercero.Name = "lbRutTercero";
            this.lbRutTercero.Size = new System.Drawing.Size(64, 13);
            this.lbRutTercero.TabIndex = 75;
            this.lbRutTercero.Text = "Rut Tercero";
            // 
            // lbCodigoTercero
            // 
            this.lbCodigoTercero.AutoSize = true;
            this.lbCodigoTercero.Location = new System.Drawing.Point(406, 140);
            this.lbCodigoTercero.Name = "lbCodigoTercero";
            this.lbCodigoTercero.Size = new System.Drawing.Size(80, 13);
            this.lbCodigoTercero.TabIndex = 77;
            this.lbCodigoTercero.Text = "Codigo Tercero";
            // 
            // lbDatosOrden
            // 
            this.lbDatosOrden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDatosOrden.AutoSize = true;
            this.lbDatosOrden.BackColor = System.Drawing.Color.DarkOrange;
            this.lbDatosOrden.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatosOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDatosOrden.Location = new System.Drawing.Point(253, 17);
            this.lbDatosOrden.Name = "lbDatosOrden";
            this.lbDatosOrden.Size = new System.Drawing.Size(325, 41);
            this.lbDatosOrden.TabIndex = 2;
            this.lbDatosOrden.Text = "Datos de la Orden";
            // 
            // comunasBindingSource4
            // 
            this.comunasBindingSource4.DataMember = "comunas";
            this.comunasBindingSource4.DataSource = this.servicio_tecnicoDataSet;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            // 
            // comunasBindingSource2
            // 
            this.comunasBindingSource2.DataMember = "comunas";
            // 
            // gamasBindingSource
            // 
            this.gamasBindingSource.DataMember = "gamas";
            this.gamasBindingSource.DataSource = this.serviciotecnicoDataSetBindingSource;
            // 
            // gamasBindingSource1
            // 
            this.gamasBindingSource1.DataMember = "gamas";
            this.gamasBindingSource1.DataSource = this.serviciotecnicoDataSetBindingSource;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // gamasTableAdapter
            // 
            this.gamasTableAdapter.ClearBeforeFill = true;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // comunasTableAdapter
            // 
            this.comunasTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(791, 54);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(795, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrdenesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(898, 539);
            this.Controls.Add(this.tcOrdenes);
            this.Name = "OrdenesForm";
            this.Text = "OrdenesForm";
            this.Load += new System.EventHandler(this.OrdenesForm_Load);
            this.tpOrdenes.ResumeLayout(false);
            this.tpOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.tcOrdenes.ResumeLayout(false);
            this.tpDatosOrden.ResumeLayout(false);
            this.tpDatosOrden.PerformLayout();
            this.tcDatosOrden.ResumeLayout(false);
            this.tpTelefono.ResumeLayout(false);
            this.tpTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicio_tecnicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamasBindingSource2)).EndInit();
            this.tpCliente.ResumeLayout(false);
            this.tpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource3)).EndInit();
            this.tpTercero.ResumeLayout(false);
            this.tpTercero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciotecnicoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpOrdenes;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnEliminarOrden;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Label lbTituloOrdenes;
        private System.Windows.Forms.TabControl tcOrdenes;
        private System.Windows.Forms.TabPage tpDatosOrden;
        private System.Windows.Forms.TabControl tcDatosOrden;
        private System.Windows.Forms.TabPage tpTelefono;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblGama;
        private System.Windows.Forms.ComboBox cbxGama;
        private System.Windows.Forms.TextBox tbxNumeroSerie;
        private System.Windows.Forms.Label lblPlanReparacion;
        private System.Windows.Forms.Label lblEstadoPlan;
        private System.Windows.Forms.Label lblPlanValor;
        private System.Windows.Forms.TabPage tpCliente;
        private System.Windows.Forms.TextBox txbRutCliente;
        private System.Windows.Forms.TextBox txbNumDep;
        private System.Windows.Forms.Label lbNumDep;
        private System.Windows.Forms.TextBox txbNumCalle;
        private System.Windows.Forms.Label lbNumCalle;
        private System.Windows.Forms.ComboBox cbxComuna;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbApellidoMat;
        private System.Windows.Forms.Label lbApellidoMat;
        private System.Windows.Forms.TextBox txbApellidoPat;
        private System.Windows.Forms.Label lbApellidoPat;
        private System.Windows.Forms.TextBox txbNombresCliente;
        private System.Windows.Forms.Label lbComuna;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbNumTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbRut;
        private System.Windows.Forms.Label lblNumTelefono;
        private System.Windows.Forms.TabPage tpTercero;
        private System.Windows.Forms.TextBox txbRutTercero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbApellidoMaternoTercero;
        private System.Windows.Forms.Label lbApellidoMaternoTercero;
        private System.Windows.Forms.TextBox txbApellidoPaternoTercero;
        private System.Windows.Forms.Label lbApellidoPaternoTercero;
        private System.Windows.Forms.TextBox txbNombreTercero;
        private System.Windows.Forms.Label lbNombretercero;
        private System.Windows.Forms.TextBox txbCodigoTercero;
        private System.Windows.Forms.Label lbRutTercero;
        private System.Windows.Forms.Label lbCodigoTercero;
        private System.Windows.Forms.Label lbDatosOrden;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAtras2;
        private System.Windows.Forms.ComboBox cbxPlan;
        private System.Windows.Forms.Label lblOrdenId;
        private System.Windows.Forms.Label lblDireccionId;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.Label lblRegion;

        private System.Windows.Forms.BindingSource serviciotecnicoDataSetBindingSource;

        private System.Windows.Forms.BindingSource comunasBindingSource;


        private System.Windows.Forms.BindingSource comunasBindingSource1;

        private System.Windows.Forms.BindingSource gamasBindingSource;

        private System.Windows.Forms.BindingSource comunasBindingSource2;

        private System.Windows.Forms.BindingSource gamasBindingSource1;
 
        private System.Windows.Forms.BindingSource marcasBindingSource;

        private System.Windows.Forms.ComboBox cbxMarca;
        private servicio_tecnicoDataSet servicio_tecnicoDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource1;
        private servicio_tecnicoDataSetTableAdapters.marcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource gamasBindingSource2;
        private servicio_tecnicoDataSetTableAdapters.gamasTableAdapter gamasTableAdapter;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private servicio_tecnicoDataSetTableAdapters.planesTableAdapter planesTableAdapter;
        private System.Windows.Forms.BindingSource comunasBindingSource3;
        private servicio_tecnicoDataSetTableAdapters.comunasTableAdapter comunasTableAdapter;
        private System.Windows.Forms.BindingSource comunasBindingSource4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
    }
}