using System;

namespace CursoUdemySeccion2
{
    internal class ConvertirCadenaTipoNumerico
    {
        string entrada;
        int numero1 = 5, numero2, resultado;

        // Método para preguntar al usuario el número y realizar la suma con Convert.ToInt32
        public void SumarNumeroConConvert()
        {
            Console.Write("Introduce un número para sumarlo (usando Convert.ToInt32): ");
            entrada = Console.ReadLine();
            numero2 = Convert.ToInt32(entrada);
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma es: {0}", resultado);
        }

        // Método para preguntar al usuario el número y realizar la suma con int.Parse
        public void SumarNumeroConParse()
        {
            Console.Write("Introduce un número para sumarlo (usando int.Parse): ");
            entrada = Console.ReadLine();
            numero2 = int.Parse(entrada);
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma es: {0}", resultado);
        }

        // Método para preguntar al usuario el número y realizar la suma con int.TryParse
        public void SumarNumeroConTryParse()
        {
            Console.Write("Introduce un número para sumarlo (usando int.TryParse): ");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero2))
            {
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}


