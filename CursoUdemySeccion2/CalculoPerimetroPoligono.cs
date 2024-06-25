using System;

namespace CursoUdemySeccion2
{
    internal class CalculoPerimetroPoligono
    {
        public void CalcularPerimetro()
        {
            Console.Write("Dame el número de lados del polígono: ");
            int numeroLados = Convert.ToInt32(Console.ReadLine());

            Console.Write("Dame la longitud de un lado del polígono: ");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            double perimetro = numeroLados * longitudLado;

            Console.WriteLine("El perímetro del polígono es: " + perimetro);
        }
    }
}

