using System;

namespace LAB6_console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FunkcjaK F1 = new FunkcjaK(5,16,4);
            Console.WriteLine(F1.wierzcholek());
            Console.WriteLine(F1.MiejscaZerowe());
        }
    }
}