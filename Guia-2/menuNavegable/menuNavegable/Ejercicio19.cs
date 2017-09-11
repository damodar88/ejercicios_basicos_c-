using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio19
    {
        public void ejercicio19() {
            int[] numero = {200,150,100,-50,300 };
            int suma = 0;
            int i;
            for (i = 0; i <= 4;i++ )
            {
                suma+=numero[i];
            }
            Console.WriteLine("Lasuma es--:"+suma);
            Console.ReadKey();

        }


    }
}
