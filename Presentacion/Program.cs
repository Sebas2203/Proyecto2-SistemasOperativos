using Servidor.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipall());
            //Application.Run(new Principal());
            //Application.Run(new FrmMantenimientoViajes());

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            ////Abrir primero el mantenimiento de viajes
            //using (FrmMantenimientoViajes frmMantenimiento = new FrmMantenimientoViajes())
            //{
            //    frmMantenimiento.ShowDialog();
            //}

            ////Al cerrarlo, abrir el formulario Principal
            //Application.Run(new Principal());
            ////Application.Run(new MenuPrincipall());
        }
    }
}
