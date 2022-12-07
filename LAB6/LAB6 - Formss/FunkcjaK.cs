using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace LAB6_console
{
    public class FunkcjaK
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public string[] wierzcholek()
        {
            double delta = Math.Pow(B, 2) - (4 * A * C);
            double qW = (-1) * (delta / (4 * A));
            double pW = -B / (A * 2);
            string[] wierzch = {pW.ToString(), qW.ToString()};
            
            return wierzch;
        }

        public int IloscMiejscZer()
        {
            double delta = Math.Pow(B, 2) - (4 * A * C);
            if (delta < 0)
            {
                return 0;
            }
            else if (delta == 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public string[] MiejscaZerowe()
        {
            double delta = Math.Pow(B, 2) - (4 * A * C);
            double delta_sqrt = Math.Sqrt(delta);

            if (delta < 0)
            {
                return null;
            }
            else if (delta == 0)
            {
                double x0 = ((-1) * B) / (2 * A);
                string[] miejsca = { x0.ToString() };
                return miejsca;
            }
            else
            {
                double x1 = (((-1) * B) - delta_sqrt) / (2 * A);
                double x2 = (((-1) * B) + delta_sqrt) / (2 * A);
                string[] miejca = { x1.ToString(), x2.ToString() };
                return miejca;
            }
        }

        public string Info()
        {
            if (IloscMiejscZer() == 2)
            {
                return string.Format("Funkcja kwadratowa o współczynnikach {0}, {1} i {2} ma 2 miejsca zerowych w punktach XX",A,B,C); 
            }
            else if (IloscMiejscZer() == 1)
            {
                return string.Format("Funkcja kwadratowa o współczynnikach {0}, {1} i {2} ma 1 miejsce zerowe w punkcie XX",A,B,C);
            }
            else
            {
                return string.Format("Funkcja kwadratowa o współczynnikach {0}, {1} i {2} nie ma miejsc zerowych!",A,B,C);   
            }
        }

        public FunkcjaK()
        {
        }

        public FunkcjaK(double q, double w, double e)
        {
            A = q;
            B = w;
            C = e;
        }
    }
}