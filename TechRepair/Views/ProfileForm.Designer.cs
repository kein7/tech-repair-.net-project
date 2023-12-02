namespace TechRepair.Views
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbkEditarPerfil = new System.Windows.Forms.LinkLabel();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.panelImagenPerfil = new System.Windows.Forms.Panel();
            this.lbCargoDb = new System.Windows.Forms.Label();
            this.lbApellidoDb = new System.Windows.Forms.Label();
            this.lbNombreDb = new System.Windows.Forms.Label();
            this.lbUsuarioDb = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lkbModificarContra = new System.Windows.Forms.LinkLabel();
            this.lbApellidoMaterno = new System.Windows.Forms.Label();
            this.tbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbEditarContraActual = new System.Windows.Forms.Label();
            this.tbContraActual = new System.Windows.Forms.TextBox();
            this.lbEditarConfirmarContra = new System.Windows.Forms.Label();
            this.tbConfirmarContra = new System.Windows.Forms.TextBox();
            this.lbEditarContraseña = new System.Windows.Forms.Label();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lbEditarEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEditarApellido = new System.Windows.Forms.Label();
            this.tbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lbEditarNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbEditarUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbEditarDatos = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.SandyBrown;
            this.panelLeft.Controls.Add(this.lbkEditarPerfil);
            this.panelLeft.Controls.Add(this.lbPerfil);
            this.panelLeft.Controls.Add(this.panelImagenPerfil);
            this.panelLeft.Controls.Add(this.lbCargoDb);
            this.panelLeft.Controls.Add(this.lbApellidoDb);
            this.panelLeft.Controls.Add(this.lbNombreDb);
            this.panelLeft.Controls.Add(this.lbUsuarioDb);
            this.panelLeft.Controls.Add(this.lbCargo);
            this.panelLeft.Controls.Add(this.lbApellido);
            this.panelLeft.Controls.Add(this.lbNombre);
            this.panelLeft.Controls.Add(this.lbUsuario);
            this.panelLeft.Location = new System.Drawing.Point(-3, -1);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(488, 454);
            this.panelLeft.TabIndex = 0;
            // 
            // lbkEditarPerfil
            // 
            this.lbkEditarPerfil.AutoSize = true;
            this.lbkEditarPerfil.LinkColor = System.Drawing.Color.DarkRed;
            this.lbkEditarPerfil.Location = new System.Drawing.Point(96, 280);
            this.lbkEditarPerfil.Name = "lbkEditarPerfil";
            this.lbkEditarPerfil.Size = new System.Drawing.Size(59, 13);
            this.lbkEditarPerfil.TabIndex = 10;
            this.lbkEditarPerfil.TabStop = true;
            this.lbkEditarPerfil.Text = "Editar perfil";
            this.lbkEditarPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkEditarPerfil_LinkClicked);
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbPerfil.Location = new System.Drawing.Point(84, 3);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(82, 31);
            this.lbPerfil.TabIndex = 9;
            this.lbPerfil.Text = "Perfil";
            // 
            // panelImagenPerfil
            // 
            this.panelImagenPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelImagenPerfil.BackgroundImage")));
            this.panelImagenPerfil.Location = new System.Drawing.Point(3, 37);
            this.panelImagenPerfil.Name = "panelImagenPerfil";
            this.panelImagenPerfil.Size = new System.Drawing.Size(233, 240);
            this.panelImagenPerfil.TabIndex = 8;
            // 
            // lbCargoDb
            // 
            this.lbCargoDb.AutoSize = true;
            this.lbCargoDb.Location = new System.Drawing.Point(274, 252);
            this.lbCargoDb.Name = "lbCargoDb";
            this.lbCargoDb.Size = new System.Drawing.Size(35, 13);
            this.lbCargoDb.TabIndex = 7;
            this.lbCargoDb.Text = "Cargo";
            // 
            // lbApellidoDb
            // 
            this.lbApellidoDb.AutoSize = true;
            this.lbApellidoDb.Location = new System.Drawing.Point(273, 200);
            this.lbApellidoDb.Name = "lbApellidoDb";
            this.lbApellidoDb.Size = new System.Drawing.Size(44, 13);
            this.lbApellidoDb.TabIndex = 6;
            this.lbApellidoDb.Text = "Apellido";
            // 
            // lbNombreDb
            // 
            this.lbNombreDb.AutoSize = true;
            this.lbNombreDb.Location = new System.Drawing.Point(274, 142);
            this.lbNombreDb.Name = "lbNombreDb";
            this.lbNombreDb.Size = new System.Drawing.Size(44, 13);
            this.lbNombreDb.TabIndex = 5;
            this.lbNombreDb.Text = "Nombre";
            // 
            // lbUsuarioDb
            // 
            this.lbUsuarioDb.AutoSize = true;
            this.lbUsuarioDb.Location = new System.Drawing.Point(273, 91);
            this.lbUsuarioDb.Name = "lbUsuarioDb";
            this.lbUsuarioDb.Size = new System.Drawing.Size(43, 13);
            this.lbUsuarioDb.TabIndex = 4;
            this.lbUsuarioDb.Text = "Usuario";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbCargo.Location = new System.Drawing.Point(273, 225);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(56, 17);
            this.lbCargo.TabIndex = 3;
            this.lbCargo.Text = "Cargo:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbApellido.Location = new System.Drawing.Point(273, 174);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(71, 17);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbNombre.Location = new System.Drawing.Point(273, 125);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 17);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbUsuario.Location = new System.Drawing.Point(273, 74);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(69, 17);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario:";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.DarkOrange;
            this.panelRight.Controls.Add(this.lkbModificarContra);
            this.panelRight.Controls.Add(this.lbApellidoMaterno);
            this.panelRight.Controls.Add(this.tbApellidoMaterno);
            this.panelRight.Controls.Add(this.btnGuardar);
            this.panelRight.Controls.Add(this.btnCancelar);
            this.panelRight.Controls.Add(this.lbEditarContraActual);
            this.panelRight.Controls.Add(this.tbContraActual);
            this.panelRight.Controls.Add(this.lbEditarConfirmarContra);
            this.panelRight.Controls.Add(this.lbEditarEmail);
            this.panelRight.Controls.Add(this.tbEmail);
            this.panelRight.Controls.Add(this.tbConfirmarContra);
            this.panelRight.Controls.Add(this.lbEditarApellido);
            this.panelRight.Controls.Add(this.lbEditarContraseña);
            this.panelRight.Controls.Add(this.tbApellidoPaterno);
            this.panelRight.Controls.Add(this.lbEditarNombre);
            this.panelRight.Controls.Add(this.tbContraseña);
            this.panelRight.Controls.Add(this.tbNombre);
            this.panelRight.Controls.Add(this.lbEditarUsuario);
            this.panelRight.Controls.Add(this.tbUsuario);
            this.panelRight.Controls.Add(this.lbEditarDatos);
            this.panelRight.Location = new System.Drawing.Point(481, -1);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(322, 454);
            this.panelRight.TabIndex = 1;
            this.panelRight.Visible = false;
            // 
            // lkbModificarContra
            // 
            this.lkbModificarContra.AutoSize = true;
            this.lkbModificarContra.LinkColor = System.Drawing.Color.DarkRed;
            this.lkbModificarContra.Location = new System.Drawing.Point(109, 328);
            this.lkbModificarContra.Name = "lkbModificarContra";
            this.lkbModificarContra.Size = new System.Drawing.Size(107, 13);
            this.lkbModificarContra.TabIndex = 11;
            this.lkbModificarContra.TabStop = true;
            this.lkbModificarContra.Text = "Modificar Contraseña";
            this.lkbModificarContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbModificarContra_LinkClicked);
            // 
            // lbApellidoMaterno
            // 
            this.lbApellidoMaterno.AutoSize = true;
            this.lbApellidoMaterno.Location = new System.Drawing.Point(31, 197);
            this.lbApellidoMaterno.Name = "lbApellidoMaterno";
            this.lbApellidoMaterno.Size = new System.Drawing.Size(86, 13);
            this.lbApellidoMaterno.TabIndex = 28;
            this.lbApellidoMaterno.Text = "Apellido Materno";
            // 
            // tbApellidoMaterno
            // 
            this.tbApellidoMaterno.Location = new System.Drawing.Point(34, 213);
            this.tbApellidoMaterno.Name = "tbApellidoMaterno";
            this.tbApellidoMaterno.Size = new System.Drawing.Size(256, 20);
            this.tbApellidoMaterno.TabIndex = 27;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(186, 416);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(63, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbEditarContraActual
            // 
            this.lbEditarContraActual.AutoSize = true;
            this.lbEditarContraActual.Location = new System.Drawing.Point(31, 277);
            this.lbEditarContraActual.Name = "lbEditarContraActual";
            this.lbEditarContraActual.Size = new System.Drawing.Size(93, 13);
            this.lbEditarContraActual.TabIndex = 24;
            this.lbEditarContraActual.Text = "Contraseña actual";
            // 
            // tbContraActual
            // 
            this.tbContraActual.Location = new System.Drawing.Point(34, 294);
            this.tbContraActual.Name = "tbContraActual";
            this.tbContraActual.Size = new System.Drawing.Size(256, 20);
            this.tbContraActual.TabIndex = 23;
            // 
            // lbEditarConfirmarContra
            // 
            this.lbEditarConfirmarContra.AutoSize = true;
            this.lbEditarConfirmarContra.Location = new System.Drawing.Point(31, 363);
            this.lbEditarConfirmarContra.Name = "lbEditarConfirmarContra";
            this.lbEditarConfirmarContra.Size = new System.Drawing.Size(107, 13);
            this.lbEditarConfirmarContra.TabIndex = 22;
            this.lbEditarConfirmarContra.Text = "Confirmar contraseña";
            // 
            // tbConfirmarContra
            // 
            this.tbConfirmarContra.Location = new System.Drawing.Point(34, 380);
            this.tbConfirmarContra.Name = "tbConfirmarContra";
            this.tbConfirmarContra.Size = new System.Drawing.Size(256, 20);
            this.tbConfirmarContra.TabIndex = 21;
            // 
            // lbEditarContraseña
            // 
            this.lbEditarContraseña.AutoSize = true;
            this.lbEditarContraseña.Location = new System.Drawing.Point(31, 318);
            this.lbEditarContraseña.Name = "lbEditarContraseña";
            this.lbEditarContraseña.Size = new System.Drawing.Size(61, 13);
            this.lbEditarContraseña.TabIndex = 20;
            this.lbEditarContraseña.Text = "Contraseña";
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(34, 334);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(256, 20);
            this.tbContraseña.TabIndex = 19;
            // 
            // lbEditarEmail
            // 
            this.lbEditarEmail.AutoSize = true;
            this.lbEditarEmail.Location = new System.Drawing.Point(31, 236);
            this.lbEditarEmail.Name = "lbEditarEmail";
            this.lbEditarEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEditarEmail.TabIndex = 18;
            this.lbEditarEmail.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(34, 252);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(256, 20);
            this.tbEmail.TabIndex = 17;
            // 
            // lbEditarApellido
            // 
            this.lbEditarApellido.AutoSize = true;
            this.lbEditarApellido.Location = new System.Drawing.Point(31, 155);
            this.lbEditarApellido.Name = "lbEditarApellido";
            this.lbEditarApellido.Size = new System.Drawing.Size(84, 13);
            this.lbEditarApellido.TabIndex = 16;
            this.lbEditarApellido.Text = "Apellido Paterno";
            // 
            // tbApellidoPaterno
            // 
            this.tbApellidoPaterno.Location = new System.Drawing.Point(34, 171);
            this.tbApellidoPaterno.Name = "tbApellidoPaterno";
            this.tbApellidoPaterno.Size = new System.Drawing.Size(256, 20);
            this.tbApellidoPaterno.TabIndex = 15;
            // 
            // lbEditarNombre
            // 
            this.lbEditarNombre.AutoSize = true;
            this.lbEditarNombre.Location = new System.Drawing.Point(31, 116);
            this.lbEditarNombre.Name = "lbEditarNombre";
            this.lbEditarNombre.Size = new System.Drawing.Size(44, 13);
            this.lbEditarNombre.TabIndex = 14;
            this.lbEditarNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(34, 132);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(256, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // lbEditarUsuario
            // 
            this.lbEditarUsuario.AutoSize = true;
            this.lbEditarUsuario.Location = new System.Drawing.Point(31, 76);
            this.lbEditarUsuario.Name = "lbEditarUsuario";
            this.lbEditarUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbEditarUsuario.TabIndex = 12;
            this.lbEditarUsuario.Text = "Usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(34, 93);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(256, 20);
            this.tbUsuario.TabIndex = 11;
            // 
            // lbEditarDatos
            // 
            this.lbEditarDatos.AutoSize = true;
            this.lbEditarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbEditarDatos.Location = new System.Drawing.Point(73, 19);
            this.lbEditarDatos.Name = "lbEditarDatos";
            this.lbEditarDatos.Size = new System.Drawing.Size(171, 31);
            this.lbEditarDatos.TabIndex = 10;
            this.lbEditarDatos.Text = "Editar datos";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "ProfileForm";
            this.Text = "EditProfrileForm";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbUsuarioDb;
        private System.Windows.Forms.Label lbCargoDb;
        private System.Windows.Forms.Label lbApellidoDb;
        private System.Windows.Forms.Label lbNombreDb;
        private System.Windows.Forms.Panel panelImagenPerfil;
        private System.Windows.Forms.LinkLabel lbkEditarPerfil;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lbEditarDatos;
        private System.Windows.Forms.Label lbEditarContraActual;
        private System.Windows.Forms.TextBox tbContraActual;
        private System.Windows.Forms.Label lbEditarConfirmarContra;
        private System.Windows.Forms.TextBox tbConfirmarContra;
        private System.Windows.Forms.Label lbEditarContraseña;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lbEditarEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEditarApellido;
        private System.Windows.Forms.TextBox tbApellidoPaterno;
        private System.Windows.Forms.Label lbEditarNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbEditarUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbApellidoMaterno;
        private System.Windows.Forms.TextBox tbApellidoMaterno;
        private System.Windows.Forms.LinkLabel lkbModificarContra;
    }
}