using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Program
    {
        static void Main(string[] args)
        {
          //  MenuE(); 
            MenuT();
             }

  
            static void MenuT(){
                Tarea1 tarea1 = new Tarea1();

                Console.WriteLine("1-- Tarea 1");
                Console.WriteLine("2-- Ejercicios");
                Console.WriteLine("3-- Salir");
                string opcionMP;
                opcionMP= Console.ReadLine();

                while (opcionMP == "1")
                {
                    int valor;
                    bool esValido = false;
                    Console.WriteLine("1--Tarea1");
                    Console.WriteLine("2--Tarea2");
                    Console.WriteLine("0--Retroseder");
                    Console.WriteLine("elija opcion--:");
                    Console.WriteLine("");
                    esValido = int.TryParse(Console.ReadLine(), out valor);

            //        while (!esValido)
          //          {
                      //  Console.Clear();
                      //  Console.Write("Seleccione una opcion 1,2,0");
             //    esValido = int.TryParse(Console.ReadLine(), out valor);
                  //  }

                    switch (valor)
                    {
      
                        case 1:
                            tarea1.Mostrar();
                           // MenuT();
                            break;
                        case 2:
                            tarea1.Mostrar();
                           //MenuT();
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion-:");
                            break;



                    }
                   
                }
                    
               
                
                
            
            }




           
    
    }
}
