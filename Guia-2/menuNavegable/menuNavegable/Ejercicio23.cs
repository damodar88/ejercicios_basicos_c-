using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuNavegable
{
    class Ejercicio23
    {
        public void mostrar(){ 
        
            tipoPersona persona;
            persona.nombre= "Jun Gabriel";
            persona.inicial = 'J';
            persona.edad = 66;
            persona.notas = 7.5f;
            Console.WriteLine(persona.nombre + "murio a los{0}", persona.edad + "años");

            Console.ReadKey();
        }
        struct tipoPersona
        {
            public string nombre;
            public char inicial;
            public int edad;
            public float notas;
        
        }


    }
}
