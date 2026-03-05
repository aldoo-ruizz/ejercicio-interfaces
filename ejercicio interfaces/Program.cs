using System;
using ejercicio_interfaces.clases;

namespace ejercicio_interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            do
            {
                Console.WriteLine("1) Enviar notificación mail");
                Console.WriteLine("2) Enviar notificación sms");
                Console.WriteLine("3) Salir");
                Console.Write("Opción: ");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        emailnotificador noti = new emailnotificador();
                        noti.enviarmensaje("Mensaje de prueba");
                        noti.enviarconfirmacion();
                        break;

                    case 2:
                        smsnotificador noti2 = new smsnotificador();
                        noti2.enviarmensaje("Mensaje de prueba");
                        noti2.enviarconfirmacion();

                        break;

                    case 3:
                        Console.WriteLine("Adiós.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();

            } while (opt != 3);
        }
    }
}
