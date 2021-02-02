using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, cntr, f, g, h, i, j;
        string b, c, d, e;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text.Length;
            b = Convert.ToString(a);
            if (a <= 9)
            {
                label5.Text = "0" + b;
            }
            else
            {
                label5.Text = b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox1.Text.Length - 1;
            for (cntr = a; cntr >= 0;  )
            {
                d = textBox1.Text.Substring(cntr, 1);
                c = c + d;
                cntr = cntr - 1;
            }
            label6.Text = c;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t, x = "";
            a = textBox1.Text.Length - 1;
            for (cntr = 0; cntr <= a; cntr ++)
            {
                t = textBox1.Text.Substring(cntr, 1);
                if (t == " ")
                {

                }
                else
                {
                    x = x + t;
                }
                label7.Text = x;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            j = 0;
            string y = "", k = "", l = "", m = "", n = "", o = "";
            a = textBox1.Text.Length - 1;
            for (cntr = 0; cntr <= a; cntr++)
            {
                y = textBox1.Text.Substring(cntr, 1);
                if (y == "a" || y == "A")
                {
                    f = f + 1;
                }
                else if (y == "e" || y == "E")
                {
                    g = g + 1;
                }
                else if (y == "i" || y == "I")
                {
                    h = h + 1;
                }
                else if (y == "o" || y == "O")
                {
                    i = i + 1;
                }
                else if (y == "u" || y == "U")
                {
                    j = j + 1;
                }
            }
            k = Convert.ToString(f);
            l = Convert.ToString(g);
            m = Convert.ToString(h);
            n = Convert.ToString(i);
            o = Convert.ToString(j);
            label13.Text = k;
            label14.Text = l;
            label15.Text = m;
            label16.Text = n;
            label17.Text = o;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string t = "";
            a = textBox1.Text.Length - 1;
            for (cntr = 0; cntr <= a; cntr++)
            {
                t = textBox1.Text.Substring(cntr, 1);
                listBox1.Items.Add("" + t);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            listBox1.Items.Clear();
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            textBox1.Text = "";
            a = 0;
            cntr = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            j = 0;
            b = "";
            c = "";
            d = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
