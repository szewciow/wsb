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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butpoka_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int bok)&& bok < 240)
            {
                panel1.Height = bok;
                panel1.Width = bok;
                label2.Visible = false;

            }
            else
            {
                label2.Visible = true;

            }
        }

        private void butkolor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
        }
    }
}
