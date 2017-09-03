using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Corte
    {

        public void corteNumero() {

         inicio:
            int i, j, c;
            Console.Clear();
            Console.Write("ingrese un numero para el ciclo--:");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese un numero para el corte--:");
            c = Convert.ToInt32(Console.ReadLine());
            
            if (j <= c)
            {
                Console.WriteLine("Error su numero ingresado es menor");
                Console.ReadKey();
                goto inicio;
            }
            else
            {
                for (i = 0; i <= j; i++)
                {
                    Console.WriteLine("numero : {0}",i);
                    if (i == c) goto salida;
                
                }
            salida:
                Console.Write("se corto en {0}, Fin del programa",c);
            Console.ReadKey();
            }

        
        
        }




    }
}
