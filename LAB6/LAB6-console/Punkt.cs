namespace LAB6_console
{
    public class Punkt
    {
        private int a;
        private int b;

        public Punkt(int x, int y)
        {
            a = x;
            b = y;
        }

        public int X
        {
            get { return a; }
            set { a = value; }
        }

        public int Y
        {
            get { return b; }
            set { b = value; }
        }
    }
}