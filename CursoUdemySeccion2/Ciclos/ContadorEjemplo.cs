using System;

namespace Ciclos
{
    internal class ContadorEjemplo
    {
        // Método para mostrar el uso de un contador en un bucle for
        public void ContadorFor()
        {
            Console.WriteLine("Contador en un bucle for:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteración {i}");
            }
        }

        // Método para mostrar el uso de un contador en un bucle while
        public void ContadorWhile()
        {
            Console.WriteLine("Contador en un bucle while:");

            int contador = 0;
            while (contador < 5)
            {
                Console.WriteLine($"Iteración {contador}");
                contador++;
            }
        }

        // Método para mostrar el uso de un contador en un contexto diferente
        public void ContadorEnContexto()
        {
            Console.WriteLine("Contador en un contexto diferente:");

            int contador = 0;
            string entrada;

            do
            {
                Console.WriteLine("Ingresa un número (o 'salir' para terminar):");
                entrada = Console.ReadLine();

                if (entrada != "salir")
                {
                    contador++;
                }

            } while (entrada != "salir");

            Console.WriteLine($"Has ingresado {contador} números válidos.");
        }
    }
}

