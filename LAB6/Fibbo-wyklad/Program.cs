using System;

namespace Fibbo_wyklad
{
    internal class Program
    {
        static double Fibbo(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibbo(n - 1) + Fibbo(n - 2);
            }
        }
        public static void Main(string[] args)
        {
            //double[] tabFibbo = new double[30];
            for (int i = 0; i < 60; i++)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                Console.WriteLine("Element {0} ciągu Fibbonacciego to {1}",i+1,Fibbo(i));
                watch.Stop();
                double time = watch.ElapsedMilliseconds;
                Console.WriteLine("Execuction time: {0} seconds\n",time);
            }

            Console.ReadKey();
        }
    }
}