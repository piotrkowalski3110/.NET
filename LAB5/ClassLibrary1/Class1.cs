using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    int[,] T = new int[2,2];
    public class Class1
    {
        public static void ResizeArray<T>(ref T[,] original, int newCoNum, int newRoNum)
        {
            var newArray = new T[newCoNum,newRoNum];
            int columnCount = original.GetLength(1);
            int columnCount2 = newRoNum;
            int columns = original.GetUpperBound(0);
            for (int co = 0; co <= columns; co++)
                Array.Copy(original, co * columnCount, newArray, co * columnCount2, columnCount);
            original = newArray;
        }
        
        public static void GenTab(int x, int y, ref int [,] T)
        {
            ResizeArray(ref T, x, y);
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    T[i, j] = rnd.Next(0, 10);
                }
            }
        }
    }
}