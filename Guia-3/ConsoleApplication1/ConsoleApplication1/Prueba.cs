using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Prueba
    {
        public void mostrar() {

            int[] num = {-1,-2,3,-4,-3,4,1,7,3,-8,4,9,4,-10,3,-12,1,-2 };




            int[] negro = new int[num.Length];

            for (int i = 0; i+3 < num.Length; i++)
            {
               // negro[i] = num[i];
              //  Console.WriteLine("copia--:" +negro[i]);
               // Console.WriteLine("#############################################");


                if (num[i] < 0 && num[i + 1] > 0 && num[i + 2] < 0 && num[i + 3] > 0)
                {

                    Console.Write(":Gatillo negativo:" + num[i] + "," + num[i + 1]+","+num[i + 2]+","+ num[i + 3]);
                    
                    


                }
            }//primer for





            for (int j = 0; j + 3 < num.Length; j++)
            {
                // negro[i] = num[i];
                //  Console.WriteLine("copia--:" +negro[i]);
                // Console.WriteLine("#############################################");


                if (num[j] > 0 && num[j + 1] < 0 && num[j + 2] > 0 && num[j + 3] < 0)
                {

                    Console.Write(":Gatillo positivo:" + num[j] + "," + num[j + 1] + "," + num[j + 2] + "," + num[j + 3]);




                }
            }//primer for


         

            Console.Read();
        }


    }
}
