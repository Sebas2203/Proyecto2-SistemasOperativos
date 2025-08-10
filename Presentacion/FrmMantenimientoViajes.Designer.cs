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
            this.lblCodigoViaje.Location = new System.Drawing.Point(30, 91);
            this.lblCodigoViaje.Name = "lblCodigoViaje";
            this.lblCodigoViaje.Size = new System.Drawing.Size(87, 16);
            this.lblCodigoViaje.TabIndex = 0;
            this.lblCodigoViaje.Text = "Código de Viaje";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(26, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 22);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblTerminalSalida
            // 
            this.lblTerminalSalida.AutoSize = true;
            this.lblTerminalSalida.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminalSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerminalSalida.Location = new System.Drawing.Point(447, 210);
            this.lblTerminalSalida.Name = "lblTerminalSalida";
            this.lblTerminalSalida.Size = new System.Drawing.Size(133, 19);
            this.lblTerminalSalida.TabIndex = 2;
            this.lblTerminalSalida.Text = "Terminal de Salida";
            // 
            // lblTerminalLlegada
            // 
            this.lblTerminalLlegada.AutoSize = true;
            this.lblTerminalLlegada.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerminalLlegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTerminalLlegada.Location = new System.Drawing.Point(435, 247);
            this.lblTerminalLlegada.Name = "lblTerminalLlegada";
            this.lblTerminalLlegada.Size = new System.Drawing.Size(145, 19);
            this.lblTerminalLlegada.TabIndex = 3;
            this.lblTerminalLlegada.Text = "Terminal de LLegada";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(37, 206);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(75, 19);
            this.lblCapacidad.TabIndex = 4;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(69, 241);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(44, 19);
            this.lblCosto.TabIndex = 5;
            this.lblCosto.Text = "Costo";
            this.lblCosto.Click += new System.EventHandler(this.lblCosto_Click);
            // 
            // txtCodigoViaje
            // 
            this.txtCodigoViaje.Location = new System.Drawing.Point(123, 89);
            this.txtCodigoViaje.Name = "txtCodigoViaje";
            this.txtCodigoViaje.Size = new System.Drawing.Size(65, 20);
            this.txtCodigoViaje.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(711, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtTerminalSalida
            // 
            this.txtTerminalSalida.AllowDrop = true;
            this.txtTerminalSalida.Location = new System.Drawing.Point(586, 210);
            this.txtTerminalSalida.Name = "txtTerminalSalida";
            this.txtTerminalSalida.Size = new System.Drawing.Size(248, 20);
            this.txtTerminalSalida.TabIndex = 8;
            // 
            // txtTerminalLlegada
            // 
            this.txtTerminalLlegada.AllowDrop = true;
            this.txtTerminalLlegada.Location = new System.Drawing.Point(586, 246);
            this.txtTerminalLlegada.Name = "txtTerminalLlegada";
            this.txtTerminalLlegada.Size = new System.Drawing.Size(248, 20);
            this.txtTerminalLlegada.TabIndex = 9;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(123, 207);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(78, 20);
            this.txtCapacidad.TabIndex = 10;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(123, 243);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(78, 20);
            this.txtCosto.TabIndex = 11;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.Olive;
            this.btnGrabar.Location = new System.Drawing.Point(31, 332);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(125, 332);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Location = new System.Drawing.Point(221, 332);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.Location = new System.Drawing.Point(758, 332);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMantenimientoViajes
            // 
            this.lblMantenimientoViajes.AutoSize = true;
            this.lblMantenimientoViajes.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantenimientoViajes.Location = new System.Drawing.Point(228, 15);
            this.lblMantenimientoViajes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMantenimientoViajes.Name = "lblMantenimientoViajes";
            this.lblMantenimientoViajes.Size = new System.Drawing.Size(423, 37);
            this.lblMantenimientoViajes.TabIndex = 16;
            this.lblMantenimientoViajes.Text = "Mantenimiento Viajes - Numbat";
            // 
            // FrmMantenimientoViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(858, 392);
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