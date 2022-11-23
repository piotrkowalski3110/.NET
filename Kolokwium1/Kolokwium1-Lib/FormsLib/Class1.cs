using System;
using System.Collections;
using System.Data;
using System.Linq;

namespace FormsLib
{
    public class Class1
    {
        public static int[,] Tab = new int[1, 1];

        public static void Resize(int row, int col, ref int[,] Tab)
        {
            int[,] newArr = new int[row, col];
            Tab = newArr;
        }

        public static void GenRNDtab(int min, int max, ref int[,] Tab)
        {
            Random rnd = new Random();
            for (int i = 0; i < Tab.GetLength(0); i++)
            {
                for (int j = 0; j < Tab.GetLength(1); j++)
                {
                    int value = rnd.Next(min, max);
                    if (isUnique(value) is true)
                    {
                        if (Primary(value) is true)
                        {
                            Tab[i, j] = value;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    else
                    {
                        j--;
                    }
                }
            }
        }

        public static bool isUnique(int liczba)
        {
            int[] Liczby = new int[0];
            foreach (int a in Tab)
            {
                Liczby = Liczby.Append(a).ToArray();
            }

            for (int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i] == liczba)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Primary(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }

            return true;
        }
    }
}