using System;

namespace CursoUdemySeccion2
{
    public class VariablesEjemplos
    {
        public void MostrarEjemplos()
        {
            // Variables en una sola línea
            int numeroLibros, numeroRevistas, numeroPeriodicos, numeroComics, numeroLibrosDigitales, paginasLibro;

            // Variables en varias líneas
            double precioLibro;
            char letra;

            // Asignamos valores a las variables
            numeroLibros = 10;
            paginasLibro = 120;
            precioLibro = 10.5;
            letra = 'A';

            Console.WriteLine("El número de libros es: {0} y tiene {1} páginas", numeroLibros, paginasLibro);

            // string es un tipo de dato que almacena texto
            string saludo = "Hola Irina";

            // bool es un tipo de dato que almacena verdadero o falso
            bool esVerdadero = true;

            // decimal es un tipo de dato que almacena números decimales, 'm' es para indicar que es un decimal
            decimal precio = 10.5m;

            // float es un tipo de dato que almacena números decimales, 'f' es para indicar que es un float
            float precio2 = 10.5f;

            // Operador división
            int resultado = 10 / 3;
            Console.WriteLine("El resultado de la división es: {0}", resultado);

            // Operador división con decimales
            double resultado2 = 10.0 / 3.0;
            Console.WriteLine("El resultado de la división es: {0}", resultado2);

            // Operador módulo, resto o residuo
            int resultado3 = 10 % 3;
            Console.WriteLine("El módulo de la división es: {0}", resultado3);

            // Jerarquía de operadores   
            int resultado4 = 10 + 5 * 3;
            Console.WriteLine("El resultado de la operación es: {0}", resultado4);

            // Jerarquía de operadores
            double resultado5 = 3.0 / (3 + 5) * 2;
            Console.WriteLine("El resultado de la operación es: {0}", resultado5);
        }
    }
}
