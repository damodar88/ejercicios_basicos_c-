using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           MenuT(); }
             

  
            static void MenuT(){
                
                Console.WriteLine("1-- Tarea 1");
                Console.WriteLine("2-- Prueba");
                Console.WriteLine("3-- Salir");
                string opcionMP;
                opcionMP= Console.ReadLine();

                if (opcionMP == "3")
                {
                    Environment.Exit(0);
                }
                else
                {

                    while (opcionMP == "1")
                    {// MENU DE TAREAS
                        int valor;
                        bool esValido = false;
                        Console.WriteLine("1--Tarea1");
                        Console.WriteLine("2--Tarea2");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("elija opcion--:");
                        
                        esValido = int.TryParse(Console.ReadLine(), out valor);

                        Console.Clear();
                        Tarea1 t1 = new Tarea1();

                        switch (valor)
                        {
                            case 1:
                                t1.mostrar();
                                Console.Clear();
                                break;
                            case 3:
                                MenuT();
                               // Console.Clear();
                                break;
                            
                            default:
                                Console.WriteLine("Ingrese una opcion-:");
                                break;
                        }//switch cierre

                    } //while primero

                    while (opcionMP == "2")
                    {//MENU DE EJERCICIOS

                        int valor;
                        bool esValido = false;
                        Console.WriteLine("1--Prueba ejercicio1");
                        Console.WriteLine("2--Prueba segundo eje");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("elija opcion--:");

                        esValido = int.TryParse(Console.ReadLine(), out valor);

                        Console.Clear();
                        Tarea1 t1 = new Tarea1();

                        switch (valor)
                        {
                           
                            case 3:
                                MenuT();
                                // Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Ingrese una opcion-:");
                                break;
                        }//switch cierre

                    }//segundo while

                }//else
                
            
            }






        }
    
}
