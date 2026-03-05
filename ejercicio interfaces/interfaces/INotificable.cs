using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_interfaces.interfaces
{
    /// <summary>
    /// ARD 20260503
    /// se creo una interfaz INotificable que define los métodos para enviar mensajes y confirmaciones, y luego se implementa esta interfaz en las clases emailnotificador y smsnotificador para enviar notificaciones por email y sms respectivamente.
    /// </summary>
    public interface INotificable
    {
        void enviarmensaje(string mensaje); 
        void enviarconfirmacion();
    }
}
