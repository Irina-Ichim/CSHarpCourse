using System;

namespace CursoUdemySeccion2
{
    internal class CalculoAreaPerimetro
    {
        public void EjecutarCalculo()
        {
            double area, ancho, altura, perimetro;

            Console.Write("Dame la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dame el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            area = altura * ancho;

            perimetro = 2 * (altura + ancho);

            Console.WriteLine("El area es: " + area);
            Console.WriteLine("El perimetro es: " + perimetro);
        }
    }
}

