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
                    {// MENU DE TAREAS
                        Tarea6 t6 = new Tarea6();
                        Tarea7 t7 = new Tarea7();
                        int valor;
                        bool esValido = false;
                        Console.WriteLine("1--Tarea1");
                        Console.WriteLine("2--Tarea2");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("4--Muestra tarea 6");
                        Console.WriteLine("5--Muestra tarea 7");
                        Console.WriteLine("");
                        Console.WriteLine("elija opcion--:");
                        
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
                            case 4:
                                t6.ingreso();
                                Console.Clear();
                                break;
                            case 5:
                                t7.multiplicarxcero();
                                Console.Clear();
                                break;

                            default:
                                Console.WriteLine("Ingrese una opcion-:");
                                break;



                        }//switch cierre

                    } //while primero

                    while (opcionMP == "2")
                    {//MENU DE EJERCICIOS
                        int valorSwitch;
                        bool opMenu = false;
                        Console.WriteLine("1--Ejercicio  1");
                        Console.WriteLine("2--Ejercicio  2");
                        Console.WriteLine("3--Retroseder");
                        Console.WriteLine("4--Ejercicio 8 while simple ");
                        Console.WriteLine("5--Ejercicio 17");
                        Console.WriteLine("6--Ejercicio 18");
                        Console.WriteLine("7--Ejercicio 19");
                        Console.WriteLine("8--Ejercicio 20");
                        Console.WriteLine("9--Ejercicio 21");
                        Console.WriteLine("10-Ejercicio 22");
                        Console.WriteLine("11-Ejercicio 23");
                        Console.WriteLine("12-Ejercicio 24");
                        Console.WriteLine("13-Ejercicio 25");
                        Console.WriteLine("14-Ejercicio 26");
                        Console.WriteLine("15-Ejercicio 27");
                        Console.WriteLine("16-Ejercicio 28");
                        Console.WriteLine("elija opcion--:");
                        opMenu = int.TryParse(Console.ReadLine(), out valorSwitch);
                        Console.Clear();

                        Ejercicio8While ej8 = new Ejercicio8While();
                        ejercicio17 ej17 = new ejercicio17();
                        Ejercicio18 ej18 = new Ejercicio18();
                        Ejercicio19 ej19 = new Ejercicio19();
                        Ejercicio20 ej20 = new Ejercicio20();
                        Ejercicio20guia2 ej21 = new Ejercicio20guia2();
                        Ejercicio22 ej22 = new Ejercicio22();
                        Ejercicio23 ej23 = new Ejercicio23();
                        Ejercicio24 ej24 = new Ejercicio24();
                        Ejercicio25 ej25 = new Ejercicio25();
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
                            case 5:
                                ej17.ejcicioVect();
                                Console.Clear();
                                break;
                            case 6:
                                ej18.ejercico18();
                                Console.Clear();
                                break;
                            case 7:
                                ej19.ejercicio19();
                                Console.Clear();
                                break;
                            case 8:
                                ej20.ejercicio20();        
                                Console.Clear();
                                break;
                            case 9:
                                ej21.ejercicio21();
                                Console.Clear();
                                break;
                            case 10:
                                ej22.ejercicio22();
                                Console.Clear();
                                break;
                            case 11:
                                ej23.mostrar();
                                Console.Clear();
                                break;
                            case 12:
                                ej24.Mostrar();
                                Console.Clear();
                                break;
                            case 13:
                                ej25.Mostrar();
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
