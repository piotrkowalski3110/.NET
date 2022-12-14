using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CandyCrushGame
{
    public class MyButton : Button
    {
        public int Row;
        public int Col;
        public static int Size = 50;
        public static Random index = new Random();

        public static List<Color> Kolory = new List<Color>()
        {
            Color.Blue,
            Color.Aqua,
            Color.Coral,
            Color.Fuchsia,
            Color.Lime,
            Color.Red
        };

        public MyButton()
        {
            this.Height = this.Width = Size;
            int colorIndex = index.Next() % Kolory.Count;
            this.BackColor = Kolory[colorIndex];
        }
    }
}