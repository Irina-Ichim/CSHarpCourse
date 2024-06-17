using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemySeccion2
{
    internal class OperadoresJerarquia
    {
        public void EjecutarEjemplos()
        {
            // Ejemplo básico de jerarquía de operadores
            // Paréntesis, Multiplicación/División/Módulo, Suma/Resta

            // Ejemplo 1: Sin paréntesis
            int resultado1 = 5 + 3 * 2 - 8 / 4 % 3;
            // Evaluación paso a paso:
            // 3 * 2 = 6
            // 8 / 4 = 2
            // 2 % 3 = 2
            // 5 + 6 - 2 = 9
            Console.WriteLine("Resultado 1 (sin paréntesis): " + resultado1); // Debe imprimir 9

            // Ejemplo 2: Con paréntesis
            int resultado2 = (5 + 3) * (2 - 8) / (4 % 3);
            // Evaluación paso a paso:
            // (5 + 3) = 8
            // (2 - 8) = -6
            // (4 % 3) = 1
            // 8 * -6 / 1 = -48
            Console.WriteLine("Resultado 2 (con paréntesis): " + resultado2); // Debe imprimir -48

            // Otros ejemplos para practicar:

            // Ejemplo 3: Combinación de operadores
            int resultado3 = 10 / 2 + 3 * (2 + 1);
            // Evaluación paso a paso:
            // (2 + 1) = 3
            // 10 / 2 = 5
            // 3 * 3 = 9
            // 5 + 9 = 14
            Console.WriteLine("Resultado 3: " + resultado3); // Debe imprimir 14

            // Ejemplo 4: Uso del operador módulo
            int resultado4 = 7 + 6 % 5 * 3;
            // Evaluación paso a paso:
            // 6 % 5 = 1
            // 1 * 3 = 3
            // 7 + 3 = 10
            Console.WriteLine("Resultado 4: " + resultado4); // Debe imprimir 10
        }
    }
}

