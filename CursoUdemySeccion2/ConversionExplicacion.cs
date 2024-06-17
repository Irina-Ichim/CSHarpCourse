using System;

namespace CursoUdemySeccion2
{
    internal class ConversionExplicacion
    {
        string entrada;
        int numero1 = 5, numero2, resultado;

        // Método para preguntar al usuario el número y realizar la suma con Convert.ToInt32
        public void SumarNumeroConConvert()
        {
            Console.Write("Introduce un número para sumarlo (usando Convert.ToInt32): ");
            entrada = Console.ReadLine();
            try
            {
                // Convertimos la cadena a un número entero
                numero2 = Convert.ToInt32(entrada);
                // Realizamos la suma
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            catch (FormatException)
            {
                // Se lanza si la cadena no es un número válido
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            catch (OverflowException)
            {
                // Se lanza si la cadena representa un número fuera del rango de int
                Console.WriteLine("El número es demasiado grande o pequeño.");
            }
        }

        // Método para preguntar al usuario el número y realizar la suma con int.Parse
        public void SumarNumeroConParse()
        {
            Console.Write("Introduce un número para sumarlo (usando int.Parse): ");
            entrada = Console.ReadLine();
            try
            {
                // Convertimos la cadena a un número entero
                numero2 = int.Parse(entrada);
                // Realizamos la suma
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            catch (FormatException)
            {
                // Se lanza si la cadena no es un número válido
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            catch (OverflowException)
            {
                // Se lanza si la cadena representa un número fuera del rango de int
                Console.WriteLine("El número es demasiado grande o pequeño.");
            }
            catch (ArgumentNullException)
            {
                // Se lanza si la cadena es null
                Console.WriteLine("La entrada no puede ser nula.");
            }
        }

        // Método para preguntar al usuario el número y realizar la suma con int.TryParse
        public void SumarNumeroConTryParse()
        {
            Console.Write("Introduce un número para sumarlo (usando int.TryParse): ");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out numero2))
            {
                // Realizamos la suma
                resultado = numero1 + numero2;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            else
            {
                // No se lanza ninguna excepción, simplemente se maneja el error devolviendo false
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }

        /*
         SumarNumeroConConvert

                Usa Convert.ToInt32 para convertir una cadena a un número entero.
                Puede lanzar las siguientes excepciones:
                FormatException: Si la cadena no es un número válido.
                OverflowException: Si la cadena representa un número fuera del rango de int.
                SumarNumeroConParse

                Usa int.Parse para convertir una cadena a un número entero.
                Puede lanzar las siguientes excepciones:
                FormatException: Si la cadena no es un número válido.
                OverflowException: Si la cadena representa un número fuera del rango de int.
                ArgumentNullException: Si la cadena es null.
                SumarNumeroConTryParse

                Usa int.TryParse para convertir una cadena a un número entero.
                No lanza excepciones. En su lugar, devuelve true si la conversión fue exitosa, y false si no lo fue.
         
         
         */
    }
}

