using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int[,] T = new int[1, 1];
        public static int[,] T2 = new int[1, 1];
        public static void ResizeArray(int newCoNum, int newRoNum, ref int [,] T)
        {
            int[,] newArray = new int[newCoNum,newRoNum];
            T = newArray;
        }
        
        public static void GenTab(int x, int y, ref int [,] T)
        {
            ResizeArray(x,y,ref T);
            Random rnd = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    T[i, j] = rnd.Next(0, 10);
                }
            }
        }
        
        public static void DodajTab(int[,] T, int[,] T2)
        {
            
        }

    }
}