using System;

namespace Lab1_console_app
{
    internal class Program
    {
        public static void Zad1()
        {
            Console.WriteLine("Podaj imie:");
            string imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", imie);
        }

        public static void Zad2()
        {
            Console.WriteLine("Podaj imie:");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
            int wiek = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Witaj {0}, masz {1} lat!", imie, wiek);
        }

        public static void Zad3()
        {
            Console.WriteLine("Podaj imie:");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj wiek:");
            int wiek = Int32.Parse(Console.ReadLine());
            if(wiek < 18) Console.WriteLine("Witaj {0}, masz {1} lat! Dostęp nie został przyznany!", imie, wiek);
            else Console.WriteLine("Witaj {0}, masz {1} lat! Dostęp został przyznany!", imie, wiek);
        }

        public static void Main(string[] args)
        {
            //Zad1();
            //Zad2();
            Zad3();
        }
    }
}