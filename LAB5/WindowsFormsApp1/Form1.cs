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

        private void button1_Click(object sender, EventArgs e)
        {
            tab1TextBox.Clear();
            string[] valuesForTable = tab1input.Text.Split(',');
            int x = Int32.Parse(valuesForTable[0]);
            int y = Int32.Parse(valuesForTable[1]);
            Class1.GenTab(Class1.x,y);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    tab1TextBox.Text += result[i, j].ToString() + " ";
                }
                tab1TextBox.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tab2TextBox.Clear();
            string[] valuesForTable = tab2input.Text.Split(',');
            int x = Int32.Parse(valuesForTable[0]);
            int y = Int32.Parse(valuesForTable[1]);
            int[,] result = Class1.GenRandomTable(x, y);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Tab2TextBox.Text += result[i, j].ToString() + " ";
                }
                Tab2TextBox.Text += Environment.NewLine;
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tab1TextBox.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tab2TextBox.Clear();
        }
    }
}