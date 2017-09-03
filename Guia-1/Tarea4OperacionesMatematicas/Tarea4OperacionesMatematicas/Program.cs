using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4OperacionesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            float suma,resta, mult,div;
            Console.WriteLine("Ingrese el primer dijito---:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese le segundo digito--:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Multiplicarlos");
            Console.WriteLine("Elija la opcion deseada---:");
            string opcion = Console.ReadLine();
           


            if(opcion=="1")
            {
               suma=num1+num2;
                Console.WriteLine("La suma es--:"+suma);
            }
            if(opcion=="2")
            {
                resta= num1-num2;
            Console.WriteLine("La resta es--:"+resta);
            }

            if (opcion == "3")
            {
                div = num1 / num2;
            Console.WriteLine("El resultado es--:"+div);
            }

            if(opcion=="4")
            {
                mult = num1 * num2;
            Console.WriteLine("El resultado de multiplicacion es --:"+mult);
            }









            Console.Read();
        }
    }
}
