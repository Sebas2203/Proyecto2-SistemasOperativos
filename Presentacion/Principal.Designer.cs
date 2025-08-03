namespace Servidor
{
    partial class Principal
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
            this.Txt_Mensajes = new System.Windows.Forms.TextBox();
            this.lblClientesConectados = new System.Windows.Forms.Label();
            this.txtClientes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Mensajes
            // 
            this.Txt_Mensajes.Location = new System.Drawing.Point(12, 106);
            this.Txt_Mensajes.Multiline = true;
            this.Txt_Mensajes.Name = "Txt_Mensajes";
            this.Txt_Mensajes.Size = new System.Drawing.Size(755, 335);
            this.Txt_Mensajes.TabIndex = 0;
            // 
            // lblClientesConectados
            // 
            this.lblClientesConectados.AutoSize = true;
            this.lblClientesConectados.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblClientesConectados.Location = new System.Drawing.Point(171, 47);
            this.lblClientesConectados.Name = "lblClientesConectados";
            this.lblClientesConectados.Size = new System.Drawing.Size(196, 27);
            this.lblClientesConectados.TabIndex = 1;
            this.lblClientesConectados.Text = "Clientes Conectados";
            // 
            // txtClientes
            // 
            this.txtClientes.Enabled = false;
            this.txtClientes.Location = new System.Drawing.Point(373, 47);
            this.txtClientes.Name = "txtClientes";
            this.txtClientes.Size = new System.Drawing.Size(185, 22);
            this.txtClientes.TabIndex = 2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(779, 463);
            this.Controls.Add(this.txtClientes);
            this.Controls.Add(this.lblClientesConectados);
            this.Controls.Add(this.Txt_Mensajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Mensajes;
        private System.Windows.Forms.Label lblClientesConectados;
        private System.Windows.Forms.TextBox txtClientes;
    }
}

