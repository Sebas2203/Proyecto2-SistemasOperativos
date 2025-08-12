namespace Servidor.Presentacion
{
    partial class MenuPrincipall
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
            this.lbl_menuprincipal = new System.Windows.Forms.Label();
            this.btnMantenimientoTerminales = new System.Windows.Forms.Button();
            this.btnMantenimientoViajes = new System.Windows.Forms.Button();
            this.btnSocketComunicacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_menuprincipal
            // 
            this.lbl_menuprincipal.AutoSize = true;
            this.lbl_menuprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menuprincipal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_menuprincipal.Location = new System.Drawing.Point(74, 47);
            this.lbl_menuprincipal.Name = "lbl_menuprincipal";
            this.lbl_menuprincipal.Size = new System.Drawing.Size(169, 25);
            this.lbl_menuprincipal.TabIndex = 0;
            this.lbl_menuprincipal.Text = "Menú Principal";
            // 
            // btnMantenimientoTerminales
            // 
            this.btnMantenimientoTerminales.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMantenimientoTerminales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoTerminales.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnMantenimientoTerminales.Location = new System.Drawing.Point(95, 103);
            this.btnMantenimientoTerminales.Name = "btnMantenimientoTerminales";
            this.btnMantenimientoTerminales.Size = new System.Drawing.Size(132, 59);
            this.btnMantenimientoTerminales.TabIndex = 1;
            this.btnMantenimientoTerminales.Text = "Mantenimiento de Terminales";
            this.btnMantenimientoTerminales.UseVisualStyleBackColor = true;
            // 
            // btnMantenimientoViajes
            // 
            this.btnMantenimientoViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoViajes.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnMantenimientoViajes.Location = new System.Drawing.Point(95, 201);
            this.btnMantenimientoViajes.Name = "btnMantenimientoViajes";
            this.btnMantenimientoViajes.Size = new System.Drawing.Size(132, 59);
            this.btnMantenimientoViajes.TabIndex = 2;
            this.btnMantenimientoViajes.Text = "Mantenimiento de Viajes";
            this.btnMantenimientoViajes.UseVisualStyleBackColor = true;
            this.btnMantenimientoViajes.Click += new System.EventHandler(this.btnMantenimientoViajes_Click);
            // 
            // btnSocketComunicacion
            // 
            this.btnSocketComunicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocketComunicacion.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSocketComunicacion.Location = new System.Drawing.Point(95, 305);
            this.btnSocketComunicacion.Name = "btnSocketComunicacion";
            this.btnSocketComunicacion.Size = new System.Drawing.Size(132, 59);
            this.btnSocketComunicacion.TabIndex = 3;
            this.btnSocketComunicacion.Text = "Socket de comunicación";
            this.btnSocketComunicacion.UseVisualStyleBackColor = true;
            this.btnSocketComunicacion.Click += new System.EventHandler(this.btnSocketComunicacion_Click);
            // 
            // MenuPrincipall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.btnSocketComunicacion);
            this.Controls.Add(this.btnMantenimientoViajes);
            this.Controls.Add(this.btnMantenimientoTerminales);
            this.Controls.Add(this.lbl_menuprincipal);
            this.Name = "MenuPrincipall";
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_menuprincipal;
        private System.Windows.Forms.Button btnMantenimientoTerminales;
        private System.Windows.Forms.Button btnMantenimientoViajes;
        private System.Windows.Forms.Button btnSocketComunicacion;
    }
}