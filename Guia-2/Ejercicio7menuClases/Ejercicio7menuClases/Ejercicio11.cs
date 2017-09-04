using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7menuClases
{
    class Ejercicio11
    {

        public void indicandor()
        {
            float numero;
            uint cont = 0, menor = 0, mayor = 0;

            while (cont < 10)
            {

                Console.Write("Ingrese Numero----:");
                numero = float.Parse(Console.ReadLine());

                if (numero > 0)
                    mayor++;
                if (numero < 0)
                    menor++;


                cont++;
            }

            Console.WriteLine("de 10 numeros son..\n Numeros menores a 0 = {0} y mayores a 0 ={1}", menor, mayor);
            Console.Read();

        }





    }
}
