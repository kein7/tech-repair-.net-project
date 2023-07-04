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
            this.lbTituloAdminUsuarios = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
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
            this.btnCerrar.Location = new System.Drawing.Point(692, 81);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // AdminUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbTituloAdminUsuarios);
            this.Name = "AdminUsuariosForm";
            this.Text = "AdminUsuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloAdminUsuarios;
        private System.Windows.Forms.Button btnCerrar;
    }
}