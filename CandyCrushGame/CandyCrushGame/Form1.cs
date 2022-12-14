using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyCrushGame
{
    public partial class Form1 : Form
    {
        public int IndexBtn1I;
        public int IndexBtn1J;
        public Color Btn1Color;

        public int IndexBtn2I;
        public int IndexBtn2J;
        public Color Btn2Color;


        private MyButton[,] Grid;

        void PopulateGrid()
        {
            Grid = new MyButton[panel1.Width / MyButton.Size, panel1.Height / MyButton.Size];
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i, j] = new MyButton();
                    Grid[i, j].Row = i;
                    Grid[i, j].Col = j;
                    Grid[i, j].Location = new Point(panel1.Location.X + MyButton.Size * i + 1,
                        panel1.Location.Y + MyButton.Size * j + 1);
                    panel1.Controls.Add(Grid[i, j]);
                    Grid[i, j].Click += MyButtonClick;
                }
            }
        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            MyButton btn = sender as MyButton;
            MessageBox.Show(btn.Col.ToString() + " " + btn.Row.ToString());
            Btn1Color = btn.BackColor;
            IndexBtn1I = btn.Row;
            IndexBtn1J = btn.Col;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i, j].Click -= MyButtonClick;
                    Grid[i, j].Click += MyButtonClick2;
                }
            }
        }

        private void MyButtonClick2(object sender, EventArgs e)
        {
            MyButton btn = sender as MyButton;
            MessageBox.Show(btn.Col.ToString() + " " + btn.Row.ToString());
            Btn2Color = btn.BackColor;
            IndexBtn2I = btn.Row;
            IndexBtn2J = btn.Col;

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i, j].Click -= MyButtonClick2;
                    Grid[i, j].Click += MyButtonClick;
                }
            }

            if (Math.Abs(IndexBtn1I - IndexBtn2I) == 1 || Math.Abs(IndexBtn1J - IndexBtn2J) == 1)
            {
                SwapColors();
            }
        }

        void SwapColors()
        {
            Grid[IndexBtn1I, IndexBtn1J].BackColor = Btn2Color;
            Grid[IndexBtn2I, IndexBtn2J].BackColor = Btn1Color;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}