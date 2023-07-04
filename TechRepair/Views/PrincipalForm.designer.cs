namespace TechRepair
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnAdminUsuarios = new System.Windows.Forms.Button();
            this.btnEquiposCel = new System.Windows.Forms.Button();
            this.btnPlanesRep = new System.Windows.Forms.Button();
            this.btnSistemaAtencion = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(932, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(818, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Chocolate;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(854, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(890, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkOrange;
            this.panelLeft.Controls.Add(this.btnAdminUsuarios);
            this.panelLeft.Controls.Add(this.btnEquiposCel);
            this.panelLeft.Controls.Add(this.btnPlanesRep);
            this.panelLeft.Controls.Add(this.btnSistemaAtencion);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 516);
            this.panelLeft.TabIndex = 1;
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAdminUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAdminUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuarios.Location = new System.Drawing.Point(0, 295);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Size = new System.Drawing.Size(215, 27);
            this.btnAdminUsuarios.TabIndex = 3;
            this.btnAdminUsuarios.Text = "Administrador de usuarios";
            this.btnAdminUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnEquiposCel
            // 
            this.btnEquiposCel.FlatAppearance.BorderSize = 0;
            this.btnEquiposCel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnEquiposCel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquiposCel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquiposCel.Location = new System.Drawing.Point(0, 262);
            this.btnEquiposCel.Name = "btnEquiposCel";
            this.btnEquiposCel.Size = new System.Drawing.Size(215, 27);
            this.btnEquiposCel.TabIndex = 2;
            this.btnEquiposCel.Text = "Marcas de telefonos";
            this.btnEquiposCel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquiposCel.UseVisualStyleBackColor = true;
            // 
            // btnPlanesRep
            // 
            this.btnPlanesRep.FlatAppearance.BorderSize = 0;
            this.btnPlanesRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPlanesRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanesRep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanesRep.Location = new System.Drawing.Point(0, 228);
            this.btnPlanesRep.Name = "btnPlanesRep";
            this.btnPlanesRep.Size = new System.Drawing.Size(215, 27);
            this.btnPlanesRep.TabIndex = 1;
            this.btnPlanesRep.Text = "Planes reparación";
            this.btnPlanesRep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanesRep.UseVisualStyleBackColor = true;
            // 
            // btnSistemaAtencion
            // 
            this.btnSistemaAtencion.FlatAppearance.BorderSize = 0;
            this.btnSistemaAtencion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSistemaAtencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistemaAtencion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistemaAtencion.Location = new System.Drawing.Point(0, 195);
            this.btnSistemaAtencion.Name = "btnSistemaAtencion";
            this.btnSistemaAtencion.Size = new System.Drawing.Size(215, 27);
            this.btnSistemaAtencion.TabIndex = 0;
            this.btnSistemaAtencion.Text = "Sistema de atención";
            this.btnSistemaAtencion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistemaAtencion.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Controls.Add(this.panelPrincipal);
            this.panelContainer.Controls.Add(this.panelLeft);
            this.panelContainer.Controls.Add(this.panelTop);
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(932, 556);
            this.panelContainer.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BackColor = System.Drawing.Color.SandyBrown;
            this.panelPrincipal.Location = new System.Drawing.Point(215, 40);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(717, 516);
            this.panelPrincipal.TabIndex = 2;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 556);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnAdminUsuarios;
        private System.Windows.Forms.Button btnEquiposCel;
        private System.Windows.Forms.Button btnPlanesRep;
        private System.Windows.Forms.Button btnSistemaAtencion;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}

