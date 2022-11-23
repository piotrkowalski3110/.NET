using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int length = ClassLibrary1.Class1.Tab.Length;
            // Console.WriteLine("Dlugosc = " + length);
            //
            // ClassLibrary1.Class1.ResizeTab(6,6,ref ClassLibrary1.Class1.Tab);
            // length = ClassLibrary1.Class1.Tab.Length;
            // Console.WriteLine("Dlugosc = " + length);
            //
            // ClassLibrary1.Class1.ResizeTab(3,3,ref ClassLibrary1.Class1.Tab);
            // length = ClassLibrary1.Class1.Tab.Length;
            // Console.WriteLine("Dlugosc = " + length);
            //
            // ClassLibrary1.Class1.rndTable(Class1.Tab);
            // ClassLibrary1.Class1.DrukTab(Class1.Tab);
            // Console.WriteLine("-----------------------------------------");
            // ClassLibrary1.Class1.changeTabEl(Class1.Tab,0,0,2,2);
            // ClassLibrary1.Class1.DrukTab(Class1.Tab);

            Console.WriteLine(Class1.primaryzpam(777));
            int liczba = 3;

            if (liczba <= 1)
            {
                Console.WriteLine("Liczby muszą być większe od 1!");
                return;
            }
            
            for (int i = liczba; i > 1; i-=1)
            {
                if (Class1.PrimaryNmb(i) is true)
                {
                    Console.WriteLine("Najblizsza liczba pierwsza w dol to: " + i);
                    break;
                }
            }

            for (int i = liczba; ; i++)
            {
                if (Class1.PrimaryNmb(i) is true)
                {
                    Console.WriteLine("Najblizsza liczba pierwsza w gore to: " + i);
                    break;
                }
            }
            
            string tekst = "1,2";
            string[] Splitted_chars = tekst.Split(',');
            Console.WriteLine(Splitted_chars[0]);
            Console.WriteLine(Splitted_chars[1]);
        }
    }
}