using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio20
    {
        public void ejercicio20() { 
        int[] numero= new int[5];//array de 5 numeros enteros
        int suma;
        int i;

        for (i = 0; i <= 4; i++)  //recorro y pide datros
        {
            Console.Write("Introduce el dato {0}--:",i+1);
            numero[i] = Convert.ToInt32(Console.ReadLine());
        
        
        }
        suma = 0;
        for (i = 0; i <= 4;i++ ) 
        
        suma+= numero[i];

        Console.WriteLine("su suma es {0}",suma);
        Console.Read();
             

        } //fin del metodo




    }
}
