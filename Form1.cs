using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time = 3;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi;
            sayi = rnd.Next(1, 10);

            int metin = Convert.ToInt32(textBox1.Text);

            if (sayi == metin)
            {
                MessageBox.Show("Congratulations, you guessed it...");
            }
            else
            {
                MessageBox.Show("Sorry Wrong Guess, Try Again, Number: " + sayi);
            }
            textBox1.Text = "";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label2.Text = time.ToString();
            button2.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label2.Text = time.ToString();

            if(time == 0)
            {
                label2.Text = "";
                timer1.Enabled = false;
                button1.Enabled = true;
                textBox1.Enabled = true;
            }
        }
    }
}
