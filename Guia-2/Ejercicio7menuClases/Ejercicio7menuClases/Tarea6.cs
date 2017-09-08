using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7menuClases
{
    class Tarea6
    {
        public void contrasena() {

            string  contrasena, contrUsuario;
            contrUsuario  = "123";
            
            do{
            Console.WriteLine("Ingrse una contraseña");
            contrasena = Console.ReadLine();

            if (contrasena == contrUsuario)
            {

                Console.WriteLine("Ingreso Correcto");
            }
            else {

                Console.WriteLine("Contraseña Incorrecta");
            
            }



            } while (contrasena == contrUsuario);



        
        
        
        }



    }
}
