using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace LAB6_console
{
    public class FunkcjaK
    {
        private double A;
        private double B;
        private double C;

        public FunkcjaK()
        {
        }

        public FunkcjaK(double q, double w, double e)
        {
            A = q;
            B = w;
            C = e;
        }

        public double a
        {
            get { return A; }
            set { A = value; }
        }

        public double b
        {
            get { return B; }
            set { B = value; }
        }

        public double c
        {
            get { return C; }
            set { C = value; }
        }

        public string wierzcholek()
        {
            double delta = Math.Pow(B, 2) - (4 * A * C);
            double qW = (-1) * (delta / (4 * A));
            double pW = -B / (A * 2);

            return "Wierzchołek znajduje się w punkcie: [" + pW + " , " + qW + "]";
        }

        public string MiejscaZerowe()
        {
            double delta = Math.Pow(B, 2) - (4 * A * C);
            double delta_sqrt = Math.Sqrt(delta);

            if (delta < 0)
            {
                return "Brak miejsc zerowych!";
            }
            else if (delta == 0)
            {
                double x0 = ((-1) * B) / (2 * a);
                return "1 miejsce zerowe: " + x0;
            }
            else
            {
                double x1 = (((-1) * B) - delta_sqrt) / (2 * A);
                double x2 = (((-1) * B) + delta_sqrt) / (2 * A);
                return "2 miejsca zerowe: x1 = " + x1 + " x2 = " + x2;
            }
        }
    }
}