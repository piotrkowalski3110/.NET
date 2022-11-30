namespace LAB6___Formss
{
    class Funkcja
    {
        public double A { get; set; }
        public double B { get; set; }

        double MiejsceZerowe()
        {
            return -B / A;
        }

        public string Info()
        {
            return string.Format("Funkcja liniowa o współczynnikach: {0} i {1}, Ma miejsce zerowe w punkcie: ({2}, 0)",
                A, B, MiejsceZerowe());
        }

        public Funkcja(double X, double Y)
        {
            A = X;
            B = Y;
        }

        public Funkcja(double X)
        {
            A = X;
        }

        public Funkcja()
        {
        }
    }
}