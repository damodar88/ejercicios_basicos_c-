using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4NumeroMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;

            Console.WriteLine("Ingrese el primer numero--:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero--:");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
            
            Console.WriteLine("El primer numero {0} es mayor",num1);
            }else{
            
            Console.WriteLine("El segundo numero {0} ingresado es mayor",num2);
            }



            Console.Read();
        }
    }
}
