using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5operadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Primer numero es---:");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0)
            {

                Console.WriteLine("El numero ingresado es mayor a 0");
            }
            
            if(num1==0)
            {
                Console.WriteLine("El numero es igual a 0");
            }
            
            
            else {

                Console.WriteLine("El numero es menor que 0");
            }




            Console.Read();

        }
    }
}
