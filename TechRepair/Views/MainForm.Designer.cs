namespace TechRepair.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelLeftTop = new System.Windows.Forms.Panel();
            this.panelProfileImage = new System.Windows.Forms.Panel();
            this.lklbEditarPerfil = new System.Windows.Forms.LinkLabel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAdminUsuarios = new System.Windows.Forms.Button();
            this.btnPlanesRep = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelLeftTop.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelPrincipal);
            this.panelContainer.Controls.Add(this.panelLeft);
            this.panelContainer.Controls.Add(this.panelTop);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1108, 591);
            this.panelContainer.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.SandyBrown;
            this.panelPrincipal.Location = new System.Drawing.Point(179, 40);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(929, 551);
            this.panelPrincipal.TabIndex = 4;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkOrange;
            this.panelLeft.Controls.Add(this.panelLeftTop);
            this.panelLeft.Controls.Add(this.btnLogOut);
            this.panelLeft.Controls.Add(this.btnAdminUsuarios);
            this.panelLeft.Controls.Add(this.btnPlanesRep);
            this.panelLeft.Controls.Add(this.btnModificarCliente);
            this.panelLeft.Controls.Add(this.btnOrdenes);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(180, 551);
            this.panelLeft.TabIndex = 2;
            // 
            // panelLeftTop
            // 
            this.panelLeftTop.BackColor = System.Drawing.Color.DarkOrange;
            this.panelLeftTop.Controls.Add(this.panelProfileImage);
            this.panelLeftTop.Controls.Add(this.lklbEditarPerfil);
            this.panelLeftTop.Controls.Add(this.lbEmail);
            this.panelLeftTop.Controls.Add(this.lblCargo);
            this.panelLeftTop.Controls.Add(this.lbNombre);
            this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.panelLeftTop.Name = "panelLeftTop";
            this.panelLeftTop.Size = new System.Drawing.Size(180, 173);
            this.panelLeftTop.TabIndex = 0;
            // 
            // panelProfileImage
            // 
            this.panelProfileImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelProfileImage.BackgroundImage")));
            this.panelProfileImage.Location = new System.Drawing.Point(3, 6);
            this.panelProfileImage.Name = "panelProfileImage";
            this.panelProfileImage.Size = new System.Drawing.Size(109, 105);
            this.panelProfileImage.TabIndex = 4;
            // 
            // lklbEditarPerfil
            // 
            this.lklbEditarPerfil.AutoSize = true;
            this.lklbEditarPerfil.LinkColor = System.Drawing.Color.DarkRed;
            this.lklbEditarPerfil.Location = new System.Drawing.Point(118, 15);
            this.lklbEditarPerfil.Name = "lklbEditarPerfil";
            this.lklbEditarPerfil.Size = new System.Drawing.Size(59, 13);
            this.lklbEditarPerfil.TabIndex = 3;
            this.lklbEditarPerfil.TabStop = true;
            this.lklbEditarPerfil.Text = "Editar perfil";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 148);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "Email";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(118, 98);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(12, 124);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 493);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(177, 46);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAdminUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAdminUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuarios.Location = new System.Drawing.Point(3, 377);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Size = new System.Drawing.Size(177, 46);
            this.btnAdminUsuarios.TabIndex = 8;
            this.btnAdminUsuarios.Text = "Administrador de usuarios";
            this.btnAdminUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnPlanesRep
            // 
            this.btnPlanesRep.FlatAppearance.BorderSize = 0;
            this.btnPlanesRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPlanesRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanesRep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanesRep.Location = new System.Drawing.Point(3, 221);
            this.btnPlanesRep.Name = "btnPlanesRep";
            this.btnPlanesRep.Size = new System.Drawing.Size(177, 46);
            this.btnPlanesRep.TabIndex = 7;
            this.btnPlanesRep.Text = "Planes reparación";
            this.btnPlanesRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanesRep.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(3, 325);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(177, 46);
            this.btnModificarCliente.TabIndex = 6;
            this.btnModificarCliente.Text = "Modificar cliente";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.Location = new System.Drawing.Point(3, 273);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(177, 46);
            this.btnOrdenes.TabIndex = 4;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Chocolate;
            this.panelTop.Controls.Add(this.btnMinimizar);
            this.panelTop.Controls.Add(this.btnMaximizar);
            this.panelTop.Controls.Add(this.btnCerrar);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1108, 40);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(997, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Chocolate;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1033, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1069, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 591);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeftTop.ResumeLayout(false);
            this.panelLeftTop.PerformLayout();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnPlanesRep;
        private System.Windows.Forms.Button btnAdminUsuarios;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelLeftTop;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Panel panelProfileImage;
        private System.Windows.Forms.LinkLabel lklbEditarPerfil;
    }
}