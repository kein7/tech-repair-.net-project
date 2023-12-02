namespace ModernGUI
{
    partial class AdminUsuariosForm
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
            this.lbTituloAdminUsuarios = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tcUsuarios = new System.Windows.Forms.TabControl();
            this.tpListaUsuarios = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tpAdmUsuarios = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tcAdmUsuarios = new System.Windows.Forms.TabControl();
            this.tpModPrivilegiosUsuario = new System.Windows.Forms.TabPage();
            this.cbxModCargo = new System.Windows.Forms.ComboBox();
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciotecnicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicio_tecnicoDataSet = new TechRepair.servicio_tecnicoDataSet();
            this.lbUsuarioCargoDb = new System.Windows.Forms.Label();
            this.lbUsuarioCargo = new System.Windows.Forms.Label();
            this.btnGuardarCargo = new System.Windows.Forms.Button();
            this.lbCargoActualDb = new System.Windows.Forms.Label();
            this.lbCargoActual = new System.Windows.Forms.Label();
            this.lbModificarCargo = new System.Windows.Forms.Label();
            this.tpAgregarCargo = new System.Windows.Forms.TabPage();
            this.cbxAgregarCargo = new System.Windows.Forms.ComboBox();
            this.lbAgregarCargo = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.tpAgregarUsuario = new System.Windows.Forms.TabPage();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txbEmailUsuario = new System.Windows.Forms.TextBox();
            this.txbApellidoMatUsuario = new System.Windows.Forms.TextBox();
            this.txbApellidoPatUsuario = new System.Windows.Forms.TextBox();
            this.txbNombresUsuario = new System.Windows.Forms.TextBox();
            this.txbContraUsuario = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.lbEmailUsuario = new System.Windows.Forms.Label();
            this.lbApellidoMatUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNombresUsuario = new System.Windows.Forms.Label();
            this.lbContraUsuario = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.tpAgregarTecnico = new System.Windows.Forms.TabPage();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.txbRut = new System.Windows.Forms.TextBox();
            this.lbRutTecnico = new System.Windows.Forms.Label();
            this.txbEmailTecnico = new System.Windows.Forms.TextBox();
            this.txbApellidoMatTecnico = new System.Windows.Forms.TextBox();
            this.txbApellidoPatTecnico = new System.Windows.Forms.TextBox();
            this.txbNombresTecnico = new System.Windows.Forms.TextBox();
            this.txbContraseñaTecnico = new System.Windows.Forms.TextBox();
            this.txbUsuarioTecnico = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbApellidoMatTecnico = new System.Windows.Forms.Label();
            this.lbApellidoPatTecnico = new System.Windows.Forms.Label();
            this.lbNombresTecnico = new System.Windows.Forms.Label();
            this.lbContraseñaTecnico = new System.Windows.Forms.Label();
            this.lbUsuarioTecnico = new System.Windows.Forms.Label();
            this.btnGuardarTecnico = new System.Windows.Forms.Button();
            this.cargoTableAdapter = new TechRepair.servicio_tecnicoDataSetTableAdapters.cargoTableAdapter();
            this.tcUsuarios.SuspendLayout();
            this.tpListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tpAdmUsuarios.SuspendLayout();
            this.tcAdmUsuarios.SuspendLayout();
            this.tpModPrivilegiosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciotecnicoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicio_tecnicoDataSet)).BeginInit();
            this.tpAgregarCargo.SuspendLayout();
            this.tpAgregarUsuario.SuspendLayout();
            this.tpAgregarTecnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTituloAdminUsuarios
            // 
            this.lbTituloAdminUsuarios.AutoSize = true;
            this.lbTituloAdminUsuarios.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloAdminUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTituloAdminUsuarios.Location = new System.Drawing.Point(233, 30);
            this.lbTituloAdminUsuarios.Name = "lbTituloAdminUsuarios";
            this.lbTituloAdminUsuarios.Size = new System.Drawing.Size(353, 32);
            this.lbTituloAdminUsuarios.TabIndex = 1;
            this.lbTituloAdminUsuarios.Text = "Administrador de usuarios";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(699, 40);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tcUsuarios
            // 
            this.tcUsuarios.Controls.Add(this.tpListaUsuarios);
            this.tcUsuarios.Controls.Add(this.tpAdmUsuarios);
            this.tcUsuarios.Location = new System.Drawing.Point(-2, -3);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.SelectedIndex = 0;
            this.tcUsuarios.Size = new System.Drawing.Size(855, 496);
            this.tcUsuarios.TabIndex = 4;
            // 
            // tpListaUsuarios
            // 
            this.tpListaUsuarios.BackColor = System.Drawing.Color.DarkOrange;
            this.tpListaUsuarios.Controls.Add(this.btnBuscar);
            this.tpListaUsuarios.Controls.Add(this.txbBusqueda);
            this.tpListaUsuarios.Controls.Add(this.btnEliminar);
            this.tpListaUsuarios.Controls.Add(this.btnModificar);
            this.tpListaUsuarios.Controls.Add(this.btnAgregar);
            this.tpListaUsuarios.Controls.Add(this.lbUsuarios);
            this.tpListaUsuarios.Controls.Add(this.dgvUsuarios);
            this.tpListaUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpListaUsuarios.Name = "tpListaUsuarios";
            this.tpListaUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpListaUsuarios.Size = new System.Drawing.Size(847, 470);
            this.tpListaUsuarios.TabIndex = 0;
            this.tpListaUsuarios.Text = "Lista usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(749, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txbBusqueda
            // 
            this.txbBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBusqueda.Location = new System.Drawing.Point(20, 85);
            this.txbBusqueda.Name = "txbBusqueda";
            this.txbBusqueda.Size = new System.Drawing.Size(714, 20);
            this.txbBusqueda.TabIndex = 23;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(478, 392);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(343, 392);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Cargo";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(202, 392);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbUsuarios.Location = new System.Drawing.Point(338, 21);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(163, 39);
            this.lbUsuarios.TabIndex = 1;
            this.lbUsuarios.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(20, 123);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(804, 240);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // tpAdmUsuarios
            // 
            this.tpAdmUsuarios.BackColor = System.Drawing.Color.DarkOrange;
            this.tpAdmUsuarios.Controls.Add(this.label1);
            this.tpAdmUsuarios.Controls.Add(this.tcAdmUsuarios);
            this.tpAdmUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tpAdmUsuarios.Name = "tpAdmUsuarios";
            this.tpAdmUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmUsuarios.Size = new System.Drawing.Size(847, 470);
            this.tpAdmUsuarios.TabIndex = 1;
            this.tpAdmUsuarios.Text = "Administrador de usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(339, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuarios";
            // 
            // tcAdmUsuarios
            // 
            this.tcAdmUsuarios.Controls.Add(this.tpModPrivilegiosUsuario);
            this.tcAdmUsuarios.Controls.Add(this.tpAgregarCargo);
            this.tcAdmUsuarios.Controls.Add(this.tpAgregarUsuario);
            this.tcAdmUsuarios.Controls.Add(this.tpAgregarTecnico);
            this.tcAdmUsuarios.Location = new System.Drawing.Point(-4, 66);
            this.tcAdmUsuarios.Name = "tcAdmUsuarios";
            this.tcAdmUsuarios.SelectedIndex = 0;
            this.tcAdmUsuarios.Size = new System.Drawing.Size(855, 408);
            this.tcAdmUsuarios.TabIndex = 4;
            // 
            // tpModPrivilegiosUsuario
            // 
            this.tpModPrivilegiosUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.tpModPrivilegiosUsuario.Controls.Add(this.cbxModCargo);
            this.tpModPrivilegiosUsuario.Controls.Add(this.lbUsuarioCargoDb);
            this.tpModPrivilegiosUsuario.Controls.Add(this.lbUsuarioCargo);
            this.tpModPrivilegiosUsuario.Controls.Add(this.btnGuardarCargo);
            this.tpModPrivilegiosUsuario.Controls.Add(this.lbCargoActualDb);
            this.tpModPrivilegiosUsuario.Controls.Add(this.lbCargoActual);
            this.tpModPrivilegiosUsuario.Controls.Add(this.lbModificarCargo);
            this.tpModPrivilegiosUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpModPrivilegiosUsuario.Name = "tpModPrivilegiosUsuario";
            this.tpModPrivilegiosUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpModPrivilegiosUsuario.Size = new System.Drawing.Size(847, 382);
            this.tpModPrivilegiosUsuario.TabIndex = 2;
            this.tpModPrivilegiosUsuario.Text = "Modificar privilegios usuario";
            // 
            // cbxModCargo
            // 
            this.cbxModCargo.DataSource = this.cargoBindingSource;
            this.cbxModCargo.DisplayMember = "nombre_cargo";
            this.cbxModCargo.FormattingEnabled = true;
            this.cbxModCargo.Location = new System.Drawing.Point(323, 152);
            this.cbxModCargo.Name = "cbxModCargo";
            this.cbxModCargo.Size = new System.Drawing.Size(212, 21);
            this.cbxModCargo.TabIndex = 31;
            this.cbxModCargo.ValueMember = "nombre_cargo";
            // 
            // cargoBindingSource
            // 
            this.cargoBindingSource.DataMember = "cargo";
            this.cargoBindingSource.DataSource = this.serviciotecnicoDataSetBindingSource;
            // 
            // serviciotecnicoDataSetBindingSource
            // 
            this.serviciotecnicoDataSetBindingSource.DataSource = this.servicio_tecnicoDataSet;
            this.serviciotecnicoDataSetBindingSource.Position = 0;
            // 
            // servicio_tecnicoDataSet
            // 
            this.servicio_tecnicoDataSet.DataSetName = "servicio_tecnicoDataSet";
            this.servicio_tecnicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbUsuarioCargoDb
            // 
            this.lbUsuarioCargoDb.AutoSize = true;
            this.lbUsuarioCargoDb.Location = new System.Drawing.Point(320, 88);
            this.lbUsuarioCargoDb.Name = "lbUsuarioCargoDb";
            this.lbUsuarioCargoDb.Size = new System.Drawing.Size(43, 13);
            this.lbUsuarioCargoDb.TabIndex = 30;
            this.lbUsuarioCargoDb.Text = "Usuario";
            // 
            // lbUsuarioCargo
            // 
            this.lbUsuarioCargo.AutoSize = true;
            this.lbUsuarioCargo.Location = new System.Drawing.Point(234, 88);
            this.lbUsuarioCargo.Name = "lbUsuarioCargo";
            this.lbUsuarioCargo.Size = new System.Drawing.Size(46, 13);
            this.lbUsuarioCargo.TabIndex = 29;
            this.lbUsuarioCargo.Text = "Usuario:";
            // 
            // btnGuardarCargo
            // 
            this.btnGuardarCargo.Location = new System.Drawing.Point(376, 214);
            this.btnGuardarCargo.Name = "btnGuardarCargo";
            this.btnGuardarCargo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCargo.TabIndex = 28;
            this.btnGuardarCargo.Text = "Guardar";
            this.btnGuardarCargo.UseVisualStyleBackColor = true;
            // 
            // lbCargoActualDb
            // 
            this.lbCargoActualDb.AutoSize = true;
            this.lbCargoActualDb.Location = new System.Drawing.Point(320, 120);
            this.lbCargoActualDb.Name = "lbCargoActualDb";
            this.lbCargoActualDb.Size = new System.Drawing.Size(67, 13);
            this.lbCargoActualDb.TabIndex = 27;
            this.lbCargoActualDb.Text = "Cargo actual";
            // 
            // lbCargoActual
            // 
            this.lbCargoActual.AutoSize = true;
            this.lbCargoActual.Location = new System.Drawing.Point(234, 120);
            this.lbCargoActual.Name = "lbCargoActual";
            this.lbCargoActual.Size = new System.Drawing.Size(70, 13);
            this.lbCargoActual.TabIndex = 26;
            this.lbCargoActual.Text = "Cargo actual:";
            // 
            // lbModificarCargo
            // 
            this.lbModificarCargo.AutoSize = true;
            this.lbModificarCargo.Location = new System.Drawing.Point(234, 155);
            this.lbModificarCargo.Name = "lbModificarCargo";
            this.lbModificarCargo.Size = new System.Drawing.Size(83, 13);
            this.lbModificarCargo.TabIndex = 0;
            this.lbModificarCargo.Text = "Modificar cargo:";
            // 
            // tpAgregarCargo
            // 
            this.tpAgregarCargo.BackColor = System.Drawing.Color.DarkOrange;
            this.tpAgregarCargo.Controls.Add(this.cbxAgregarCargo);
            this.tpAgregarCargo.Controls.Add(this.lbAgregarCargo);
            this.tpAgregarCargo.Controls.Add(this.btnSiguiente);
            this.tpAgregarCargo.Location = new System.Drawing.Point(4, 22);
            this.tpAgregarCargo.Name = "tpAgregarCargo";
            this.tpAgregarCargo.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregarCargo.Size = new System.Drawing.Size(847, 382);
            this.tpAgregarCargo.TabIndex = 1;
            this.tpAgregarCargo.Text = "Agregar Cargo";
            // 
            // cbxAgregarCargo
            // 
            this.cbxAgregarCargo.DataSource = this.cargoBindingSource;
            this.cbxAgregarCargo.DisplayMember = "nombre_cargo";
            this.cbxAgregarCargo.FormattingEnabled = true;
            this.cbxAgregarCargo.Location = new System.Drawing.Point(277, 153);
            this.cbxAgregarCargo.Name = "cbxAgregarCargo";
            this.cbxAgregarCargo.Size = new System.Drawing.Size(225, 21);
            this.cbxAgregarCargo.TabIndex = 46;
            this.cbxAgregarCargo.ValueMember = "nombre_cargo";
            // 
            // lbAgregarCargo
            // 
            this.lbAgregarCargo.AutoSize = true;
            this.lbAgregarCargo.Location = new System.Drawing.Point(274, 125);
            this.lbAgregarCargo.Name = "lbAgregarCargo";
            this.lbAgregarCargo.Size = new System.Drawing.Size(35, 13);
            this.lbAgregarCargo.TabIndex = 44;
            this.lbAgregarCargo.Text = "Cargo";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(376, 311);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // tpAgregarUsuario
            // 
            this.tpAgregarUsuario.BackColor = System.Drawing.Color.DarkOrange;
            this.tpAgregarUsuario.Controls.Add(this.btnGuardarUsuario);
            this.tpAgregarUsuario.Controls.Add(this.txbEmailUsuario);
            this.tpAgregarUsuario.Controls.Add(this.txbApellidoMatUsuario);
            this.tpAgregarUsuario.Controls.Add(this.txbApellidoPatUsuario);
            this.tpAgregarUsuario.Controls.Add(this.txbNombresUsuario);
            this.tpAgregarUsuario.Controls.Add(this.txbContraUsuario);
            this.tpAgregarUsuario.Controls.Add(this.txbUsuario);
            this.tpAgregarUsuario.Controls.Add(this.lbEmailUsuario);
            this.tpAgregarUsuario.Controls.Add(this.lbApellidoMatUsuario);
            this.tpAgregarUsuario.Controls.Add(this.label5);
            this.tpAgregarUsuario.Controls.Add(this.lbNombresUsuario);
            this.tpAgregarUsuario.Controls.Add(this.lbContraUsuario);
            this.tpAgregarUsuario.Controls.Add(this.lbUsuario);
            this.tpAgregarUsuario.Location = new System.Drawing.Point(4, 22);
            this.tpAgregarUsuario.Name = "tpAgregarUsuario";
            this.tpAgregarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregarUsuario.Size = new System.Drawing.Size(847, 382);
            this.tpAgregarUsuario.TabIndex = 3;
            this.tpAgregarUsuario.Text = "Agregar Usuario";
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Location = new System.Drawing.Point(367, 305);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsuario.TabIndex = 29;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            // 
            // txbEmailUsuario
            // 
            this.txbEmailUsuario.Location = new System.Drawing.Point(477, 189);
            this.txbEmailUsuario.Name = "txbEmailUsuario";
            this.txbEmailUsuario.Size = new System.Drawing.Size(253, 20);
            this.txbEmailUsuario.TabIndex = 28;
            // 
            // txbApellidoMatUsuario
            // 
            this.txbApellidoMatUsuario.Location = new System.Drawing.Point(477, 70);
            this.txbApellidoMatUsuario.Name = "txbApellidoMatUsuario";
            this.txbApellidoMatUsuario.Size = new System.Drawing.Size(253, 20);
            this.txbApellidoMatUsuario.TabIndex = 26;
            // 
            // txbApellidoPatUsuario
            // 
            this.txbApellidoPatUsuario.Location = new System.Drawing.Point(118, 189);
            this.txbApellidoPatUsuario.Name = "txbApellidoPatUsuario";
            this.txbApellidoPatUsuario.Size = new System.Drawing.Size(231, 20);
            this.txbApellidoPatUsuario.TabIndex = 25;
            // 
            // txbNombresUsuario
            // 
            this.txbNombresUsuario.Location = new System.Drawing.Point(118, 127);
            this.txbNombresUsuario.Name = "txbNombresUsuario";
            this.txbNombresUsuario.Size = new System.Drawing.Size(231, 20);
            this.txbNombresUsuario.TabIndex = 24;
            // 
            // txbContraUsuario
            // 
            this.txbContraUsuario.Location = new System.Drawing.Point(477, 127);
            this.txbContraUsuario.Name = "txbContraUsuario";
            this.txbContraUsuario.Size = new System.Drawing.Size(231, 20);
            this.txbContraUsuario.TabIndex = 23;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(118, 70);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(231, 20);
            this.txbUsuario.TabIndex = 22;
            // 
            // lbEmailUsuario
            // 
            this.lbEmailUsuario.AutoSize = true;
            this.lbEmailUsuario.Location = new System.Drawing.Point(474, 173);
            this.lbEmailUsuario.Name = "lbEmailUsuario";
            this.lbEmailUsuario.Size = new System.Drawing.Size(32, 13);
            this.lbEmailUsuario.TabIndex = 21;
            this.lbEmailUsuario.Text = "Email";
            // 
            // lbApellidoMatUsuario
            // 
            this.lbApellidoMatUsuario.AutoSize = true;
            this.lbApellidoMatUsuario.Location = new System.Drawing.Point(474, 54);
            this.lbApellidoMatUsuario.Name = "lbApellidoMatUsuario";
            this.lbApellidoMatUsuario.Size = new System.Drawing.Size(86, 13);
            this.lbApellidoMatUsuario.TabIndex = 19;
            this.lbApellidoMatUsuario.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Apellido Paterno";
            // 
            // lbNombresUsuario
            // 
            this.lbNombresUsuario.AutoSize = true;
            this.lbNombresUsuario.Location = new System.Drawing.Point(115, 111);
            this.lbNombresUsuario.Name = "lbNombresUsuario";
            this.lbNombresUsuario.Size = new System.Drawing.Size(49, 13);
            this.lbNombresUsuario.TabIndex = 17;
            this.lbNombresUsuario.Text = "Nombres";
            // 
            // lbContraUsuario
            // 
            this.lbContraUsuario.AutoSize = true;
            this.lbContraUsuario.Location = new System.Drawing.Point(474, 111);
            this.lbContraUsuario.Name = "lbContraUsuario";
            this.lbContraUsuario.Size = new System.Drawing.Size(61, 13);
            this.lbContraUsuario.TabIndex = 16;
            this.lbContraUsuario.Text = "Contraseña";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(115, 54);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 15;
            this.lbUsuario.Text = "Usuario";
            // 
            // tpAgregarTecnico
            // 
            this.tpAgregarTecnico.BackColor = System.Drawing.Color.DarkOrange;
            this.tpAgregarTecnico.Controls.Add(this.txbTelefono);
            this.tpAgregarTecnico.Controls.Add(this.lbTelefono);
            this.tpAgregarTecnico.Controls.Add(this.txbRut);
            this.tpAgregarTecnico.Controls.Add(this.lbRutTecnico);
            this.tpAgregarTecnico.Controls.Add(this.txbEmailTecnico);
            this.tpAgregarTecnico.Controls.Add(this.txbApellidoMatTecnico);
            this.tpAgregarTecnico.Controls.Add(this.txbApellidoPatTecnico);
            this.tpAgregarTecnico.Controls.Add(this.txbNombresTecnico);
            this.tpAgregarTecnico.Controls.Add(this.txbContraseñaTecnico);
            this.tpAgregarTecnico.Controls.Add(this.txbUsuarioTecnico);
            this.tpAgregarTecnico.Controls.Add(this.lbEmail);
            this.tpAgregarTecnico.Controls.Add(this.lbApellidoMatTecnico);
            this.tpAgregarTecnico.Controls.Add(this.lbApellidoPatTecnico);
            this.tpAgregarTecnico.Controls.Add(this.lbNombresTecnico);
            this.tpAgregarTecnico.Controls.Add(this.lbContraseñaTecnico);
            this.tpAgregarTecnico.Controls.Add(this.lbUsuarioTecnico);
            this.tpAgregarTecnico.Controls.Add(this.btnGuardarTecnico);
            this.tpAgregarTecnico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpAgregarTecnico.Location = new System.Drawing.Point(4, 22);
            this.tpAgregarTecnico.Name = "tpAgregarTecnico";
            this.tpAgregarTecnico.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregarTecnico.Size = new System.Drawing.Size(847, 382);
            this.tpAgregarTecnico.TabIndex = 4;
            this.tpAgregarTecnico.Text = "Agregar Tecnico";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Location = new System.Drawing.Point(477, 236);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(253, 20);
            this.txbTelefono.TabIndex = 48;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(474, 220);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 47;
            this.lbTelefono.Text = "Telefono";
            // 
            // txbRut
            // 
            this.txbRut.Location = new System.Drawing.Point(477, 122);
            this.txbRut.Name = "txbRut";
            this.txbRut.Size = new System.Drawing.Size(253, 20);
            this.txbRut.TabIndex = 46;
            // 
            // lbRutTecnico
            // 
            this.lbRutTecnico.AutoSize = true;
            this.lbRutTecnico.Location = new System.Drawing.Point(474, 106);
            this.lbRutTecnico.Name = "lbRutTecnico";
            this.lbRutTecnico.Size = new System.Drawing.Size(24, 13);
            this.lbRutTecnico.TabIndex = 45;
            this.lbRutTecnico.Text = "Rut";
            // 
            // txbEmailTecnico
            // 
            this.txbEmailTecnico.Location = new System.Drawing.Point(477, 183);
            this.txbEmailTecnico.Name = "txbEmailTecnico";
            this.txbEmailTecnico.Size = new System.Drawing.Size(253, 20);
            this.txbEmailTecnico.TabIndex = 44;
            // 
            // txbApellidoMatTecnico
            // 
            this.txbApellidoMatTecnico.Location = new System.Drawing.Point(117, 236);
            this.txbApellidoMatTecnico.Name = "txbApellidoMatTecnico";
            this.txbApellidoMatTecnico.Size = new System.Drawing.Size(253, 20);
            this.txbApellidoMatTecnico.TabIndex = 42;
            // 
            // txbApellidoPatTecnico
            // 
            this.txbApellidoPatTecnico.Location = new System.Drawing.Point(117, 184);
            this.txbApellidoPatTecnico.Name = "txbApellidoPatTecnico";
            this.txbApellidoPatTecnico.Size = new System.Drawing.Size(231, 20);
            this.txbApellidoPatTecnico.TabIndex = 41;
            // 
            // txbNombresTecnico
            // 
            this.txbNombresTecnico.Location = new System.Drawing.Point(117, 122);
            this.txbNombresTecnico.Name = "txbNombresTecnico";
            this.txbNombresTecnico.Size = new System.Drawing.Size(231, 20);
            this.txbNombresTecnico.TabIndex = 40;
            // 
            // txbContraseñaTecnico
            // 
            this.txbContraseñaTecnico.Location = new System.Drawing.Point(477, 64);
            this.txbContraseñaTecnico.Name = "txbContraseñaTecnico";
            this.txbContraseñaTecnico.Size = new System.Drawing.Size(231, 20);
            this.txbContraseñaTecnico.TabIndex = 39;
            // 
            // txbUsuarioTecnico
            // 
            this.txbUsuarioTecnico.Location = new System.Drawing.Point(117, 64);
            this.txbUsuarioTecnico.Name = "txbUsuarioTecnico";
            this.txbUsuarioTecnico.Size = new System.Drawing.Size(231, 20);
            this.txbUsuarioTecnico.TabIndex = 38;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(474, 167);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 37;
            this.lbEmail.Text = "Email";
            // 
            // lbApellidoMatTecnico
            // 
            this.lbApellidoMatTecnico.AutoSize = true;
            this.lbApellidoMatTecnico.Location = new System.Drawing.Point(114, 220);
            this.lbApellidoMatTecnico.Name = "lbApellidoMatTecnico";
            this.lbApellidoMatTecnico.Size = new System.Drawing.Size(86, 13);
            this.lbApellidoMatTecnico.TabIndex = 35;
            this.lbApellidoMatTecnico.Text = "Apellido Materno";
            // 
            // lbApellidoPatTecnico
            // 
            this.lbApellidoPatTecnico.AutoSize = true;
            this.lbApellidoPatTecnico.Location = new System.Drawing.Point(114, 158);
            this.lbApellidoPatTecnico.Name = "lbApellidoPatTecnico";
            this.lbApellidoPatTecnico.Size = new System.Drawing.Size(84, 13);
            this.lbApellidoPatTecnico.TabIndex = 34;
            this.lbApellidoPatTecnico.Text = "Apellido Paterno";
            // 
            // lbNombresTecnico
            // 
            this.lbNombresTecnico.AutoSize = true;
            this.lbNombresTecnico.Location = new System.Drawing.Point(114, 106);
            this.lbNombresTecnico.Name = "lbNombresTecnico";
            this.lbNombresTecnico.Size = new System.Drawing.Size(49, 13);
            this.lbNombresTecnico.TabIndex = 33;
            this.lbNombresTecnico.Text = "Nombres";
            // 
            // lbContraseñaTecnico
            // 
            this.lbContraseñaTecnico.AutoSize = true;
            this.lbContraseñaTecnico.Location = new System.Drawing.Point(474, 48);
            this.lbContraseñaTecnico.Name = "lbContraseñaTecnico";
            this.lbContraseñaTecnico.Size = new System.Drawing.Size(61, 13);
            this.lbContraseñaTecnico.TabIndex = 32;
            this.lbContraseñaTecnico.Text = "Contraseña";
            // 
            // lbUsuarioTecnico
            // 
            this.lbUsuarioTecnico.AutoSize = true;
            this.lbUsuarioTecnico.Location = new System.Drawing.Point(114, 48);
            this.lbUsuarioTecnico.Name = "lbUsuarioTecnico";
            this.lbUsuarioTecnico.Size = new System.Drawing.Size(43, 13);
            this.lbUsuarioTecnico.TabIndex = 31;
            this.lbUsuarioTecnico.Text = "Usuario";
            // 
            // btnGuardarTecnico
            // 
            this.btnGuardarTecnico.Location = new System.Drawing.Point(378, 291);
            this.btnGuardarTecnico.Name = "btnGuardarTecnico";
            this.btnGuardarTecnico.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarTecnico.TabIndex = 30;
            this.btnGuardarTecnico.Text = "Guardar";
            this.btnGuardarTecnico.UseVisualStyleBackColor = true;
            // 
            // cargoTableAdapter
            // 
            this.cargoTableAdapter.ClearBeforeFill = true;
            // 
            // AdminUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(848, 485);
            this.Controls.Add(this.tcUsuarios);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbTituloAdminUsuarios);
            this.Name = "AdminUsuariosForm";
            this.Text = "AdminUsuarios";
            this.Load += new System.EventHandler(this.AdminUsuariosForm_Load);
            this.tcUsuarios.ResumeLayout(false);
            this.tpListaUsuarios.ResumeLayout(false);
            this.tpListaUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tpAdmUsuarios.ResumeLayout(false);
            this.tpAdmUsuarios.PerformLayout();
            this.tcAdmUsuarios.ResumeLayout(false);
            this.tpModPrivilegiosUsuario.ResumeLayout(false);
            this.tpModPrivilegiosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciotecnicoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicio_tecnicoDataSet)).EndInit();
            this.tpAgregarCargo.ResumeLayout(false);
            this.tpAgregarCargo.PerformLayout();
            this.tpAgregarUsuario.ResumeLayout(false);
            this.tpAgregarUsuario.PerformLayout();
            this.tpAgregarTecnico.ResumeLayout(false);
            this.tpAgregarTecnico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloAdminUsuarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tcUsuarios;
        private System.Windows.Forms.TabPage tpListaUsuarios;
        private System.Windows.Forms.TabPage tpAdmUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Label label1;
        private TechRepair.servicio_tecnicoDataSet servicio_tecnicoDataSet;
        private System.Windows.Forms.BindingSource serviciotecnicoDataSetBindingSource;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        private TechRepair.servicio_tecnicoDataSetTableAdapters.cargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.TabControl tcAdmUsuarios;
        private System.Windows.Forms.TabPage tpModPrivilegiosUsuario;
        private System.Windows.Forms.ComboBox cbxModCargo;
        private System.Windows.Forms.Label lbUsuarioCargoDb;
        private System.Windows.Forms.Label lbUsuarioCargo;
        private System.Windows.Forms.Button btnGuardarCargo;
        private System.Windows.Forms.Label lbCargoActualDb;
        private System.Windows.Forms.Label lbCargoActual;
        private System.Windows.Forms.Label lbModificarCargo;
        private System.Windows.Forms.TabPage tpAgregarCargo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TabPage tpAgregarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.TextBox txbEmailUsuario;
        private System.Windows.Forms.TextBox txbApellidoMatUsuario;
        private System.Windows.Forms.TextBox txbApellidoPatUsuario;
        private System.Windows.Forms.TextBox txbNombresUsuario;
        private System.Windows.Forms.TextBox txbContraUsuario;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label lbEmailUsuario;
        private System.Windows.Forms.Label lbApellidoMatUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNombresUsuario;
        private System.Windows.Forms.Label lbContraUsuario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TabPage tpAgregarTecnico;
        private System.Windows.Forms.ComboBox cbxAgregarCargo;
        private System.Windows.Forms.Label lbAgregarCargo;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.TextBox txbRut;
        private System.Windows.Forms.Label lbRutTecnico;
        private System.Windows.Forms.TextBox txbEmailTecnico;
        private System.Windows.Forms.TextBox txbApellidoMatTecnico;
        private System.Windows.Forms.TextBox txbApellidoPatTecnico;
        private System.Windows.Forms.TextBox txbNombresTecnico;
        private System.Windows.Forms.TextBox txbContraseñaTecnico;
        private System.Windows.Forms.TextBox txbUsuarioTecnico;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbApellidoMatTecnico;
        private System.Windows.Forms.Label lbApellidoPatTecnico;
        private System.Windows.Forms.Label lbNombresTecnico;
        private System.Windows.Forms.Label lbContraseñaTecnico;
        private System.Windows.Forms.Label lbUsuarioTecnico;
        private System.Windows.Forms.Button btnGuardarTecnico;
    }
}