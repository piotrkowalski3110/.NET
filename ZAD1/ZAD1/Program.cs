using System;

namespace ZAD1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadKey();

            /* ZAD1
            string imie;
            imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}", imie);
            */

            /* ZAD2
            int wiek;
            string imie;
            imie = Console.ReadLine();
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Witaj " + imie + ", masz " + wiek + " lat!");
            */
            
            /* ZAD3
            int wiek;
            string imie;
            imie = Console.ReadLine();
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Witaj " + imie + ", masz " + wiek + " lat!");
            if(wiek >= 18) Console.WriteLine("dostęp przyznany!");
            else Console.WriteLine("nie ma dostępu!");
            */

            /* ZAD4
            double l1, l2;
            l1 = double.Parse(Console.ReadLine());
            l2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Suma = " + (l1 + l2));
            */

            /* ZAD5
            int menu;
            double x, y;
            x = Double.Parse(Console.ReadLine());
            y = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n1.Dodawanie\n2.Odejmowanie\n3.Mnożenie\n4.Dzielenie");
            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Suma = " + (x+y));
                    break;
                case 2:
                    Console.WriteLine("Różnica = " + (x-y));
                    break;
                case 3:
                    Console.WriteLine("Iloczyn = " + (x*y));
                    break;
                case 4:
                    if(y != 0 ) Console.WriteLine("Iloraz = " + (x/y));
                    else Console.WriteLine("Nie można dzielić przez 0!");
                    break;
                default:
                    Console.WriteLine("Niepoprawna opcja!");
                    break;
            }
            */
            
            /* ZAD6
            int x, y, z;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
            if(Math.Sqrt(z) == 0) Console.WriteLine("Nie można wykonać działania!");
            else
            {
                double wynik = (Math.Log(x)-Math.Sqrt(y))/(Math.Sqrt(z));
                Console.WriteLine("Wynik = " + wynik);
            }
            */

            /* ZAD7
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double pierwdelta = Math.Sqrt((b*b) - (4 * a * c));
            double x1 = ((-b)-pierwdelta)/(2*a);
            double x2 = ((-b)+pierwdelta)/(2*a);
            
            Console.Clear();
            Console.WriteLine("Miejsca zerowe to:\nx1 = " + x1 + "\noraz\nx2 = " + x2);
            */
            
            
        }
    }
}