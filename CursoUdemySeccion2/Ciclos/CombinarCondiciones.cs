using System;

namespace Ciclos
{
    internal class CombinarCondiciones
    {
        // Método para explicar la combinación de condiciones en un bucle while
        public void ExplicarCondicionesWhile()
        {
            Console.WriteLine("Bucle while con condiciones combinadas:");

            int i = 0;
            int j = 0;

            // El bucle while se ejecuta mientras ambas condiciones sean verdaderas
            while (i < 5 && j < 3)
            {
                Console.WriteLine($"Iteración i: {i}, j: {j}");
                i++;
                j++;
            }
        }

        // Método para explicar la combinación de condiciones en un bucle for
        public void ExplicarCondicionesFor()
        {
            Console.WriteLine("Bucle for con condiciones combinadas:");

            // El bucle for se ejecuta mientras al menos una de las condiciones sea verdadera
            for (int i = 0, j = 0; i < 5 || j < 3; i++, j++)
            {
                Console.WriteLine($"Iteración i: {i}, j: {j}");
            }
        }

        // Método para explicar la combinación de condiciones en una estructura if
        public void ExplicarCondicionesIf()
        {
            Console.WriteLine("Condiciones combinadas en una estructura if:");

            int a = 10;
            int b = 20;

            // Uso de condiciones combinadas con &&
            if (a > 5 && b > 15)
            {
                Console.WriteLine("Ambas condiciones son verdaderas.");
            }

            // Uso de condiciones combinadas con ||
            if (a > 15 || b > 15)
            {
                Console.WriteLine("Al menos una de las condiciones es verdadera.");
            }
        }
    }
}

