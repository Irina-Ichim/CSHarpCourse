using System;

namespace Ciclos
{
    internal class FactorialEjemplo
    {
        // Método para calcular el factorial de un número de forma iterativa
        public int FactorialIterativo(int n)
        {
            int resultado = 1;

            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        // Método para calcular el factorial de un número de forma recursiva
        public int FactorialRecursivo(int n)
        {
            if (n == 0)
            {
                return 1; // Caso base: 0! = 1
            }
            else
            {
                return n * FactorialRecursivo(n - 1); // Llamada recursiva
            }
        }
    }
}

