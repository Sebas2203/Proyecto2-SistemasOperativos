using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Servidor.Presentacion;


namespace Servidor
{
    public partial class Principal : Form
    {
        #region Atributos
        private TcpListener tcpListener;
        private Thread listenThread;
        private int clientesConectados;
        #endregion

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Txt_Mensajes.Text = "Servidor Iniciado. Esperando por clientes...\n";
            this.tcpListener = new TcpListener(IPAddress.Any, 30000);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }

        private void ListenForClients()
        {
            this.tcpListener.Start();
            while (true)
            {
                TcpClient client = this.tcpListener.AcceptTcpClient();
                clientesConectados++;
                if (InvokeRequired) Invoke(new Action(() => txtClientes.Text = clientesConectados.ToString()));

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] message = new byte[4096];
            int bytesRead;

            try
            {
                while (true)
                {
                    bytesRead = 0;
                    try { bytesRead = clientStream.Read(message, 0, message.Length); }
                    catch { break; }

                    if (bytesRead == 0) break;

                    string peticion = encoder.GetString(message, 0, bytesRead).Trim();
                    if (InvokeRequired) Invoke(new Action(() => Txt_Mensajes.AppendText("\n" + peticion)));

                 
                    if (peticion.Length != 3) { Enviar(clientStream, encoder, "5"); continue; } 
                    string codigoViaje = peticion.Substring(0, 2);
                    int cantidadBoletos;
                    if (!int.TryParse(peticion.Substring(2, 1), out cantidadBoletos)) { Enviar(clientStream, encoder, "5"); continue; }
                    if (cantidadBoletos < 1 || cantidadBoletos > 5) { Enviar(clientStream, encoder, "3"); continue; } 

               
                    ResultadoVenta res = RepositorioViajes.IntentarVenderBoletos(codigoViaje, cantidadBoletos);

                    string respuesta;
                    if (!res.Exito)
                    {
                        // Errore
                        var err = (res.MensajeError ?? "").ToLowerInvariant();
                        if (err.Contains("no existe")) respuesta = "4";
                        else if (err.Contains("cantidad inválida") || err.Contains("excede")) respuesta = "3";
                        else if (err.Contains("no hay asientos")) respuesta = "0"; 
                        else respuesta = "5"; 
                    }
                    else
                    {

                        // 1  : compra realizada verificador (1)
                        // 3  : excede cantidad verificador (1)
                        //4   : código de viaje no existe  verificador (1)
                        //0   : sin asientos verificador (1)
                        //5   : formato inválido / genérico verificador (1)

                        // 02-03 : código viaje
                        // 04-05 : fila1 (00–13)
                        // 06-10 : asientos fila1 (hasta 5, rellenar a la derecha con '0')
                        // 11-12 : fila2 (00–13)
                        // 13-14 : asientos fila2 (hasta 5, rellenar a la derecha con '0')
                        // 15-19 : monto (5 dígitos, sin separadores)
                        // 20-21 : capacidad disponible (2 dígitos)
                        respuesta = BuildTramaExito(res, codigoViaje);
                    }

                    Enviar(clientStream, encoder, respuesta);
                }
            }
            finally
            {
                try { tcpClient.Close(); } catch { }
                clientesConectados--;
                if (InvokeRequired) Invoke(new Action(() => txtClientes.Text = Math.Max(clientesConectados, 0).ToString()));
            }
        }


        private static void Enviar(NetworkStream stream, ASCIIEncoding enc, string texto)
        {
            byte[] buffer = enc.GetBytes(texto);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }

        private static string BuildTramaExito(ResultadoVenta res, string codigoViaje)
        {

            string verificador = "1";


            string codViaje = (codigoViaje ?? "").PadLeft(2, '0').Substring(0, 2);


            string fila1 = (res.Fila1 < 0 ? 0 : res.Fila1).ToString("00");


            string asientosFila1 = ToAsientosString(res.AsientosFila1);


            string fila2 = (res.Fila2 < 0 ? 0 : res.Fila2).ToString("00");


            string asientosFila2 = ToAsientosString(res.AsientosFila2);


            int montoEntero = (int)Math.Round(res.Monto, MidpointRounding.AwayFromZero);
            if (montoEntero < 0) montoEntero = 0;
            string monto = montoEntero.ToString().PadLeft(5, '0').Substring(Math.Max(0, montoEntero.ToString().Length - 5)).PadLeft(5, '0');


            int cap = res.CapacidadDisponible;
            if (cap < 0) cap = 0;
            if (cap > 99) cap = 99;
            string capacidadDisp = cap.ToString("00");

            return verificador + codViaje + fila1 + asientosFila1 + fila2 + asientosFila2 + monto + capacidadDisp;
        }

        private static string ToAsientosString(List<int> asientos)
        {

            if (asientos == null || asientos.Count == 0)
                return "00000";

            StringBuilder sb = new StringBuilder(5);
            int count = 0;
            foreach (var a in asientos)
            {
                if (count >= 5) break;
                int seat = a < 0 ? 0 : a;
                sb.Append(seat.ToString());
                count++;
            }
            while (sb.Length < 5) sb.Append('0');
            if (sb.Length > 5) return sb.ToString(0, 5);
            return sb.ToString();
        }


        public int Validar_Peticion(string Peticion)
        {
            switch (Peticion)
            {
                case "001": return 1;
                case "002": return 2;
                default: return -1;
            }
        }
    }
}

