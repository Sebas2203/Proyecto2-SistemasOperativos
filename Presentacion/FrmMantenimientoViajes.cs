using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor.Presentacion
{
    public partial class FrmMantenimientoViajes : Form
    {
        private List<Viaje> viajes = new List<Viaje>();

        public FrmMantenimientoViajes()
        {
            //programa prueba
            InitializeComponent();
        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }

        // Botón GRABAR
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            // Verificar que no exista un viaje con el mismo código
            if (viajes.Any(v => v.Codigo == txtCodigoViaje.Text))
            {
                MessageBox.Show("Ya existe un viaje con ese código.");
                return;
            }

            // Crear y agregar viaje
            var nuevoViaje = new Viaje(
                txtCodigoViaje.Text,
                txtDescripcion.Text,
                txtTerminalSalida.Text,
                txtTerminalLlegada.Text,
                int.Parse(txtCapacidad.Text),
                decimal.Parse(txtCosto.Text)
            );

            viajes.Add(nuevoViaje);
            MessageBox.Show("Viaje guardado correctamente.");
            LimpiarCampos();
        }

        // Botón ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var viaje = viajes.FirstOrDefault(v => v.Codigo == txtCodigoViaje.Text);
            if (viaje != null)
            {
                viajes.Remove(viaje);
                MessageBox.Show("Viaje eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se encontró un viaje con ese código.");
            }
            LimpiarCampos();
        }

        // Botón LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Validar campos antes de grabar
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoViaje.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtTerminalSalida.Text) ||
                string.IsNullOrWhiteSpace(txtTerminalLlegada.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!int.TryParse(txtCapacidad.Text, out int cap) || cap <= 0)
            {
                MessageBox.Show("Capacidad debe ser un número positivo.");
                return false;
            }

            if (!decimal.TryParse(txtCosto.Text, out decimal cost) || cost <= 0)
            {
                MessageBox.Show("Costo debe ser un número positivo.");
                return false;
            }

            return true;
        }

        // Limpiar cajas de texto
        private void LimpiarCampos()
        {
            txtCodigoViaje.Clear();
            txtDescripcion.Clear();
            txtTerminalSalida.Clear();
            txtTerminalLlegada.Clear();
            txtCapacidad.Clear();
            txtCosto.Clear();
        }
    }
}
