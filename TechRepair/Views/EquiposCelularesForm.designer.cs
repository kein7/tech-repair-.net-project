namespace ModernGUI
{
    partial class EquiposCelularesForm
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
            this.lbTituloEquipos = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTituloEquipos
            // 
            this.lbTituloEquipos.AutoSize = true;
            this.lbTituloEquipos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloEquipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTituloEquipos.Location = new System.Drawing.Point(251, 30);
            this.lbTituloEquipos.Name = "lbTituloEquipos";
            this.lbTituloEquipos.Size = new System.Drawing.Size(305, 41);
            this.lbTituloEquipos.TabIndex = 1;
            this.lbTituloEquipos.Text = "Marcas telefonos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(648, 95);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // EquiposCelularesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lbTituloEquipos);
            this.Name = "EquiposCelularesForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloEquipos;
        private System.Windows.Forms.Button btnCerrar;
    }
}