using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio26
    {
        public void Mostar() {
            Ejercicio26 p = new Ejercicio26();
            Console.Write("Ingrese primer valor --:");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo valor --:");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese tercer valor --:");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("El mayor de los tres es --:"+p.Mayor(x1, x2, x3));

            Console.ReadKey();
        
        
        }

        public int Mayor(int v1, int v2, int v3){

            if (v1 >= v2 && v1 >= v3){
                return v1;
            }
            else {

                if (v2 >= v3)
                {
                    return v2;
                }
                else {
                    return v3;
                }
            
            }//fin de else 1
        
        }//fin del metodo mostrar


    }
}
