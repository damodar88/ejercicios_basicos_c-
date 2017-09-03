using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Introduce tu nombre--:");
            nombre = Console.ReadLine();
            switch (nombre)
            {

                case "Juan": Console.WriteLine("Bienvenido Juan");
                    break;

                case "diego": Console.WriteLine("Bienvenido diego");
                    break;

                case "manuel": Console.WriteLine("Bienvenido manuel");
                    break;

                default: Console.WriteLine("Quien eres desconocido");

                    break;
            }






            Console.Read();
        }
    }
}
