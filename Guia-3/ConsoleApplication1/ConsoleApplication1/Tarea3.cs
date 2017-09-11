using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tarea3
    {
        public void tarea3() {

            int[] num = { 11111, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 118, 19, 20, 21, 22, 23, 224, 225, 26, 27, 28, 29, 30, 31, 32, 33, 34, 2222 };



            int[] primeros25 = new int[num.Length];


            for (int i = 0; i < num[26]; i++)
            {

                 primeros25[i]= num[i];
                Console.WriteLine("original--:"+primeros25[i]);


            }
            //ordeno de mayor a menor
            int j;
            int h;
            int aux;
            for (j = 0; j < primeros25.Length; j++)
            {

                for (h = 0; h < primeros25.Length; h++)
                {

                    if (primeros25[j] > primeros25[h])
                    {
                        aux = primeros25[h];
                        primeros25[h] = primeros25[j];
                        primeros25[j] = aux;
                        // Console.Write("aux" + aux);
                    }
                }

            }//fin 1º for

            int indice1, indice2, indice3;
            indice1 = primeros25[0];
            indice2 = primeros25[1];
            indice3 = primeros25[2];
            Console.WriteLine("###########################################");

            Console.WriteLine("1º numero--:" + primeros25[0]);
            Console.WriteLine("2º numero--:" + primeros25[1]);
            Console.WriteLine("3º numero--:" + primeros25[2]);
            int pocicion;


            for (int k = 0; k < num.Length; k++)
            {
                if (num[k] == indice1)
                {
                    pocicion = k;
                    Console.WriteLine("pocicion del 1º numero-:" + pocicion);
                }
                if (num[k] == indice2)
                {
                    pocicion = k;
                    Console.WriteLine("pocicion del 2º numero-:" + pocicion);
                }
                if (num[k] == indice3)
                {
                    pocicion = k;
                    Console.WriteLine("pocicion del 3º numero-:" + pocicion);

                }



            }

            Console.WriteLine("##########################################################");

            Console.Read();

        }



    }
}
