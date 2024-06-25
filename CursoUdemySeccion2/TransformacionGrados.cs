using System;

namespace CursoUdemySeccion2
{
    internal class TransformacionGrados
    {
        public void ConvertirCentigradosAFahrenheit()
        {
            Console.Write("Dame la temperatura en grados Centígrados: ");
            double gradosCentigrados = Convert.ToDouble(Console.ReadLine());

            double gradosFahrenheit = (gradosCentigrados * 9 / 5) + 32;

            Console.WriteLine("La temperatura en grados Fahrenheit es: " + gradosFahrenheit);
        }
    }
}

