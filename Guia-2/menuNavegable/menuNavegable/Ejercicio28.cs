using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio28
    {

        public void Mostrar()
        {
            Ejercicio28 p = new Ejercicio28();
            Console.Write("El producto de 2*3*4 es-:");
            Console.WriteLine(p.Operar("producto",2,3,4));
            Console.Write("La suma de 5+10 es--:");
            Console.WriteLine(p.Operar("suma",5,10));
            Console.ReadKey();
        }

        public int Operar(string operacion, params int[] v)
        { 
        if(operacion=="suma")
        {
            int suma = 0;
            for (var f = 0; f < v.Length; f++)
            {
                suma = suma + v[f];
            }
            return suma;
        }//if 1ª
            if(operacion=="producto"){

                int producto = 1;
                for (var f = 0; f < v.Length; f++ )
                {
                    producto= producto * v[f];
                }

                return producto;
            }//fin 2ª if

            return int.MaxValue;
        
        }//fin metodo operar

    }
}
