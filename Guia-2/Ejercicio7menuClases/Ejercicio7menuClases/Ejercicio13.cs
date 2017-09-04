using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7menuClases
{
    class Ejercicio13
    {
        public void contadorNumeros()
        {

            int suma, i, valor, promedio;
            string linea;
            suma = 0;
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese Valor");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;

            }

            Console.Write("la suma es--:");
            Console.WriteLine(suma);
            promedio = suma / 5;
            Console.Write("El promedio es--:");
            Console.Write(promedio);
            Console.ReadKey();
        }



    }
}
