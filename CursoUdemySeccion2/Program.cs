﻿using Ciclos;
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
            // Decisiones.OperadoresBoolIgualdad operadoresBoolIgualdad = new Decisiones.OperadoresBoolIgualdad();
            // operadoresBoolIgualdad.ExplicarOperadores();

            // Crear una instancia de la clase Condicionales
            //Decisiones.Condicionales condicionales = new Decisiones.Condicionales();
            //condicionales.ExplicarCondicionales();

            // Crear una instancia de la clase TiendaCosmeticos
            // Tienda.TiendaCosmeticos tienda = new Tienda.TiendaCosmeticos();
            // tienda.Ejecutar();

            // Crear una instancia de la clase IncrementoDecremento
            // Ciclos.IncrementoDecremento incrementoDecremento = new Ciclos.IncrementoDecremento();
            //incrementoDecremento.ExplicarOperadores();

            // Crear una instancia de la clase ExplicarBucles
            //Ciclos.ExplicarBucles explicarBucles = new Ciclos.ExplicarBucles();

            // Llamar a los métodos para explicar los bucles
            //explicarBucles.ExplicarFor();
            //explicarBucles.ExplicarWhile();
            //explicarBucles.ExplicarDoWhile();

            // Crear una instancia de la clase CombinarCondiciones
            // Ciclos.CombinarCondiciones combinarCondiciones = new Ciclos.CombinarCondiciones();

            // Llamar a los métodos para explicar la combinación de condiciones
            // combinarCondiciones.ExplicarCondicionesWhile();
            //combinarCondiciones.ExplicarCondicionesFor();
            //combinarCondiciones.ExplicarCondicionesIf();

            // Crear una instancia de la clase ContadorEjemplo
            // Ciclos.ContadorEjemplo contadorEjemplo = new Ciclos.ContadorEjemplo();

            // Llamar a los métodos para mostrar el uso de contadores
            // contadorEjemplo.ContadorFor();
            // contadorEjemplo.ContadorWhile();
            // contadorEjemplo.ContadorEnContexto();


            // Crear una instancia de la clase AcumuladorEjemplo
            //Ciclos.AcumuladorEjemplo acumuladorEjemplo = new Ciclos.AcumuladorEjemplo();

            // Llamar a los métodos para mostrar el uso de acumuladores
            //acumuladorEjemplo.AcumuladorFor();
            //acumuladorEjemplo.AcumuladorWhile();
            //acumuladorEjemplo.AcumuladorEnContexto();

            // Crear una instancia de la clase IteracionAnidada
            //Ciclos.IteracionAnidada iteracionAnidada = new Ciclos.IteracionAnidada();

            // Llamar a los métodos para mostrar el uso de bucles anidados
            //iteracionAnidada.ForAnidado();
            //iteracionAnidada.WhileAnidado();
            //iteracionAnidada.ForeachAnidado();
            //iteracionAnidada.ForeachAnidadoConListas();

            // Crear una instancia de la clase FactorialEjemplo
            //Ciclos.FactorialEjemplo factorialEjemplo = new Ciclos.FactorialEjemplo();

            // Calcular y mostrar el factorial de un número utilizando el método iterativo
            // int numero = 5;
            // int resultadoIterativo = factorialEjemplo.FactorialIterativo(numero);
            //Console.WriteLine($"Factorial iterativo de {numero} es {resultadoIterativo}");

            // Calcular y mostrar el factorial de un número utilizando el método recursivo
            //int resultadoRecursivo = factorialEjemplo.FactorialRecursivo(numero);
            //Console.WriteLine($"Factorial recursivo de {numero} es {resultadoRecursivo}");

            // Crear una instancia de la clase CalcularPotencia
            Matematicas.CalcularPotencia calcularPotencia = new Matematicas.CalcularPotencia();

            // Calcular y mostrar la potencia de un número
            double baseNumero = 2.0;
            int exponente = -3;
            double resultadoPotencia = calcularPotencia.Potencia(baseNumero, exponente);
            Console.WriteLine($"La potencia de {baseNumero} elevado a {exponente} es {resultadoPotencia}");

            // Crear una instancia de la clase NumerosPrimos
            Matematicas.NumerosPrimos numerosPrimos = new Matematicas.NumerosPrimos();

            // Mostrar los números primos entre 1 y 100
            numerosPrimos.MostrarNumerosPrimos();
            // Mantener la consola abierta
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

