using System;

namespace CursoUdemySeccion2.Decisiones
{
    public class Condicionales
    {
        public void ExplicarCondicionales()
        {
            // Ejemplo de if
            int a = 5;
            if (a > 3)
            {
                Console.WriteLine("a es mayor que 3");
            }

            // Ejemplo de if-else
            if (a > 10)
            {
                Console.WriteLine("a es mayor que 10");
            }
            else
            {
                Console.WriteLine("a no es mayor que 10");
            }

            // Ejemplo de else if
            if (a > 10)
            {
                Console.WriteLine("a es mayor que 10");
            }
            else if (a > 5)
            {
                Console.WriteLine("a es mayor que 5 pero menor o igual a 10");
            }
            else
            {
                Console.WriteLine("a es menor o igual a 5");
            }

            // Ejemplo de switch
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Día no válido");
                    break;
            }
        }
    }
}

