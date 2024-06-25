using System;

namespace CursoUdemySeccion2.Decisiones
{
    public class OperadoresBoolIgualdad
    {
        public void ExplicarOperadores()
        {
            // Operadores booleanos
            bool verdadero = true;
            bool falso = false;

            // Operadores de igualdad
            int a = 5;
            int b = 10;

            // Operador de igualdad
            bool esIgual = a == b;
            Console.WriteLine($"¿{a} es igual a {b}? {esIgual}");

            // Operador de desigualdad
            bool esDistinto = a != b;
            Console.WriteLine($"¿{a} es distinto a {b}? {esDistinto}");

            // Operadores de comparación
            bool esMayor = a > b;
            bool esMenor = a < b;
            bool esMayorOIgual = a >= b;
            bool esMenorOIgual = a <= b;

            Console.WriteLine($"¿{a} es mayor que {b}? {esMayor}");
            Console.WriteLine($"¿{a} es menor que {b}? {esMenor}");
            Console.WriteLine($"¿{a} es mayor o igual que {b}? {esMayorOIgual}");
            Console.WriteLine($"¿{a} es menor o igual que {b}? {esMenorOIgual}");

            // Operadores booleanos básicos
            bool y = verdadero && falso; // AND
            bool o = verdadero || falso; // OR
            bool no = !verdadero; // NOT

            Console.WriteLine($"verdadero AND falso: {y}");
            Console.WriteLine($"verdadero OR falso: {o}");
            Console.WriteLine($"NOT verdadero: {no}");

            // Ejemplo práctico
            int edad = 20;
            bool esMayorDeEdad = edad >= 18;
            Console.WriteLine($"¿Es mayor de edad (edad >= 18)? {esMayorDeEdad}");
        }
    }
}

