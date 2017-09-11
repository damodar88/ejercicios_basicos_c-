using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Tarea7
    {
     public void multiplicarxcero(){
         int num1,num2,result;
         Console.WriteLine("ingrese un numero a multiplicar --:");
         num1 = int.Parse(Console.ReadLine());

         if (num1 == 0)
         {
             Console.WriteLine("el numero es 0 no se puede multiplicar");
             Console.ReadLine();
         }
         else {
             Console.WriteLine("Ingrese un segundo numero a multiplicar-:");
             num2 = int.Parse(Console.ReadLine());
             result = num1 * num2;
             Console.WriteLine("El resultado es--:"+result);
             Console.ReadLine();
         }
     
     }



    }
}
