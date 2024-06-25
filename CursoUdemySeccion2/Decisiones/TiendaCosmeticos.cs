using System;

namespace CursoUdemySeccion2.Tienda
{
    public class TiendaCosmeticos
    {
        public void Ejecutar()
        {
            Console.WriteLine("Bienvenido a la Tienda de Cosméticos!");
            Console.WriteLine("Selecciona una categoría de productos:");
            Console.WriteLine("1. Cremas");
            Console.WriteLine("2. Maquillaje");
            Console.WriteLine("3. Fragancias");

            int categoria = Convert.ToInt32(Console.ReadLine());

            switch (categoria)
            {
                case 1:
                    Console.WriteLine("Has seleccionado Cremas.");
                    Console.WriteLine("Selecciona un tipo de crema:");
                    Console.WriteLine("a. Crema para el cuerpo");
                    Console.WriteLine("b. Crema para la cara");

                    char tipoCrema = Convert.ToChar(Console.ReadLine());

                    if (tipoCrema == 'a')
                    {
                        Console.WriteLine("Has seleccionado Crema para el cuerpo.");
                    }
                    else if (tipoCrema == 'b')
                    {
                        Console.WriteLine("Has seleccionado Crema para la cara.");
                    }
                    else
                    {
                        Console.WriteLine("Tipo de crema no válido.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Has seleccionado Maquillaje.");
                    Console.WriteLine("Selecciona un tipo de maquillaje:");
                    Console.WriteLine("a. Pintalabios");
                    Console.WriteLine("b. Sombra de ojos");

                    tipoCrema = Convert.ToChar(Console.ReadLine());

                    if (tipoCrema == 'a')
                    {
                        Console.WriteLine("Has seleccionado Pintalabios.");
                    }
                    else if (tipoCrema == 'b')
                    {
                        Console.WriteLine("Has seleccionado Sombra de ojos.");
                    }
                    else
                    {
                        Console.WriteLine("Tipo de maquillaje no válido.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Has seleccionado Fragancias.");
                    Console.WriteLine("Selecciona un tipo de fragancia:");
                    Console.WriteLine("a. Perfume");
                    Console.WriteLine("b. Colonia");

                    tipoCrema = Convert.ToChar(Console.ReadLine());

                    if (tipoCrema == 'a')
                    {
                        Console.WriteLine("Has seleccionado Perfume.");
                    }
                    else if (tipoCrema == 'b')
                    {
                        Console.WriteLine("Has seleccionado Colonia.");
                    }
                    else
                    {
                        Console.WriteLine("Tipo de fragancia no válido.");
                    }
                    break;

                default:
                    Console.WriteLine("Categoría no válida.");
                    break;
            }

            Console.WriteLine("¿Te gustaría comprar algo más? (sí/no)");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() == "si")
            {
                Console.WriteLine("Vamos a seleccionar otro producto.");
                Ejecutar();
            }
            else if (respuesta.ToLower() == "no")
            {
                Console.WriteLine("Gracias por tu visita. ¡Hasta luego!");
            }
            else
            {
                Console.WriteLine("Respuesta no válida.");
            }
        }
    }
}

