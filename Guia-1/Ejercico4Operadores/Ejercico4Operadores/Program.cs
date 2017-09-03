using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico4Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma , rsta , mult;
            double div;
            Console.WriteLine("Ingrese el primer numero--:");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero--:");
            num2 = Convert.ToInt32(Console.ReadLine());
            suma=num1+num2;
            rsta =num1-num2;
            mult = num1 * num2;
            div= (double)num1 / (double)num2;

            Console.WriteLine("\n El sesultado suma es------------:"+suma);
            Console.WriteLine("\n El sesultado resta es-----------:"+rsta);
            Console.WriteLine("\n El sesultado multiplicacion es--:"+mult);
            Console.WriteLine("\n El sesultado divicion es--------:"+div);

            Console.Read();


        }
    }
}
