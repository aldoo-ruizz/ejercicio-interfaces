using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio_interfaces.interfaces;

namespace ejercicio_interfaces.clases
{
    internal class smsnotificador: INotificable
    {
        public string numero { get; set; }

        public smsnotificador()
        {
            Console.WriteLine("cual es su numero?");
            numero = Console.ReadLine();
        }

        public void enviarmensaje(string mensaje)
        {
            Console.WriteLine("que mensaje desea enviar?");
            mensaje = Console.ReadLine();
            Console.WriteLine($"[SMS] Para: {numero} - Mensaje: {mensaje}");
        }

        public void enviarconfirmacion()
        {
            Console.WriteLine($"[SMS] Confirmación enviada a {numero}");
        }
    }
}
