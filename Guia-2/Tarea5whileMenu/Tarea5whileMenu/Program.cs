using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5whileMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() {
            Repetir repetiN = new Repetir();


            int valor;
            bool esValido = false;
            Console.WriteLine("1. repetir numeros");
            Console.WriteLine("2. salir");
            Console.WriteLine("Selecione una opcion (1,2)--:");
            esValido = int.TryParse(Console.ReadLine(), out valor);
 
            while(!esValido){
                Console.Clear();
                Console.Write("\n Seleccione una opcion [1,2]---:");
                esValido = int.TryParse(Console.ReadLine(), out valor);
            }
        
        switch(valor)
        {
            case 1:
                repetiN.reptiendoNumeros();
                Menu();
                break;
            default:
                Console.WriteLine("Ingrese una opcion--:");
                break;

        }
        
        
        
        }



        
    }
}
