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
                Console.WriteLine("################################");
                Console.WriteLine("1-- Tarea ");
                Console.WriteLine("2-- Prueba");
                Console.WriteLine("3-- Salir");
                Console.WriteLine("################################");
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
                        Console.WriteLine("################################");
                        Console.WriteLine("1--Tarea1");
                        Console.WriteLine("2--Tarea2");
                        Console.WriteLine("3--Tarea3");
                        Console.WriteLine("4--Retroseder");
                        Console.WriteLine("elija opcion--:");
                        Console.WriteLine("################################");




                        esValido = int.TryParse(Console.ReadLine(), out valor);

                        Console.Clear();
                        Tarea1 t1 = new Tarea1();
                        Tarea2 t2 = new Tarea2();
                        Tarea3 t3 = new Tarea3();
                        switch (valor)
                        {
                            case 1:
                                t1.mostrar();
                                Console.Clear();
                                break;
                            case 2:
                                t2.tarea2();
                                Console.Clear();
                                break;
                            case 3:
                                t3.tarea3();
                                Console.Clear();
                                break; 
                            
                            case 4:
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
                        Console.WriteLine("################################");
                        Console.WriteLine("1--Prueba Ejercicio 1");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("elija opcion--:");
                        Console.WriteLine("################################");
                        esValido = int.TryParse(Console.ReadLine(), out valor);

                        Prueba p1 = new Prueba();

                        switch (valor)
                        {
                            case 1:
                                p1.mostrar();
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

                    }//segundo while

                }//else
                
            
            }






        }
    
}
