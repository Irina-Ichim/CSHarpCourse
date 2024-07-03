using System;

namespace Matematicas
{
    internal class NumerosPrimos
    {
        public void MostrarNumerosPrimos()
        {
            Console.WriteLine("Números primos entre 1 y 100:");

            for (int num = 2; num <= 100; num++)
            {
                if (EsPrimo(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }
    }
}

