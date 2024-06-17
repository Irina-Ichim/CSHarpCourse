using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemySeccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase OperadoresJerarquia
            OperadoresJerarquia operadores = new OperadoresJerarquia();

            // Llamar al método que ejecuta los ejemplos de operadores
            operadores.EjecutarEjemplos();

            // Crear una instancia de la clase PasosHorneado
            PasosHorneado pasosHorneado = new PasosHorneado();

            // Llamar al método que muestra los pasos de horneado
            pasosHorneado.MostrarPasos();

            // Crear una instancia de la clase VariablesEjemplos
            VariablesEjemplos variablesEjemplos = new VariablesEjemplos();

            // Llamar al método que muestra los ejemplos de variables
            variablesEjemplos.MostrarEjemplos();

            // Crear una instancia de la clase ReadLine
            ReadLine readline = new ReadLine();
            readline.PreguntarNombre();

            // Crear una instancia de la clase ConvertirCadenaTipoNumerico
            ConvertirCadenaTipoNumerico convertir = new ConvertirCadenaTipoNumerico();

            // Llamar a los métodos para probar las diferentes conversiones
            convertir.SumarNumeroConConvert();
            convertir.SumarNumeroConParse();
            convertir.SumarNumeroConTryParse();

            // Crear una instancia de la clase ConversionExplicacion
            ConversionExplicacion conversionExplicacion = new ConversionExplicacion();

            // Llamar a los métodos para probar las diferentes conversiones con explicaciones
            conversionExplicacion.SumarNumeroConConvert();
            conversionExplicacion.SumarNumeroConParse();
            conversionExplicacion.SumarNumeroConTryParse();

            // Mantener la consola abierta
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

