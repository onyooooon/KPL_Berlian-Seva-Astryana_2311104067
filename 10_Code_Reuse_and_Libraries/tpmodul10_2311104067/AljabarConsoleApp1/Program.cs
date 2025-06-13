using System;
using AljabarLibraries;

namespace AljabarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Aljabar aljabar = new Aljabar();

            // Contoh Akar Persamaan Kuadrat
            double[] persamaanKuadrat = { 1, -3, -10 };
            double[] hasilAkar = aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
            Console.WriteLine("Akar-akar dari persamaan kuadrat:");
            foreach (var akar in hasilAkar)
            {
                Console.WriteLine(akar);
            }

            // Contoh Hasil Kuadrat
            double[] persamaanLinear = { 2, -3 };
            double[] hasilKuadrat = aljabar.HasilKuadrat(persamaanLinear);
            Console.WriteLine("\nHasil kuadrat dari persamaan linear:");
            foreach (var nilai in hasilKuadrat)
            {
                Console.WriteLine(nilai);
            }

            Console.ReadLine();
        }
    }
}
