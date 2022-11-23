namespace Kol1_console_app
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] Tablica = new int[5, 5];
            Kolokwium1_Lib.Class1.rndTab(Tablica);
            Kolokwium1_Lib.Class1.DrukTab(Tablica);
            Kolokwium1_Lib.Class1.roznicaMaxAVG(Tablica);
            
            
        }
    }
}