using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemySeccion2
{
    internal class ReadLine
    {
        string nombre;

        //Preguntamos el nombre del usuario

        public void PreguntarNombre()
        {
            Console.Write("¿Cuál es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola, " + nombre + ". ¡Bienvenida al curso de C#!");
        }
    }
}
