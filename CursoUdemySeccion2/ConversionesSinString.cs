using System;

namespace CursoUdemySeccion2
{
    internal class ConversionesSinString
    {
        // Método que usa Convert.ToInt32 para convertir la cadena a entero
        public void SumarNumeroConConvert()
        {
            Console.Write("Introduce un número para sumarlo (usando Convert.ToInt32): ");
            // Leer la entrada del usuario y convertirla directamente
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                int resultado = 5 + numero;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es demasiado grande o pequeño.");
            }
        }

        // Método que usa int.Parse para convertir la cadena a entero
        public void SumarNumeroConParse()
        {
            Console.Write("Introduce un número para sumarlo (usando int.Parse): ");
            // Leer la entrada del usuario y convertirla directamente
            try
            {
                int numero = int.Parse(Console.ReadLine());
                int resultado = 5 + numero;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número es demasiado grande o pequeño.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("La entrada no puede ser nula.");
            }
        }

        // Método que usa int.TryParse para convertir la cadena a entero
        public void SumarNumeroConTryParse()
        {
            Console.Write("Introduce un número para sumarlo (usando int.TryParse): ");
            // Leer la entrada del usuario y tratar de convertirla directamente
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                int resultado = 5 + numero;
                Console.WriteLine("El resultado de la suma es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }
        }
    }
}

