using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Presentacion
{
    public static class RepositorioViajes
    {
        private static readonly object _bloqueo = new object();
        private static readonly List<Viaje> _listaViajes = new List<Viaje>();

        public static IReadOnlyList<Viaje> ObtenerTodos()
        {
            lock (_bloqueo) return _listaViajes.ToList();
        }

        public static bool Agregar(Viaje viaje)
        {
            if (viaje == null) return false;
            lock (_bloqueo)
            {
                if (_listaViajes.Any(v => v.Codigo == viaje.Codigo)) return false;
                _listaViajes.Add(viaje);
                return true;
            }
        }

        public static bool Eliminar(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return false;
            lock (_bloqueo)
            {
                var viaje = _listaViajes.FirstOrDefault(v => v.Codigo == codigo);
                if (viaje == null) return false;
                _listaViajes.Remove(viaje);
                return true;
            }
        }

        public static Viaje BuscarPorCodigo(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo)) return null;
            lock (_bloqueo) return _listaViajes.FirstOrDefault(v => v.Codigo == codigo);
        }

        // >>>>> DEVUELVE ResultadoVenta (NO Tuple)
        public static ResultadoVenta IntentarVenderBoletos(string codigo, int cantidad)
        {
            var r = new ResultadoVenta();

            if (cantidad < 1 || cantidad > 5)
            {
                r.Exito = false;
                r.MensajeError = "Cantidad inválida (1 a 5 boletos).";
                return r;
            }

            lock (_bloqueo)
            {
                var viaje = _listaViajes.FirstOrDefault(v => v.Codigo == codigo);
                if (viaje == null)
                {
                    r.Exito = false;
                    r.MensajeError = "Código de viaje no existe.";
                    return r;
                }

                if (viaje.CapacidadDisponible < cantidad)
                {
                    r.Exito = false;
                    r.MensajeError = "No hay asientos disponibles.";
                    return r;
                }

                // TODO: aquí va la lógica real de asignación de asientos
                viaje.CapacidadDisponible -= cantidad;

                r.Exito = true;
                r.Monto = viaje.Costo * cantidad;
                r.CapacidadDisponible = viaje.CapacidadDisponible;
                r.Fila1 = 0;
                r.Fila2 = 0;
                return r;
            }
        }
    }
}