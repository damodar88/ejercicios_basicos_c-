using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio25
    {
        public void Mostrar()
        {
            Ejercicio25 p = new Ejercicio25();
            p.MostrarRango(1,25);
            Console.ReadKey();
        }

        public void MostrarRango(int menor, int mayor) {

            for (var x = menor;x<=mayor ; x++)
            {
                Console.Write(x+"");
            }
        
        }




    }
}
