using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ejercicio_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fibonacci Recursivo y no Recursivo";
            double Numero;
            Console.WriteLine("Ingrese un numero");
            Numero = Convert.ToDouble(Console.ReadLine());
            Fibonacci fubonacci = new Fibonacci();
            fubonacci.CalcularFubonacci(Numero);
            Console.WriteLine("Fibonacci con Recursividad");
            fubonacci.CalcularTiempoRecursivo(Numero);
            Console.WriteLine("Fibonacci con For");
            fubonacci.CalcularTiempoFor(Numero);
            Console.ReadKey(true);
        }
        
    }
    public class Fibonacci
    {
        public void Impresion(double Numero)
        {           
            for (double Indice = 0; Indice < Numero + 1; Indice++)
            {
                Console.Write(CalcularFubonacci(Indice) + " ");
            }
            Console.WriteLine();
        }
        public double CalcularFubonacci(double Numero)
        {
            if (Numero < 2)
            {
                return Numero;
            }
            else
            {
                return CalcularFubonacci(Numero - 1) + CalcularFubonacci(Numero - 2);
            }
        }
        public void ForFibonacci(double Numero)
        {
            double Resultado, Guardado = 0, Valor = 1;
            for (double Indice = 0; Indice < Numero + 1; Indice++)
            {
                Resultado = Guardado;
                Guardado = Valor;
                Valor = Resultado + Guardado;
                Console.Write(Resultado + " ");
            }Console.WriteLine();
        }
        public void CalcularTiempoFor(double Numero)
        {
            Stopwatch Tiempo = new Stopwatch();
            Tiempo.Start();
            ForFibonacci(Numero);
            Tiempo.Stop();
            Console.WriteLine("Tiempo que tardo en ejecutarse: {0}", Tiempo.Elapsed.ToString());
        }
        public void CalcularTiempoRecursivo(double Numero)
        {
            Stopwatch Tiempo = new Stopwatch();
            Tiempo.Start();
            Impresion(Numero);
            Tiempo.Stop();
            Console.WriteLine("Tiempo que tardo en ejecutarse: {0}", Tiempo.Elapsed.ToString());
        }
    }
}

