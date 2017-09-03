using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Identificador
    {



        public  void calculaNumero()
        {
            int numero;
            Console.WriteLine("Ingresa un Numero (0 para salir)--:");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero != 0)
            {
                if (numero > 0) Console.WriteLine("Es positivo");
                else Console.WriteLine("Es negativo");


                Console.WriteLine("Teclea otro numero (0 para salir):");
                numero = Convert.ToInt32(Console.ReadLine());
            }
        }
    
    }
}
