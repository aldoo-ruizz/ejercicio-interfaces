using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_interfaces.interfaces
{
    public interface INotificable
    {
        void enviarmensaje(string mensaje); 
        void enviarconfirmacion();
    }
}
