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

        public static void Zad4()
        {
            Console.WriteLine("Podaj L1:");
            double l1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj L2:");
            double l2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Suma = " + (l1+l2));
        }

        public static void Zad5()
        {
            Console.WriteLine("Podaj operacje matematyczna: \n1. \'+\'\n2. \'-\'\n3. \'*\'\n4. \'/\'\n");
            char math_op = Char.Parse(Console.ReadLine());
            double l1, l2;
            switch (math_op)
            {
                case '+':
                    Console.WriteLine("Podaj L1:");
                    l1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj L2:");
                    l2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Suma = " + (l1+l2));
                    break;
                case '-':
                    Console.WriteLine("Podaj L1:");
                    l1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj L2:");
                    l2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Różnica = " + (l1-l2));
                    break;
                case '*':
                    Console.WriteLine("Podaj L1:");
                    l1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj L2:");
                    l2 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Iloczyn = " + (l1*l2));
                    break;
                case '/':
                    Console.WriteLine("Podaj L1:");
                    l1 = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Podaj L2:");
                    l2 = Double.Parse(Console.ReadLine());
                    if (l2 == 0)
                    {
                        Console.WriteLine("Nie dziel przez 0!");
                        return;
                    }
                    Console.WriteLine("Iloraz = " + (l1/l2));
                    break;
                default:
                    Console.WriteLine("Zła operacja matematyczna!");
                    break;
            }
        }

        public static void Zad6()
        {
            Console.WriteLine("Podaj liczby x,y,z po przecinku w 1 linii:");
            string inputs = Console.ReadLine();
            string[] separatedInputs = inputs.Split(',');
            double x = Double.Parse(separatedInputs[0]);
            double y = Double.Parse(separatedInputs[1]);
            double z = Double.Parse(separatedInputs[2]);
            
            if(Math.Sqrt(z) == 0) Console.WriteLine("Nieprawidłowe parametry!");
            else
            {
                Console.WriteLine("Wynik działania matematycznego to = " + ((Math.Log(x) - Math.Sqrt(y)) / Math.Sqrt(z)));
            }
        }

        public static void Zad7()
        {
            Console.WriteLine("Podaj liczby a,b,c (równanie kwadratowe) po przecinku w jednej linii: ");
            string inputs = Console.ReadLine();
            string[] separatedInputs = inputs.Split(',');
            double a = Double.Parse(separatedInputs[0]);
            double b = Double.Parse(separatedInputs[1]);
            double c = Double.Parse(separatedInputs[2]);
            double sqrt_delta = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));

            double x1 = ((-b) - sqrt_delta)/(2*a);
            double x2 = ((-b) + sqrt_delta)/(2*a);
            
            Console.WriteLine("Miejsca zerowe to: x1 = {0} oraz x2 = {1}",x1,x2);
        }

        public static void Main(string[] args)
        {
            //Zad1();
            //Zad2();
            //Zad3();
            //Zad4();
            //Zad5();
            //Zad6();
            Zad7();
        }
    }
}