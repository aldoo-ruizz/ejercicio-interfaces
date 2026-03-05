using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio_interfaces.interfaces;

namespace ejercicio_interfaces.clases
{
    public class emailnotificador : INotificable
    {
        public string email { get; set; }
        public emailnotificador()
        {
            Console.WriteLine("cual es su email?");
            email = Console.ReadLine();
        }
        public void enviarmensaje(string mensaje)
        {
            Console.WriteLine("que mensaje desea enviar?");
            mensaje = Console.ReadLine();
            Console.WriteLine($"[EMAIL] Para: {email} - Mensaje: {mensaje}");
        }   
        public void enviarconfirmacion()
        {
            Console.WriteLine($"[EMAIL] Confirmación enviada a {email}");
        }   
    }
}
