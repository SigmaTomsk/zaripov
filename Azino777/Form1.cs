using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azino777
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bank_Player = 10000;
        int bank_Kazino = 10000;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stavka_Player = 0,chislo_Player=0;
            int stavka_Kazino = 0,chislo_Kazino=0;
            Random R = new Random();
            if ((Convert.ToInt32(textBox1.Text) >=100) && (Convert.ToInt32(textBox1.Text)<=1000))
            {
                stavka_Player = Convert.ToInt32(textBox1.Text);
                bank_Player -= stavka_Player;
            }
            if (Convert.ToInt32(textBox2.Text)>=1 && Convert.ToInt32(textBox2.Text)<=100)
            {
                chislo_Player = Convert.ToInt32(textBox2.Text);
            }
           
            textBox3.Text = R.Next(100, 1000).ToString();
            stavka_Kazino = Convert.ToInt32(textBox3.Text);
            bank_Kazino -= stavka_Kazino;
            textBox4.Text = R.Next(1, 100).ToString();
            chislo_Kazino = Convert.ToInt32(textBox4.Text);
            
            int proverka = chislo_Kazino - chislo_Player;
            if (proverka<=10)
            {
                stavka_Player *= 2;
                bank_Player += stavka_Player;
                stavka_Player = 0;
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
