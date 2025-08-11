using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Presentacion
{
    public class Viaje
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string TerminalSalida { get; set; }
        public string TerminalLlegada { get; set; }
        public int Capacidad { get; set; }
        public decimal Costo { get; set; }
        public int CapacidadDisponible { get; set; }
        public int[,] Asientos { get; set; }

        public Viaje(string codigo, string descripcion, string salida, string llegada, int capacidad, decimal costo)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            TerminalSalida = salida;
            TerminalLlegada = llegada;
            Capacidad = capacidad;
            Costo = costo;
            CapacidadDisponible = capacidad;
            Asientos = new int[13, 7];
            LlenarAsientos();
        }

        private void LlenarAsientos()
        {
            for (int i = 0; i < 13; i++)
                for (int j = 0; j < 7; j++)
                    Asientos[i, j] = 1; // 1 = disponible
        }
        // 1=disponible, 0=ocupado
    }
}