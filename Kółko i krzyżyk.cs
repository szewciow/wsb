using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int click = 0;
        bool notWin = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button1.Text !="X" && notWin==true)
            {
                button1.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button1.Text!="0" && notWin == true)
            {
                button1.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button2.Text != "X" && notWin == true)
            {
                button2.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button2.Text != "0" && notWin == true)
            {
                button2.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button3.Text != "X" && notWin == true)
            {
                button3.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button3.Text != "0" && notWin == true)
            {
                button3.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button4.Text != "X" && notWin == true)
            {
                button4.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button4.Text != "0" && notWin == true)
            {
                button4.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button5.Text != "X" && notWin == true)
            {
                button5.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button5.Text != "0" && notWin == true)
            {
                button5.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button6.Text != "X" && notWin == true)
            {
                button6.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button6.Text != "0" && notWin == true)
            {
                button6.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button7.Text != "X" && notWin == true)
            {
                button7.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button7.Text != "0" && notWin == true)
            {
                button7.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button8.Text != "X" && notWin == true)
            {
                button8.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button8.Text != "0" && notWin == true)
            {
                button8.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }
            Wygrana();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click % 2 == 0 && button9.Text != "X" && notWin == true)
            {
                button9.Text = "0";
                label1.Text = "Teraz gracz X";
                click++;
            }

            if (click % 2 == 1 && button9.Text != "0" && notWin == true)
            {
                button9.Text = "X";
                label1.Text = "Teraz gracz 0";
                click++;
            }

            Wygrana();
        }

        public void Wygrana()
        {

            if (button1.Text == button2.Text && button3.Text == button2.Text && button2.Text!="")
            {
                label1.Text = "Wygrał gracz"+ button1.Text;
                notWin = false;
            }

          


            else if (button4.Text == button5.Text && button6.Text == button4.Text && button4.Text != "")
            {
                label1.Text = "Wygrał gracz" + button4.Text;
                notWin = false;
            }


            else if(button7.Text == button8.Text && button9.Text == button7.Text && button7.Text != "")
            {
                label1.Text = "Wygrał gracz" + button7.Text;
                notWin = false;
            }

  

            else if (button1.Text == button5.Text && button9.Text == button5.Text && button1.Text != "")
            {
                label1.Text = "Wygrał gracz" + button1.Text;
                notWin = false;
            }

 

            else if (button7.Text == button3.Text  && button5.Text == button3.Text && button7.Text != "")
            {
                label1.Text = "Wygrał gracz"+ button7.Text;
                notWin = false;
            }
            else if (click == 9)
            {
                label1.Text = "Remis";

            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            notWin = true;
            click = 0;
        }
    }
}
