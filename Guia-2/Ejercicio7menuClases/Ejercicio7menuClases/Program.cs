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
         
            Menu menu0 = new Menu();
            Menu1 menu1 = new Menu1();
            Menu2 menu2 = new Menu2();


            int valor;
            bool esValido = false;
            Console.WriteLine("1. Tarea 1");
            Console.WriteLine("2. Tarea 2");
            Console.WriteLine("3. Traea 3");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Selecione una opcion[1,2,3,4]--:");
            esValido = int.TryParse(Console.ReadLine(), out valor);


            while (!esValido) {

                Console.Clear();
                Console.Write("Selecione una opcion 1,2,3,4--:");
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
                default:
                    Console.WriteLine("Ingrese una opcion--:");
                    break;



            }




        }
    }
}
