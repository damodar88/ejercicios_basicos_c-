using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7menuClases
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

         static void Menu(){
         
            Menu         menu0  = new Menu();
            Menu1        menu1  = new Menu1();
            Menu2        menu2  = new Menu2();
            Ejercicio8   ej     = new Ejercicio8();
            Ejercicio9   ej9    = new Ejercicio9();
            Ejercicio10  ej10   = new Ejercicio10();
            Ejercicio11 ej11    = new Ejercicio11();
            Ejercicio12 ej12    = new Ejercicio12();
            Ejercicio13 ej13    = new Ejercicio13();
            Ejercicio14 ej14    = new Ejercicio14();
            Ejercicio15 ej15    = new Ejercicio15();
            Ejercicio16 ej16    = new Ejercicio16();
            
             int valor;
            bool esValido = false;
            Console.WriteLine("1.  Tarea 1");
            Console.WriteLine("2.  Tarea 2");
            Console.WriteLine("3.  Traea 3");
            Console.WriteLine("4.  Ejercicio 8");
            Console.WriteLine("5.  Ejercicio 9");
            Console.WriteLine("6.  Ejercicio 10");
            Console.WriteLine("7.  Ejercicio 11");
            Console.WriteLine("8.  Ejercicio 12");
            Console.WriteLine("9.  Ejercicio 13");
            Console.WriteLine("10. Ejercicio 14");
            Console.WriteLine("11. Ejercicio 15");
            Console.WriteLine("12. Ejercicio 16");
            Console.WriteLine("13. tarea 6");
             Console.WriteLine("Selecione una opcion[1,2,3,4,5,6,7,8,9,10,11]--:");
            esValido = int.TryParse(Console.ReadLine(), out valor);


            while (!esValido) {

                Console.Clear();
                Console.Write("Selecione una opcion 1,2,3,4,5,6,7,8,9,10,11--:");
                esValido = int.TryParse(Console.ReadLine(), out valor);
            
            }

            switch (valor)
            { 
            
                case 1:
                    menu0.Mostrar();
                    Menu();
                    break;

                case 2:
                    menu1.Mostrar1();
                    Menu();
                    break;
                case 3:
                    menu2.Mostrar2();
                    Menu();
                    break;
                
                case 4:
                    ej.siclow();
                    Menu();
                    break;
                case 5:
                    ej9.calculaNumero();
                    Menu();
                    break;
                case 6:
                    ej10.promediar();
                    Menu();
                    break;
                case 7:
                    ej11.indicandor();
                    Menu();
                    break;
                case 8:
                    ej12.encuontrador();
                    Menu();
                    break;
                case 9:
                    ej13.contadorNumeros();
                    Menu();
                    break;
                case 10:
                    ej14.tablaMult();
                    Menu();
                    break;
                case 11:
                    ej15.corteNumerico();
                    Menu();
                    break;
                case 12:
                    ej16.corteNumero();
                    Menu();
                    break;

                default:
                    Console.WriteLine("Ingrese una opcion--:");
                    break;



            }




        }
    }
}
