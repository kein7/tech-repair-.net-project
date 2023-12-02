namespace TechRepair.Views
{
    partial class ClientesForm
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
            this.tcClientes = new System.Windows.Forms.TabControl();
            this.tpClientes = new System.Windows.Forms.TabPage();
            this.btnModificarOrden = new System.Windows.Forms.Button();
            this.btnEliminarOrden = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbBusqueda = new System.Windows.Forms.TextBox();
            this.lbTituloClientes = new System.Windows.Forms.Label();
            this.tpModificarCliente = new System.Windows.Forms.TabPage();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbRut = new System.Windows.Forms.TextBox();
            this.txbNumDep = new System.Windows.Forms.TextBox();
            this.lbNumDep = new System.Windows.Forms.Label();
            this.txbNumCalle = new System.Windows.Forms.TextBox();
            this.lbNumCalle = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.cbxComuna = new System.Windows.Forms.ComboBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txbApellidoMat = new System.Windows.Forms.TextBox();
            this.lbApellidoMat = new System.Windows.Forms.Label();
            this.txbApellidoPat = new System.Windows.Forms.TextBox();
            this.lbApellidoPat = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lbCalle = new System.Windows.Forms.Label();
            this.lbComuna = new System.Windows.Forms.Label();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbNumTelefono = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbRut = new System.Windows.Forms.Label();
            this.lblNumTelefono = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tcClientes.SuspendLayout();
            this.tpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tpModificarCliente.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcClientes
            // 
            this.tcClientes.Controls.Add(this.tpClientes);
            this.tcClientes.Controls.Add(this.tpModificarCliente);
            this.tcClientes.Location = new System.Drawing.Point(-6, -3);
            this.tcClientes.Name = "tcClientes";
            this.tcClientes.SelectedIndex = 0;
            this.tcClientes.Size = new System.Drawing.Size(812, 456);
            this.tcClientes.TabIndex = 3;
            // 
            // tpClientes
            // 
            this.tpClientes.BackColor = System.Drawing.Color.DarkOrange;
            this.tpClientes.Controls.Add(this.button1);
            this.tpClientes.Controls.Add(this.btnModificarOrden);
            this.tpClientes.Controls.Add(this.btnEliminarOrden);
            this.tpClientes.Controls.Add(this.dgvClientes);
            this.tpClientes.Controls.Add(this.btnBuscar);
            this.tpClientes.Controls.Add(this.txbBusqueda);
            this.tpClientes.Controls.Add(this.lbTituloClientes);
            this.tpClientes.Location = new System.Drawing.Point(4, 22);
            this.tpClientes.Name = "tpClientes";
            this.tpClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientes.Size = new System.Drawing.Size(804, 430);
            this.tpClientes.TabIndex = 0;
            this.tpClientes.Text = "Clientes";
            // 
            // btnModificarOrden
            // 
            this.btnModificarOrden.Location = new System.Drawing.Point(260, 383);
            this.btnModificarOrden.Name = "btnModificarOrden";
            this.btnModificarOrden.Size = new System.Drawing.Size(75, 23);
            this.btnModificarOrden.TabIndex = 26;
            this.btnModificarOrden.Text = "Modificar";
            this.btnModificarOrden.UseVisualStyleBackColor = true;
            // 
            // btnEliminarOrden
            // 
            this.btnEliminarOrden.Location = new System.Drawing.Point(457, 383);
            this.btnEliminarOrden.Name = "btnEliminarOrden";
            this.btnEliminarOrden.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarOrden.TabIndex = 25;
            this.btnEliminarOrden.Text = "Eliminar";
            this.btnEliminarOrden.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(37, 110);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(737, 240);
            this.dgvClientes.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(613, 81);
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
            this.txbBusqueda.Size = new System.Drawing.Size(570, 20);
            this.txbBusqueda.TabIndex = 21;
            // 
            // lbTituloClientes
            // 
            this.lbTituloClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTituloClientes.AutoSize = true;
            this.lbTituloClientes.BackColor = System.Drawing.Color.DarkOrange;
            this.lbTituloClientes.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTituloClientes.Location = new System.Drawing.Point(317, 22);
            this.lbTituloClientes.Name = "lbTituloClientes";
            this.lbTituloClientes.Size = new System.Drawing.Size(151, 41);
            this.lbTituloClientes.TabIndex = 1;
            this.lbTituloClientes.Text = "Clientes";
            // 
            // tpModificarCliente
            // 
            this.tpModificarCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.tpModificarCliente.Controls.Add(this.btnCerrar);
            this.tpModificarCliente.Controls.Add(this.tabControl1);
            this.tpModificarCliente.Controls.Add(this.label1);
            this.tpModificarCliente.Location = new System.Drawing.Point(4, 22);
            this.tpModificarCliente.Name = "tpModificarCliente";
            this.tpModificarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpModificarCliente.Size = new System.Drawing.Size(804, 430);
            this.tpModificarCliente.TabIndex = 1;
            this.tpModificarCliente.Text = "Modificar Cliente";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(698, 54);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 363);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkOrange;
            this.tabPage2.Controls.Add(this.txbRut);
            this.tabPage2.Controls.Add(this.txbNumDep);
            this.tabPage2.Controls.Add(this.lbNumDep);
            this.tabPage2.Controls.Add(this.txbNumCalle);
            this.tabPage2.Controls.Add(this.lbNumCalle);
            this.tabPage2.Controls.Add(this.txbCalle);
            this.tabPage2.Controls.Add(this.cbxComuna);
            this.tabPage2.Controls.Add(this.txbEmail);
            this.tabPage2.Controls.Add(this.lbEmail);
            this.tabPage2.Controls.Add(this.txbApellidoMat);
            this.tabPage2.Controls.Add(this.lbApellidoMat);
            this.tabPage2.Controls.Add(this.txbApellidoPat);
            this.tabPage2.Controls.Add(this.lbApellidoPat);
            this.tabPage2.Controls.Add(this.txbNombre);
            this.tabPage2.Controls.Add(this.lbCalle);
            this.tabPage2.Controls.Add(this.lbComuna);
            this.tabPage2.Controls.Add(this.btnSiguiente2);
            this.tabPage2.Controls.Add(this.lbNombre);
            this.tabPage2.Controls.Add(this.txbDireccion);
            this.tabPage2.Controls.Add(this.txbNumTelefono);
            this.tabPage2.Controls.Add(this.lbDireccion);
            this.tabPage2.Controls.Add(this.lbRut);
            this.tabPage2.Controls.Add(this.lblNumTelefono);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente";
            // 
            // txbRut
            // 
            this.txbRut.Location = new System.Drawing.Point(99, 50);
            this.txbRut.Name = "txbRut";
            this.txbRut.Size = new System.Drawing.Size(233, 20);
            this.txbRut.TabIndex = 106;
            // 
            // txbNumDep
            // 
            this.txbNumDep.Location = new System.Drawing.Point(457, 230);
            this.txbNumDep.Name = "txbNumDep";
            this.txbNumDep.Size = new System.Drawing.Size(233, 20);
            this.txbNumDep.TabIndex = 105;
            // 
            // lbNumDep
            // 
            this.lbNumDep.AutoSize = true;
            this.lbNumDep.Location = new System.Drawing.Point(454, 214);
            this.lbNumDep.Name = "lbNumDep";
            this.lbNumDep.Size = new System.Drawing.Size(127, 13);
            this.lbNumDep.TabIndex = 104;
            this.lbNumDep.Text = "Numero de departamento";
            // 
            // txbNumCalle
            // 
            this.txbNumCalle.Location = new System.Drawing.Point(457, 182);
            this.txbNumCalle.Name = "txbNumCalle";
            this.txbNumCalle.Size = new System.Drawing.Size(233, 20);
            this.txbNumCalle.TabIndex = 103;
            // 
            // lbNumCalle
            // 
            this.lbNumCalle.AutoSize = true;
            this.lbNumCalle.Location = new System.Drawing.Point(454, 166);
            this.lbNumCalle.Name = "lbNumCalle";
            this.lbNumCalle.Size = new System.Drawing.Size(84, 13);
            this.lbNumCalle.TabIndex = 102;
            this.lbNumCalle.Text = "Numero de calle";
            // 
            // txbCalle
            // 
            this.txbCalle.Location = new System.Drawing.Point(457, 140);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(233, 20);
            this.txbCalle.TabIndex = 101;
            // 
            // cbxComuna
            // 
            this.cbxComuna.FormattingEnabled = true;
            this.cbxComuna.Items.AddRange(new object[] {
            "Preparacion",
            "En Reparacion",
            "Listo"});
            this.cbxComuna.Location = new System.Drawing.Point(457, 97);
            this.cbxComuna.Name = "cbxComuna";
            this.cbxComuna.Size = new System.Drawing.Size(233, 21);
            this.cbxComuna.TabIndex = 100;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(99, 280);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(233, 20);
            this.txbEmail.TabIndex = 99;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(96, 264);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 98;
            this.lbEmail.Text = "Email";
            // 
            // txbApellidoMat
            // 
            this.txbApellidoMat.Location = new System.Drawing.Point(99, 182);
            this.txbApellidoMat.Name = "txbApellidoMat";
            this.txbApellidoMat.Size = new System.Drawing.Size(233, 20);
            this.txbApellidoMat.TabIndex = 97;
            // 
            // lbApellidoMat
            // 
            this.lbApellidoMat.AutoSize = true;
            this.lbApellidoMat.Location = new System.Drawing.Point(96, 166);
            this.lbApellidoMat.Name = "lbApellidoMat";
            this.lbApellidoMat.Size = new System.Drawing.Size(86, 13);
            this.lbApellidoMat.TabIndex = 96;
            this.lbApellidoMat.Text = "Apellido Materno";
            // 
            // txbApellidoPat
            // 
            this.txbApellidoPat.Location = new System.Drawing.Point(99, 140);
            this.txbApellidoPat.Name = "txbApellidoPat";
            this.txbApellidoPat.Size = new System.Drawing.Size(233, 20);
            this.txbApellidoPat.TabIndex = 95;
            // 
            // lbApellidoPat
            // 
            this.lbApellidoPat.AutoSize = true;
            this.lbApellidoPat.Location = new System.Drawing.Point(96, 124);
            this.lbApellidoPat.Name = "lbApellidoPat";
            this.lbApellidoPat.Size = new System.Drawing.Size(84, 13);
            this.lbApellidoPat.TabIndex = 94;
            this.lbApellidoPat.Text = "Apellido Paterno";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(99, 97);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(233, 20);
            this.txbNombre.TabIndex = 93;
            // 
            // lbCalle
            // 
            this.lbCalle.AutoSize = true;
            this.lbCalle.Location = new System.Drawing.Point(454, 124);
            this.lbCalle.Name = "lbCalle";
            this.lbCalle.Size = new System.Drawing.Size(30, 13);
            this.lbCalle.TabIndex = 92;
            this.lbCalle.Text = "Calle";
            // 
            // lbComuna
            // 
            this.lbComuna.AutoSize = true;
            this.lbComuna.Location = new System.Drawing.Point(454, 81);
            this.lbComuna.Name = "lbComuna";
            this.lbComuna.Size = new System.Drawing.Size(46, 13);
            this.lbComuna.TabIndex = 91;
            this.lbComuna.Text = "Comuna";
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Location = new System.Drawing.Point(568, 280);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(90, 23);
            this.btnSiguiente2.TabIndex = 90;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(96, 81);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(49, 13);
            this.lbNombre.TabIndex = 87;
            this.lbNombre.Text = "Nombres";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(457, 56);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(233, 20);
            this.txbDireccion.TabIndex = 89;
            // 
            // txbNumTelefono
            // 
            this.txbNumTelefono.Location = new System.Drawing.Point(99, 230);
            this.txbNumTelefono.Name = "txbNumTelefono";
            this.txbNumTelefono.Size = new System.Drawing.Size(233, 20);
            this.txbNumTelefono.TabIndex = 88;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(454, 40);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 86;
            this.lbDireccion.Text = "Direccion";
            // 
            // lbRut
            // 
            this.lbRut.AutoSize = true;
            this.lbRut.Location = new System.Drawing.Point(96, 34);
            this.lbRut.Name = "lbRut";
            this.lbRut.Size = new System.Drawing.Size(59, 13);
            this.lbRut.TabIndex = 84;
            this.lbRut.Text = "Rut Cliente";
            // 
            // lblNumTelefono
            // 
            this.lblNumTelefono.AutoSize = true;
            this.lblNumTelefono.Location = new System.Drawing.Point(96, 214);
            this.lblNumTelefono.Name = "lblNumTelefono";
            this.lblNumTelefono.Size = new System.Drawing.Size(100, 13);
            this.lblNumTelefono.TabIndex = 85;
            this.lblNumTelefono.Text = "Numero de telefono";
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
            this.label1.Location = new System.Drawing.Point(253, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modificar Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcClientes);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.tcClientes.ResumeLayout(false);
            this.tpClientes.ResumeLayout(false);
            this.tpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tpModificarCliente.ResumeLayout(false);
            this.tpModificarCliente.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcClientes;
        private System.Windows.Forms.TabPage tpClientes;
        private System.Windows.Forms.Button btnModificarOrden;
        private System.Windows.Forms.Button btnEliminarOrden;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbBusqueda;
        private System.Windows.Forms.Label lbTituloClientes;
        private System.Windows.Forms.TabPage tpModificarCliente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRut;
        private System.Windows.Forms.TextBox txbNumDep;
        private System.Windows.Forms.Label lbNumDep;
        private System.Windows.Forms.TextBox txbNumCalle;
        private System.Windows.Forms.Label lbNumCalle;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.ComboBox cbxComuna;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txbApellidoMat;
        private System.Windows.Forms.Label lbApellidoMat;
        private System.Windows.Forms.TextBox txbApellidoPat;
        private System.Windows.Forms.Label lbApellidoPat;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lbCalle;
        private System.Windows.Forms.Label lbComuna;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbNumTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbRut;
        private System.Windows.Forms.Label lblNumTelefono;
        private System.Windows.Forms.Button button1;
    }
}