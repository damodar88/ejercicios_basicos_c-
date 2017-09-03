using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6ParInpar
{
    class Program
    {
        static void Main(string[] args)
        {

            float num;

            Console.WriteLine("Ingrese un numero para verificar si es par inpar---:");
            num = float.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write("El numero {0} es par", num);

            }
            else {
                Console.Write("El {0} numero es inpar", num);
            
            }


            Console.Read();





        }
    }
}
