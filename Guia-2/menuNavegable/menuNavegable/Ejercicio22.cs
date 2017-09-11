using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio22
    {
        public void ejercicio22() {
            int[][] notas; //array de dos dimenciones
            notas= new int[3][]; //3 bloques de datos
            notas[0]= new int[10];
            notas[1]= new int[15];
            notas[2]= new int[12];
            Console.WriteLine("Largo del arreglo [3,0] es:"+notas[0].Length);
            Console.WriteLine("latgo del arreglo [3,1 ] es:"+notas[1].Length);
            Console.WriteLine("largo del arreglo [3,3] es :"+notas[2].Length);

            //damos valoros de ejemplo
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas[i].Length; j++)
                {
                    notas[i][j] = i + j; 
                } //fin del for j


            }//fin del for i

            //mostrar valores

            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas[i].Length; j++)
                {
                    Console.Write("{0}",notas[i][j]);
                }
                Console.WriteLine();
            }

        
        }//fin del metodo


    }
}
