using System;

namespace Ciclos
{
    internal class ExplicarBucles
    {
        // Método para explicar el bucle for
        public void ExplicarFor()
        {
            Console.WriteLine("Bucle for:");

            // El bucle for consta de tres partes:
            // 1. Inicialización: int i = 0; (inicializa la variable de control)
            // 2. Condición: i < 5; (el bucle se ejecuta mientras esta condición sea verdadera)
            // 3. Incremento: i++ (se incrementa la variable de control después de cada iteración)
            for (int i = 0; i < 5; i++)
            {
                // Imprime el valor actual de la variable de control en cada iteración
                Console.WriteLine($"Iteración {i}");
            }
        }

        // Método para explicar el bucle while
        public void ExplicarWhile()
        {
            Console.WriteLine("Bucle while:");

            // Inicializa la variable de control
            int i = 0;

            // El bucle while se ejecuta mientras la condición (i < 5) sea verdadera
            while (i < 5)
            {
                // Imprime el valor actual de la variable de control en cada iteración
                Console.WriteLine($"Iteración {i}");

                // Incrementa la variable de control
                i++;
            }
        }

        // Método para explicar el bucle do-while
        public void ExplicarDoWhile()
        {
            Console.WriteLine("Bucle do-while:");

            // Inicializa la variable de control
            int i = 0;

            // El bucle do-while se ejecuta al menos una vez, y luego se repite mientras la condición (i < 5) sea verdadera
            do
            {
                // Imprime el valor actual de la variable de control en cada iteración
                Console.WriteLine($"Iteración {i}");

                // Incrementa la variable de control
                i++;
            } while (i < 5); // Verifica la condición al final de cada iteración
        }
    }
}

