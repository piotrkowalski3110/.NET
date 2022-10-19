using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public static class Variables
    {
        public static int dzialanie;
        public static double result, liczba1, liczba2;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Variables.liczba2 = Double.Parse(textBox1.Text);
            switch (Variables.dzialanie)
            {
                case 1:
                    Variables.result = Variables.liczba1 + Variables.liczba2;
                    textBox1.Text = (Variables.result).ToString();
                    break;
                case 2:
                    Variables.result = Variables.liczba1 - Variables.liczba2;
                    textBox1.Text = (Variables.result).ToString();
                    break;
                case 3:
                    Variables.result = Variables.liczba1 * Variables.liczba2;
                    textBox1.Text = (Variables.result).ToString();
                    break;
                case 4:
                    Variables.result = Variables.liczba1 / Variables.liczba2;
                    textBox1.Text = (Variables.result).ToString();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "1";
            else textBox1.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "2";
            else textBox1.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "3";
            else textBox1.Text += '3';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "4";
            else textBox1.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "5";
            else textBox1.Text += '5';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "6";
            else textBox1.Text += '6';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "7";
            else textBox1.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "8";
            else textBox1.Text += '8';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "9";
            else textBox1.Text += '9';
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("0")) textBox1.Text = "0";
            else textBox1.Text += '0';
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Variables.liczba1 = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            Variables.dzialanie = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Variables.liczba1 = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            Variables.dzialanie = 2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Variables.liczba1 = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            Variables.dzialanie = 3;
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            Variables.liczba1 = Double.Parse(textBox1.Text);
            textBox1.Text = "0";
            Variables.dzialanie = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}