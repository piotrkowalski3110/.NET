using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrukTab(TextBox textBox, int x, int y, int[,] T)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    textBox.AppendText(T[i, j].ToString() + ' ');
                }

                textBox.AppendText(Environment.NewLine);
            }
        }

        private void Dodaj(int[,] T, int[,] T2)
        {
            if (T.Length(0) != T2.Length(0) || T.Length(1) != T2.Length(1))
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tab1TextBox.Clear();
            string[] valuesForTable = tab1input.Text.Split(',');
            int x = Int32.Parse(valuesForTable[0]);
            int y = Int32.Parse(valuesForTable[1]);
            Class1.GenTab(x, y, ref Class1.T);
            DrukTab(tab1TextBox, x, y, Class1.T);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tab2TextBox.Clear();
            string[] valuesForTable = tab2input.Text.Split(',');
            int x = Int32.Parse(valuesForTable[0]);
            int y = Int32.Parse(valuesForTable[1]);
            Class1.GenTab(x, y, ref Class1.T2);
            DrukTab(Tab2TextBox, x, y, Class1.T2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab1TextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tab2TextBox.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultsTextBox.Clear();
            int counter = 0;
            int x = Class1.T.GetLength(0);
            int y = Class1.T.GetLength(1);
            int[] localTable = new int[Class1.T.Length];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    localTable[counter] = Class1.T[i, j];
                    counter++;
                }
            }

            counter = 0;

            Array.Sort(localTable);
            int[,] resultTab = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    resultTab[i, j] = localTable[counter];
                    counter++;
                }
            }

            DrukTab(resultsTextBox, x, y, resultTab);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}