using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemySeccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase OperadoresJerarquia
            //OperadoresJerarquia operadores = new OperadoresJerarquia();

            // Llamar al método que ejecuta los ejemplos de operadores
            // operadores.EjecutarEjemplos();

            // Crear una instancia de la clase PasosHorneado
            //PasosHorneado pasosHorneado = new PasosHorneado();

            // Llamar al método que muestra los pasos de horneado
            //pasosHorneado.MostrarPasos();

            // Crear una instancia de la clase VariablesEjemplos
            //VariablesEjemplos variablesEjemplos = new VariablesEjemplos();

            // Llamar al método que muestra los ejemplos de variables
            //variablesEjemplos.MostrarEjemplos();

            // Crear una instancia de la clase ReadLine
            //ReadLine readline = new ReadLine();
            //readline.PreguntarNombre();

            // Crear una instancia de la clase ConvertirCadenaTipoNumerico
            // ConvertirCadenaTipoNumerico convertir = new ConvertirCadenaTipoNumerico();

            // Llamar a los métodos para probar las diferentes conversiones
            //convertir.SumarNumeroConConvert();
            //convertir.SumarNumeroConParse();
            //convertir.SumarNumeroConTryParse();

            // Crear una instancia de la clase ConversionExplicacion
            //ConversionExplicacion conversionExplicacion = new ConversionExplicacion();

            // Llamar a los métodos para probar las diferentes conversiones con explicaciones
            //conversionExplicacion.SumarNumeroConConvert();
            //conversionExplicacion.SumarNumeroConParse();
            //conversionExplicacion.SumarNumeroConTryParse();

            // Crear una instancia de la clase ConversionesSinString
            //ConversionesSinString conversiones = new ConversionesSinString();

            // Llamar a los métodos para probar las diferentes conversiones
            //conversiones.SumarNumeroConConvert();
            //conversiones.SumarNumeroConParse();
            //conversiones.SumarNumeroConTryParse();

            // Crear una instancia de la clase CalculoAreaPerimetro
            //CalculoAreaPerimetro calculo = new CalculoAreaPerimetro();
            // calculo.EjecutarCalculo();

            // Crear una instancia de la clase CalculoPerimetroPoligono
            //CalculoPerimetroPoligono calculoPoligono = new CalculoPerimetroPoligono();
            //calculoPoligono.CalcularPerimetro();

            // Crear una instancia de la clase TransformacionGrados
            // TransformacionGrados transformacionGrados = new TransformacionGrados();
            //transformacionGrados.ConvertirCentigradosAFahrenheit();

            // Crear una instancia de la clase OperadoresBoolIgualdad
            Decisiones.OperadoresBoolIgualdad operadoresBoolIgualdad = new Decisiones.OperadoresBoolIgualdad();
            operadoresBoolIgualdad.ExplicarOperadores();

            // Crear una instancia de la clase Condicionales
            Decisiones.Condicionales condicionales = new Decisiones.Condicionales();
            condicionales.ExplicarCondicionales();

            // Mantener la consola abierta
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

