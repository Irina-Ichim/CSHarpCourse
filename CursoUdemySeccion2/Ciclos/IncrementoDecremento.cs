using System;

namespace Ciclos
{
    internal class IncrementoDecremento
    {
        public void ExplicarOperadores()
        {
            int numero = 10;

            // Incremento en 1
            numero++;
            Console.WriteLine("Después de incrementar en 1: " + numero); // 11

            // Decremento en 1
            numero--;
            Console.WriteLine("Después de decrementar en 1: " + numero); // 10

            // Incremento en 5
            numero += 5;
            Console.WriteLine("Después de incrementar en 5: " + numero); // 15

            // Decremento en 5
            numero -= 5;
            Console.WriteLine("Después de decrementar en 5: " + numero); // 10

            // Multiplicación por 2
            numero *= 2;
            Console.WriteLine("Después de multiplicar por 2: " + numero); // 20

            // División por 2
            numero /= 2;
            Console.WriteLine("Después de dividir por 2: " + numero); // 10
        }
    }
}

