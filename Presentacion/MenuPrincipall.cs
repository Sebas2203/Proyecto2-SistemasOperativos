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
    public partial class MenuPrincipall : Form
    {
        public MenuPrincipall()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMantenimientoViajes_Click(object sender, EventArgs e)
        {
            FrmMantenimientoViajes frmMantenimientoViajes = new FrmMantenimientoViajes();
            frmMantenimientoViajes.Show();
            
        }

        private void btnSocketComunicacion_Click(object sender, EventArgs e)
        {
            Principal frmPrincipal = new Principal();
            frmPrincipal.Show();
            
        }
    }
}
