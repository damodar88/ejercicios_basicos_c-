using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Suma3numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int suma, mult;

            Console.WriteLine("Ingrese el primer numero--:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero--:");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;
            Console.WriteLine("La suma es ---:"+suma);

            Console.WriteLine("Ingrese un numero para multiplicar el resultado--:");
            num3 = Convert.ToInt32(Console.ReadLine());

            mult = suma * num3;
            Console.WriteLine("El resultado de la multiplicacion es--:"+mult);


            Console.Read();
        }
    }
}
