namespace Servidor.Presentacion
{
    partial class FrmMantenimientoViajes
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
            this.lblCodigoViaje = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTerminalSalida = new System.Windows.Forms.Label();
            this.lblTerminalLlegada = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCodigoViaje = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTerminalSalida = new System.Windows.Forms.TextBox();
            this.txtTerminalLlegada = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMantenimientoViajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigoViaje
            // 
            this.lblCodigoViaje.AutoSize = true;
            this.lblCodigoViaje.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoViaje.Location = new System.Drawing.Point(40, 112);
            this.lblCodigoViaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoViaje.Name = "lblCodigoViaje";
            this.lblCodigoViaje.Size = new System.Drawing.Size(106, 18);
            this.lblCodigoViaje.TabIndex = 0;
            this.lblCodigoViaje.Text = "Código de Viaje";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(35, 168);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(121, 27);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblTerminalSalida
            // 
            this.lblTerminalSalida.AutoSize = true;
            this.lblTerminalSalida.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminalSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerminalSalida.Location = new System.Drawing.Point(620, 257);
            this.lblTerminalSalida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminalSalida.Name = "lblTerminalSalida";
            this.lblTerminalSalida.Size = new System.Drawing.Size(153, 23);
            this.lblTerminalSalida.TabIndex = 2;
            this.lblTerminalSalida.Text = "Terminal de Salida";
            // 
            // lblTerminalLlegada
            // 
            this.lblTerminalLlegada.AutoSize = true;
            this.lblTerminalLlegada.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminalLlegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerminalLlegada.Location = new System.Drawing.Point(603, 301);
            this.lblTerminalLlegada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminalLlegada.Name = "lblTerminalLlegada";
            this.lblTerminalLlegada.Size = new System.Drawing.Size(170, 23);
            this.lblTerminalLlegada.TabIndex = 3;
            this.lblTerminalLlegada.Text = "Terminal de LLegada";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(49, 253);
            this.lblCapacidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(92, 23);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(92, 297);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(54, 23);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // txtCodigoViaje
            // 
            this.txtCodigoViaje.Location = new System.Drawing.Point(164, 110);
            this.txtCodigoViaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoViaje.Name = "txtCodigoViaje";
            this.txtCodigoViaje.Size = new System.Drawing.Size(85, 22);
            this.txtCodigoViaje.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(164, 173);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(947, 22);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtTerminalSalida
            // 
            this.txtTerminalSalida.AllowDrop = true;
            this.txtTerminalSalida.Location = new System.Drawing.Point(781, 259);
            this.txtTerminalSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerminalSalida.Name = "txtTerminalSalida";
            this.txtTerminalSalida.Size = new System.Drawing.Size(330, 22);
            this.txtTerminalSalida.TabIndex = 8;
            // 
            // txtTerminalLlegada
            // 
            this.txtTerminalLlegada.AllowDrop = true;
            this.txtTerminalLlegada.Location = new System.Drawing.Point(781, 303);
            this.txtTerminalLlegada.Margin = new System.Windows.Forms.Padding(4);
            this.txtTerminalLlegada.Name = "txtTerminalLlegada";
            this.txtTerminalLlegada.Size = new System.Drawing.Size(330, 22);
            this.txtTerminalLlegada.TabIndex = 9;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(164, 255);
            this.txtCapacidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(103, 22);
            this.txtCapacidad.TabIndex = 10;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(164, 299);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(103, 22);
            this.txtCosto.TabIndex = 11;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.Olive;
            this.btnGrabar.Location = new System.Drawing.Point(41, 409);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(100, 28);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(167, 409);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(295, 409);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(1011, 408);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblMantenimientoViajes
            // 
            this.lblMantenimientoViajes.AutoSize = true;
            this.lblMantenimientoViajes.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimientoViajes.Location = new System.Drawing.Point(304, 18);
            this.lblMantenimientoViajes.Name = "lblMantenimientoViajes";
            this.lblMantenimientoViajes.Size = new System.Drawing.Size(523, 46);
            this.lblMantenimientoViajes.TabIndex = 16;
            this.lblMantenimientoViajes.Text = "Mantenimiento Viajes - Numbat";
            // 
            // FrmMantenimientoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1144, 483);
            this.Controls.Add(this.lblMantenimientoViajes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtTerminalLlegada);
            this.Controls.Add(this.txtTerminalSalida);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoViaje);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblTerminalLlegada);
            this.Controls.Add(this.lblTerminalSalida);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigoViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMantenimientoViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMantenimientoViajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoViaje;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTerminalSalida;
        private System.Windows.Forms.Label lblTerminalLlegada;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCodigoViaje;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTerminalSalida;
        private System.Windows.Forms.TextBox txtTerminalLlegada;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMantenimientoViajes;
    }
}