using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14TablasMultiplicar
{
    class TabalaMultiplicar
    {


        public void tablaMult() {
            int num;
            do{

                Console.Write("Ingrese un Numero > 0 y <= 01--:");
                num = Int32.Parse(Console.ReadLine());
            
            
            }while(num <1 || num >10);

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} x {1} = {2} ",num , i ,num * i);
            Console.Read();
        
        }





    }
}
