using System;
using System.Data;
using System.Linq;

namespace LAB4
{
    internal class Program
    {
        // zad 1
        static void Kolo(double promien, ref double pole, ref double obwod)
        {
            pole = Math.PI * Math.Pow(promien,2);
            obwod = 2 * Math.PI * promien;
        }
        
        static double poleKola(double promien)
        {
            return Math.PI * Math.Pow(promien,2);
        }
        
        static double obwodKola(double promien)
        {
            return 2 * Math.PI * promien;
        }
        
        // zad 2
        static int silniaIter(int liczba)
        {
            int result = 1;
            for (int i = 1; i <= liczba; i++)
            {
                result *= i;
            }
            return result;
        }
        
        static int silniaRek(int liczba)
        {
            if (liczba < 1) return 1;
            else return liczba * silniaRek(liczba - 1);
        }

        // zad 3
        // static int NWD(int a, int b) { }
        
        // zad 6
        static void fibbo(out int[] table)
        {
            table = new int [30];
            for (int i = 0; i < 30; i++)
            {
                if (i == 0 || i == 1) table[i] = 1;
                else table[i] = table[i - 1] + table[i - 2];
            }
        }
        
        // zad 7
        static void wypiszTab2D(out int[,] tab)
        {
            Random rnd = new Random();
            tab = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = rnd.Next(0, 100);;
                }
                
            }

            foreach (var A in tab)
            {
                Console.WriteLine(A);
            }
        }
        
        // zad 8
        static void max(int[,] tab)
        {
            int max = 0;
            foreach (var A in tab)
            {
                if (A > max) max = A;
            }
            Console.WriteLine("Max = " + max);
        }

        static void min(int[,] tab)
        {
            int min = 100;
            foreach (var A in tab)
            {
                if (A < min) min = A;
            }
            Console.WriteLine("Min = " + min);
        }

        static void suma_el(int[,] tab)
        {
            int suma = 0;

            foreach (var A in tab)
            {
                suma += A;
            }
            
            Console.WriteLine("Suma = " + suma);
        }

        static void transpoz(int[,] tab)
        {
            Console.WriteLine("\nNormalna tablica:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tab[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\nTranspozycja:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(tab[j,i] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public static void Main(string[] args)
        {
            // double pole = 0, obwod = 0;
            // Kolo(3,ref pole,ref obwod);
            // Console.WriteLine("Pole = " + pole + " Obwod = " + obwod);

            // double poleKol = poleKola(3);
            // double obwKol = obwodKola(3);
            // Console.WriteLine("Pole = " + poleKol + " Obwod = " + obwKol);

            // int wynSilIter = silniaIter(8);
            // Console.WriteLine(wynSilIter);

            // int wynSilRek = silniaRek(8);
            // Console.WriteLine(wynSilRek);

            // int[] tab = new int [30];
            // fibbo(out tab);
            // foreach (var A in tab)
            // {
            //     Console.WriteLine(A);
            // }

            // int[,] table2 = new int[10, 10];
            // wypiszTab2D(out table2);

            int[,] tableWyniki = new int[10, 10];
            Random randd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tableWyniki[i, j] = randd.Next(0, 100);
                }
            }
            
            max(tableWyniki);
            min(tableWyniki);
            suma_el(tableWyniki);
            transpoz(tableWyniki);
        }
    }
}