using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulatorgrosir
{
    class Program
    {
        static double calculateRetail(double grosir, double kenaikannya)
        {
            double cal;
            return cal = (grosir * kenaikannya / 100) + grosir;
        }
        static void Main(string[] args)
        {
            double wholesale, markup;

            Console.Write("Masukkan harga grosir: $");
            wholesale = double.Parse(Console.ReadLine());

            Console.Write("Masukkan beberapa % kenaikannya:");
            markup = double.Parse(Console.ReadLine());

            Console.Write("Harga ecerannya adalah : $");
            Console.WriteLine(calculateRetail(wholesale, markup));

            Console.ReadLine();

        }
    }
}
