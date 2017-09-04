using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7menuClases
{
    class Ejercicio15
    {
        public void corteNumerico()
        {

            int i, j, c;
            Console.Write("Ingrese un numero para el ciclo--:");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un numero para el corte--:");
            c = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= j; i++)
            {
                Console.WriteLine("numeros: {0}", i);
                if (i == c) goto salida;

            }
        salida:
            Console.Write("se corto em {0}, Fin del Programa ", c);
            Console.Read();
        }



    }
}
