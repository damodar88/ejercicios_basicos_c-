using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMenuSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
              Menu();
        }
            static void Menu(){
            int valor;
                Console.WriteLine("1. Opcion 1");
                Console.WriteLine("2. Opcion 2");
                Console.WriteLine("3. Salir ");
                Console.WriteLine("Seleccione una opcion-:");
                valor= Convert.ToInt32(Console.ReadLine());


            switch(valor)
            {
                case 1:
                    Console.WriteLine("1. Opcion 1");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("2. Opcion 2");
                    Console.ReadLine();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Ingresa una opcion--:");
                    break;

            }  //cierre de switch
            
            
            }//sierre del metodo





        }
    }

