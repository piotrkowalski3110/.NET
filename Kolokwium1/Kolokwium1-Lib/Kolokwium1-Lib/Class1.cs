using System;

namespace Kolokwium1_Lib
{
    public class Class1
    {
        public static void rndTab(int[,] Tab)
        {
            Random rnd = new Random();

            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    Tab[i, j] = rnd.Next(0, 10);
                }
            }
        }

        public static void DrukTab(int[,] Tab)
        {
            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    Console.Write(Tab[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public static void roznicaMaxAVG(int[,] Tab)
        {
            int max = 0;
            double avg = 0;
            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    if (Tab[i, j] > max) max = Tab[i, j];
                    avg += Tab[i, j];
                }
            }

            double roznica = max - (avg / Tab.Length);
            Console.Write("Max = " + max);
            Console.Write("\tAVG = " + avg/Tab.Length);
            Console.WriteLine("\nRoznica miedzy max a avg = {0}",roznica);
        }
    }
}