using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12DoWhile
{
    class Identifica
    {

        public void encuontrador() {

            int valor;
            string linea;
            do{
                Console.Write("Ingrese un valor entre 0 yield 999 (0 finalizar)--:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 dijitos");
                }
                else
                {

                    if (valor >= 10)
                    {
                        Console.WriteLine("Tiene 2 dijitos");
                    }
                    else
                    {
                        Console.WriteLine("Tiene un dijito");
                    }
                
                
                
                }


            
            
            
            }while(valor != 0);


        
        
        }
    
    
    
    }
}
