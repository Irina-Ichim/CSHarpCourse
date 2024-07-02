using System;

namespace Ciclos
{
    internal class AcumuladorEjemplo
    {
        // Método para mostrar el uso de un acumulador en un bucle for
        public void AcumuladorFor()
        {
            Console.WriteLine("Acumulador en un bucle for:");

            int acumulador = 0;

            for (int i = 1; i <= 5; i++)
            {
                acumulador += i;
                Console.WriteLine($"Después de agregar {i}, el acumulador es {acumulador}");
            }
        }

        // Método para mostrar el uso de un acumulador en un bucle while
        public void AcumuladorWhile()
        {
            Console.WriteLine("Acumulador en un bucle while:");

            int acumulador = 0;
            int i = 1;

            while (i <= 5)
            {
                acumulador += i;
                Console.WriteLine($"Después de agregar {i}, el acumulador es {acumulador}");
                i++;
            }
        }

        // Método para mostrar el uso de un acumulador en un contexto diferente
        public void AcumuladorEnContexto()
        {
            Console.WriteLine("Acumulador en un contexto diferente:");

            int acumulador = 0;
            string entrada;

            do
            {
                Console.WriteLine("Ingresa un número (o 'salir' para terminar):");
                entrada = Console.ReadLine();

                if (entrada != "salir")
                {
                    int numero;
                    if (int.TryParse(entrada, out numero))
                    {
                        acumulador += numero;
                        Console.WriteLine($"El acumulador es ahora: {acumulador}");
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingresa un número válido.");
                    }
                }

            } while (entrada != "salir");

            Console.WriteLine($"El valor total acumulado es: {acumulador}");
        }
    }
}

