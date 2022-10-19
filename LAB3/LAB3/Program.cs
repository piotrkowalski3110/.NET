using System;

namespace LAB3
{
    public class Variables
    {
    }
    
    internal class Program
    {
        void zad1()
        {
            Random rnd = new Random();
            int[] tab = new int[10];
            for (int i = 0; i < 10; i++)
            {
                tab[i] = rnd.Next(0, 100);
            }

            foreach (var T in tab)
            {
                Console.WriteLine(T);
            }
        }
        
        void zad2()
        {
            int[,] tab = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = rnd.Next(0, 9);
                    Console.Write(tab[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        void zad3()
        {
            int[,] tab = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = (i + 1) * (j + 1);
                    Console.Write(tab[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Program start = new Program();
            //start.zad1();
            //start.zad2();
            //start.zad3();
        }
    }
}