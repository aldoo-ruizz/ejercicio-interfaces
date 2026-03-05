using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio_interfaces.interfaces;

namespace ejercicio_interfaces.clases
{
    /// <summary>
    /// ARD 20260503
    /// se creo una clase smsnotificador que implementa la interfaz INotificable para enviar notificaciones por SMS. La clase tiene una propiedad numero para almacenar el número de teléfono del destinatario, y los métodos enviarmensaje y enviarconfirmacion para enviar mensajes y confirmaciones respectivamente.
    /// </summary>
    internal class smsnotificador: INotificable
    {
        public int numero { get; set; }

        public smsnotificador()
        {
            try
            {
                Console.WriteLine("cual es su numero?");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
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
