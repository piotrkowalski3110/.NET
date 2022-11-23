using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int[,] Tab = new int[1, 1];
        public static int[,] Tab2 = new int[1, 1];

        public static void ResizeTab(int col, int row, ref int[,] Tab)
        {
            int[,] newArr = new int[row, col];
            Tab = newArr;
        }

        public static void DrukTab(int[,] tabforDruk)
        {
            for (int i = 0; i < tabforDruk.GetLength(0); i++)
            {
                for (int j = 0; j < tabforDruk.GetLength(1); j++)
                {
                    Console.WriteLine("[{0},{1}] = {2}", i, j, tabforDruk[i, j]);
                }
            }
        }

        public static void DrukRnd()
        {
            Random rnd = new Random();
            Console.WriteLine("Randomowa liczba to: " + rnd.Next(5, 100));
        }

        public static void rndTable(int[,] Table)
        {
            Random rndScope = new Random();
            for (int i = 0; i < Table.GetLength(0); i++)
            {
                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    int el = rndScope.Next(5, 10);
                    Class1.Tab[i, j] = el;
                }
            }
        }

        public static void changeTabEl(int[,] Table, int a, int b, int c, int d)
        {
            Table[a, b] = 500;
            Table[c, d] = 500;
        }

        public static bool PrimaryNmb(int liczba)
        {   
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0) return false;
            }

            return true;
        }
        
        public static bool czyPierwsza(int a) {
            for (int i = 2; i <= Math.Sqrt(a); i++) {
                if (a % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public static bool primaryzpam(int lic)
        {
            for (int i = 2; i <= Math.Sqrt(lic); i++)
            {
                if (lic % i == 0) return false;
            }

            return true;
        }

        public static bool primzpam2(int liczba)
        {
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0) return false;
            }

            return true;
        }
    }
}