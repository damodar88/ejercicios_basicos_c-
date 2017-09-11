using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tarea2
    {

        public void tarea2() {
           
            int[] num = { 110, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 118, 19, 20, 21, 22, 23, 224, 225, 26, 27, 28, 29, 30, 31, 32, 33, 34, 2222 };



            int[] primeros11 = new int[num.Length];

           
            for (int i = 0; i <= num[11]; i++)
            {

                primeros11[i] = num[i];
                  Console.WriteLine("original--:"+num[i]);
            
            
            }

            //ordeno de mayor a menor
            int j;
            int h;
            int aux;
            for (j = 0; j < primeros11.Length; j++)
            {

                for (h = 0; h < primeros11.Length; h++)
                {

                    if (primeros11[j] > primeros11[h])
                    {
                        aux = primeros11[h];
                        primeros11[h] = primeros11[j];
                        primeros11[j] = aux;
                        // Console.Write("aux" + aux);
                    }
                }

            }//fin 1º for

            int indice1;
            indice1 = primeros11[0];
            Console.WriteLine("mayor -:" + indice1);

           
            int pocicion;
            for (int k = 0; k < num.Length; k++)
            {
                if (num[k] == indice1)
                {
                    pocicion = k;
                    Console.WriteLine("pocicion del primeros once dijitos-:" + pocicion);
                }
            }


            Console.WriteLine("##############################################");

            int[] primeros22 = new int[num.Length];


            for (int i = 11; i < num[22]; i++)
            {

                primeros22[i] = num[i];
                Console.WriteLine("medio 11--:" + primeros22[i]);


            }

            //ordeno de mayor a menor

            int l;
            for (l = 0; l < primeros22.Length; l++)
            {

                for (h = 0; h < primeros22.Length; h++)
                {

                    if (primeros22[l] > primeros22[h])
                    {
                        aux = primeros22[h];
                        primeros22[h] = primeros22[l];
                        primeros22[l] = aux;
                        // Console.Write("aux" + aux);
                    }
                }

            }//fin 1º for


            int indice2;
            indice2 = primeros22[0];
            Console.WriteLine("mayor -:"+indice2);


            int pocicion2;
            for (int k = 0; k < num.Length; k++)
            {
                if (num[k] == indice2)
                {
                    pocicion2 = k;
                    Console.WriteLine("pocicion del segundos once dijitos-:" + pocicion2);
                }
            }


            Console.WriteLine("##############################################");


            int[] primeros33 = new int[num.Length];


            for (int i = 22; i <= num[33]; i++)
            {

                primeros33[i] = num[i];
                Console.WriteLine("final mas de 33--:" + primeros33[i]);


            }

            //ordeno de mayor a menor
        
            for (l = 0; l < primeros33.Length; l++)
            {

                for (h = 0; h < primeros33.Length; h++)
                {

                    if (primeros33[l] > primeros33[h])
                    {
                        aux = primeros33[h];
                        primeros33[h] = primeros33[l];
                        primeros33[l] = aux;
                        // Console.Write("aux" + aux);
                    }
                }

            }//fin 1º for


            int indice3;
            indice3 = primeros33[0];
            Console.WriteLine("mayor -:"+indice3);


            int pocicion3;
            for (int k = 0; k < num.Length; k++)
            {
                if (num[k] == indice3)
                {
                    pocicion3 = k;
                    Console.WriteLine("pocicion del primeros once dijitos-:"+pocicion3);
                }
            }



            Console.Read();
        
        
        
        }




    }
}
