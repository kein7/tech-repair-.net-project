namespace ModernGUI
{
    partial class SistemaAtencionForm
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
            this.lbTituloSistemaAtencion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTituloSistemaAtencion
            // 
            this.lbTituloSistemaAtencion.AutoSize = true;
            this.lbTituloSistemaAtencion.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloSistemaAtencion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTituloSistemaAtencion.Location = new System.Drawing.Point(225, 30);
            this.lbTituloSistemaAtencion.Name = "lbTituloSistemaAtencion";
            this.lbTituloSistemaAtencion.Size = new System.Drawing.Size(361, 41);
            this.lbTituloSistemaAtencion.TabIndex = 1;
            this.lbTituloSistemaAtencion.Text = "Sistema de atención";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(676, 90);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // SistemaAtencionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbTituloSistemaAtencion);
            this.Name = "SistemaAtencionForm";
            this.Text = "SistemaAtencion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloSistemaAtencion;
        private System.Windows.Forms.Button btnCerrar;
    }
}