using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Promedio
{
    class Program
    {
        static void Main(string[] args)
        {

            float num1, num2, num3, num4;
            float promedio;

            Console.WriteLine("ingrese el primer  dijito");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo dijito");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el terser  dijito");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el cuarto  dijito");
            num4 = Convert.ToInt32(Console.ReadLine());

            promedio = (float)num1 + (float)num2 + (float)num3 + (float)num4 / (float)4;

            Console.WriteLine("El promedio de los 4 dijitos es--:"+promedio);



            Console.Read();
        }
    }
}
