using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolorki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double bok;
            if (Double.TryParse(textBox1.Text, out bok) == true && bok > 0)
            {
                label4.Text = "";
                double obwod = 4 * bok;
                double pole = bok * bok;
                textBox2.Text = obwod.ToString();
                textBox3.Text = pole.ToString();
            }
            else
            {
                label4.Text = "Wprowadź liczbę dodatnią";
                textBox2.Clear();
                textBox3.Clear();
            }

           
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
