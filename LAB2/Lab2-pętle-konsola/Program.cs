using System;
using System.Collections.Generic;
using System.Data;

namespace Lab2_pętle_konsola
{
    internal class Program
    {
        public void jeden()
        {
            double l1;
            while (true)
            {
                l1 = Int32.Parse(Console.ReadLine());
                if (l1 < 0)
                {
                    Console.Write("Zakaz liczb ujemnych!");
                    break;
                }
                else Console.Write("Pierwiastek z liczby = " + Math.Sqrt(l1) + "\n");
            }
        }

        public void dwa()
        {
            int start = 1, suma = 0;
            while (start <= 1000)
            {
                if (start % 2 != 0) suma += start;
                ++start;
            }

            Console.Write("Suma liczb nieparzystych od 1 do 1000 to " + suma);
        }

        public void trzy()
        {
            int n, start = 1;
            Console.Write("Podaj zarkes liczb: ");
            n = int.Parse(Console.ReadLine());

            while (start <= n)
            {
                if (start % 10 == 2)
                {
                    Console.Write(start);
                }
            }
        }

        public void palindrom()
        {
            int liczba = 101, cyfra;
            List<int> palindromy = new List<int>();

            while (true)
            {
                if (liczba < 10)
                {
                    palindromy.Add(liczba);
                    break;
                }
                else
                {
                    cyfra = liczba % 10;
                    liczba = (liczba - cyfra)/10;
                    palindromy.Add(cyfra);   
                }
            }

            if (palindromy[0] == palindromy[palindromy.Count - 1])
            {
                Console.WriteLine("Palindrom!");
            }
        }
        

        public static void Main(string[] args)
        {
            Program p1 = new Program();
            //p1.jeden();
            //p1.dwa();
           p1.palindrom();
        }
    }
}