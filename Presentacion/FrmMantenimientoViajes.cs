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
        
        public FrmMantenimientoViajes()
        {

            InitializeComponent();
        }

        private void lblCosto_Click(object sender, EventArgs e)
        {

        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (RepositorioViajes.BuscarPorCodigo(txtCodigoViaje.Text) != null)
            {
                MessageBox.Show("Ya existe un viaje con ese código.");
                return;
            }

            var nuevoViaje = new Viaje(
                txtCodigoViaje.Text,
                txtDescripcion.Text,
                txtTerminalSalida.Text,
                txtTerminalLlegada.Text,
                int.Parse(txtCapacidad.Text),
                decimal.Parse(txtCosto.Text)
            );

            if (RepositorioViajes.Agregar(nuevoViaje))
                MessageBox.Show("Viaje guardado correctamente.");
            else
                MessageBox.Show("No se pudo guardar el viaje.");

            LimpiarCampos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (RepositorioViajes.Eliminar(txtCodigoViaje.Text))
                MessageBox.Show("Viaje eliminado correctamente.");
            else
                MessageBox.Show("No se encontró un viaje con ese código.");

            LimpiarCampos();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


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


        private void LimpiarCampos()
        {
            txtCodigoViaje.Clear();
            txtDescripcion.Clear();
            txtTerminalSalida.Clear();
            txtTerminalLlegada.Clear();
            txtCapacidad.Clear();
            txtCosto.Clear();
        }

        private void FrmMantenimientoViajes_Load(object sender, EventArgs e)
        {

        }
    }
}
