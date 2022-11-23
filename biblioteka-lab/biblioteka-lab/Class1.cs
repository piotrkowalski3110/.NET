using System;

namespace biblioteka_lab
{
    public class Class1
    {
        public static void DrukRandom()
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(5,100));
        }
    }
}