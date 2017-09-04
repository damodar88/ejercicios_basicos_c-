using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7menuClases
{
    class Ejercicio10
    {


        public void promediar()
        {
            int i = 0;
            float num, acum = 0;

            while (i < 5)
            {
                Console.Write("Ingrese {0}º numero-:", i + 1);
                num = float.Parse(Console.ReadLine());
                acum += num;
                i++;


            }

            Console.Write("El promedio de los 5 numeros es-:{0}", acum / 5);
            Console.Read();


        }



    }
}
