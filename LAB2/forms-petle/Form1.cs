using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_petle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zarkes = textBox1.Text;
            int n = Int32.Parse(zarkes);
            int cyfra;
            List<int> palindromy = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                int liczba = i;
                while (true)
                {
                    if (liczba < 10)
                    {
                        palindromy.Add(liczba);
                        break;
                    }
                    else
                    {
                        cyfra = liczba % 10;
                        liczba = (liczba - cyfra) / 10;
                        palindromy.Add(cyfra);
                    }
                }

                if (palindromy[0] == palindromy[palindromy.Count - 1])
                {
                    listBox1.Items.Add(i);
                    palindromy.Clear();
                }
                else
                {
                    palindromy.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}