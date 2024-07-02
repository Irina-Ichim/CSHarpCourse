using System;
using System.Collections.Generic;

namespace Ciclos
{
    internal class IteracionAnidada
    {
        // Método para mostrar el uso de bucles for anidados
        public void ForAnidado()
        {
            Console.WriteLine("Bucle for anidado:");

            // Bucle externo
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Iteración externa {i}");

                // Bucle interno
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"  Iteración interna {j}");
                }
            }
        }

        // Método para mostrar el uso de bucles while anidados
        public void WhileAnidado()
        {
            Console.WriteLine("Bucle while anidado:");

            int i = 0;

            // Bucle externo
            while (i < 3)
            {
                Console.WriteLine($"Iteración externa {i}");

                int j = 0;

                // Bucle interno
                while (j < 3)
                {
                    Console.WriteLine($"  Iteración interna {j}");
                    j++;
                }

                i++;
            }
        }

        // Método para mostrar el uso de bucles foreach anidados con una matriz
        public void ForeachAnidado()
        {
            Console.WriteLine("Bucle foreach anidado:");

            int[,] matriz = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Bucle externo
            foreach (int i in matriz)
            {
                Console.WriteLine($"Elemento: {i}");
            }
        }

        // Método para mostrar el uso de bucles foreach anidados con una lista de listas
        public void ForeachAnidadoConListas()
        {
            Console.WriteLine("Bucle foreach anidado con listas:");

            var listas = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3 },
                new List<int>() { 4, 5, 6 },
                new List<int>() { 7, 8, 9 }
            };

            // Bucle externo
            foreach (var lista in listas)
            {
                // Bucle interno
                foreach (var elemento in lista)
                {
                    Console.WriteLine($"Elemento: {elemento}");
                }
            }
        }
    }
}

