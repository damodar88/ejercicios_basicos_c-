using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tarea1
    {

        public void mostrar() {

       int[]num = {0,11,12,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,224,225,26,27,28,29,30,31,32,33,34,2222 };

       int[] copia = new int [num.Length];

       for (int i=0; i < num.Length; i++)
       {
           copia[i] = num[i];
          //se copian los arreglos
           //Console.Write("original--:"+num[i]);
           //Console.Write("copia--:" + copia[i]);
       }



     //ordeno de mayor a menor
            int j;
            int h;
            int aux;
            for (j = 0; j < copia.Length; j++)
            {

                for (h = 0; h < copia.Length; h++)
                { 
               
                 if(copia[j]>copia[h]){
                     aux = copia[h];
                     copia[h]=copia[j];
                     copia[j] = aux;
                    // Console.Write("aux" + aux);
                    }
                }
            
            }//fin 1º for

          int indice1, indice2, indice3; 
          indice1 = copia[0];
          indice2 = copia[1];
          indice3 = copia[2];

          Console.WriteLine("mayor--:" + copia[0]);
          Console.WriteLine("medio--:" + copia[1]);
          Console.WriteLine("menor--:" + copia[2]);
          int pocicion;
          for (int k = 0; k < num.Length;k++ )
          {
              if(num[k]==indice1){
                  pocicion = k;
                  Console.WriteLine("pocicion del mayor-:" + pocicion);
              }
              if(num[k]==indice2){
                  pocicion = k;
                  Console.WriteLine("pocicion del medio-:" + pocicion);
              }
              if (num[k] == indice3) {
                  pocicion = k;
                  Console.WriteLine("pocicion del menor-:"+pocicion);
              
              }



          }









                Console.Read();
     
        } // metodo






    }
}
