﻿
using ProblemaPiCalculadora2;
using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Console.Write("Entre o valor raio: ");
                double raio = double.Parse(Console.ReadLine(), CI);

                double circ = Calculadora.circunferencia(raio);
                double volume = Calculadora.Volume(raio);

                Console.WriteLine("Circuferencia: " + circ.ToString("F2", CI));
                Console.WriteLine("Volume: " + volume.ToString("F2", CI));
                Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CI));

            }
        }

    }
}
