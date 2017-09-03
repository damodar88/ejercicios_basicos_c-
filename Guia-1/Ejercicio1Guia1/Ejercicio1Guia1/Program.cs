using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Guia1
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre = "damodar";
            int edad = 29;

            Console.WriteLine("nombre es --:"+nombre);
            Console.WriteLine("edad es ----:"+edad);
            Console.WriteLine("edad es {0} y edad es {0}",nombre,edad);


            Console.Write("Escriba su nombre--:");
            String nombre2 = Console.ReadLine();

            Console.Write("Escriba su edad--:");
            int edad2 = int.Parse(Console.ReadLine());

            Console.WriteLine("nomre--:"+nombre2+"tu edad es--:"+edad2);



            Console.WriteLine("Precione una tecla---:");
            ConsoleKeyInfo c = Console.ReadKey();
            Console.WriteLine("Precionaste la tecla---:"+ c.KeyChar);




            Console.Read();




        }
    }
}
