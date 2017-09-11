using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Tarea6
    {

        public void ingreso() {
            string contrasenaUsuario;
            string clave = "123";
        do{
        
            Console.WriteLine("Ingrese su contraseña--:");
            contrasenaUsuario= Console.ReadLine();

           
        } while (clave != contrasenaUsuario);
        
        Console.WriteLine("La contraseña es correcata");

        Console.ReadLine();
        
        }






    }
}
