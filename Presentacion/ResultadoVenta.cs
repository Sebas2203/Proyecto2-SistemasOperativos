using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Presentacion
{
    public class ResultadoVenta
    {
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
        public int Fila1 { get; set; }
        public List<int> AsientosFila1 { get; set; }
        public int Fila2 { get; set; }
        public List<int> AsientosFila2 { get; set; }
        public decimal Monto { get; set; }
        public int CapacidadDisponible { get; set; }

        public ResultadoVenta()
        {
            MensajeError = "";
            AsientosFila1 = new List<int>();
            AsientosFila2 = new List<int>();
        }
    }
}