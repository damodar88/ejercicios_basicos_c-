﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio20guia2
    {

        public void ejercicio21(){
            int[,] notas1 = new int[2, 2]; //2 bloques de 2x2
            notas1[0, 0] = 1;//[0,0] alumno 1
            notas1[0, 1] = 2;//[0,1] alumno 2
            notas1[1,0]  = 3;//[1,0] alumno 3
            notas1[1, 1] = 4;//[1,1] alumno 4

            int[,] notas2 ={ // 2 bloques de 10 datos
                               {1,2,3,4,5,6,7,8,9,10},
                               {11,12,13,14,15,16,17,18,19,20}
                           };
            Console.WriteLine("la nota del 2º alumnos del grupo 1 es-:"+ notas1[0,1]);
            Console.WriteLine("la nota del 3º alumnos del grupo 1 es-:"+notas2[0,2]);
            Console.Read();
        }




    }
}
