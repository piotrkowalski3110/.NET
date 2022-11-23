using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsLib;

namespace Kol1FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            string[] rozmiary = textBox1.Text.Split(',');
            string[] minmax = textBox2.Text.Split(',');

            if ((Int32.Parse(minmax[1]) - Int32.Parse(minmax[0])) <
                (Int32.Parse(rozmiary[0]) * Int32.Parse(rozmiary[1])))
            {
                textBox3.AppendText("Zbyt mały przedział liczb!");
            }

            else
            {
                Class1.Resize(Int32.Parse(rozmiary[0]), Int32.Parse(rozmiary[1]), ref Class1.Tab);
                Class1.GenRNDtab(Int32.Parse(minmax[0]), Int32.Parse(minmax[1]), ref Class1.Tab);

                for (int i = 0; i < Class1.Tab.GetLength(0); i++)
                {
                    for (int j = 0; j < Class1.Tab.GetLength(1); j++)
                    {
                        textBox3.AppendText(Class1.Tab[i, j].ToString() + " ");
                    }

                    textBox3.AppendText(Environment.NewLine);
                }
            }
        }
    }
}