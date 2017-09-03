using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico3IngresoDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un Nombre---:");
            String nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un Numero----:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("El nombre ingresado es {0} numero ingresado {1}",nombre,numero);


            Console.Read();


        }
    }
}
