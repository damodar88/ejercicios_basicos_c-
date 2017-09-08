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
                Class1 clas = new Class1();

                Console.WriteLine("1-- Tarea 1");
                Console.WriteLine("2-- Ejercicios");
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
                    {
                        int valor;
                        bool esValido = false;
                        Console.WriteLine("1--Tarea1");
                        Console.WriteLine("2--Tarea2");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("elija opcion--:");
                        Console.WriteLine("");
                        esValido = int.TryParse(Console.ReadLine(), out valor);


                        Console.Clear();


                        switch (valor)
                        {

                            case 1:
                                tarea1.Mostrar();
                                Console.Clear();
                                break;
                            case 2:
                                tarea1.Mostrar();
                                Console.Clear();
                                break;
                            case 3:
                                MenuT();
                                break;

                            default:
                                Console.WriteLine("Ingrese una opcion-:");
                                break;



                        }//switch cierre

                    } //while primero

                    while (opcionMP == "2")
                    {
                        int valorSwitch;
                        bool opMenu = false;
                        Console.WriteLine("1--Ejercicio  1");
                        Console.WriteLine("2--Ejercicio  2");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("4--Ejercicio 8 while simple ");
                        Console.WriteLine("elija opcion--:");
                        Console.WriteLine("");
                        opMenu = int.TryParse(Console.ReadLine(), out valorSwitch);
                        Console.Clear();

                        Ejercicio8While ej8 = new Ejercicio8While();

                        switch (valorSwitch)
                        {

                            case 1:
                                clas.MostrarEJ();
                                Console.Clear();
                                break;
                            case 2:
                                clas.MostrarEJ();
                                Console.Clear();
                                break;
                            case 3:
                                MenuT();
                                break;
                            case 4:
                                ej8.whilesimple();
                                Console.Clear();
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
