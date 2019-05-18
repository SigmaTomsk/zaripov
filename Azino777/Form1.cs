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
            Random R = new Random();
            int stavka_Player = 0,stavka_Kazino = 0;
            int chislo_Player=0,chislo_Kazino = 0;
            if ((Convert.ToInt32(textBox1.Text) >=100) && (Convert.ToInt32(textBox1.Text)<=1000))
            {
                stavka_Player = Convert.ToInt32(textBox1.Text);
                bank_Player -= stavka_Player;
            }
            if ((Convert.ToInt32(textBox2.Text)>=1) && (Convert.ToInt32(textBox2.Text)<=100))
            {
                chislo_Player = Convert.ToInt32(textBox2.Text);
            }


            textBox3.Text = Convert.ToString(R.Next(100, 1000));
            stavka_Kazino = Convert.ToInt32(textBox3.Text);
            bank_Kazino -= stavka_Kazino;
            textBox4.Text= Convert.ToString(R.Next(1, 100));
            chislo_Kazino = Convert.ToInt32(textBox4.Text);
            int rez = R.Next(1, 100);
            int proverka = chislo_Player - chislo_Kazino;

            if (proverka<=10)  //Проверка числа Игрока
            {
                stavka_Player *= 2;
                bank_Player += stavka_Player;
                stavka_Player = 0;
                chislo_Player = 0;
            }
            else if (proverka>10 && proverka<=20)
            {
                bank_Player += stavka_Player;
                bank_Kazino += stavka_Kazino;
                stavka_Player = 0;
                chislo_Player = 0;
            }
            else
            {
                stavka_Kazino *= 2;
                bank_Kazino += stavka_Kazino;
                stavka_Player = 0;
                chislo_Player = 0;
            }


           
            if (bank_Player<100 && bank_Kazino>=100)
            {
                MessageBox.Show("Казино победил!");
            }
            else if (bank_Player >= 100 && bank_Kazino < 100)
            {
                MessageBox.Show("Игрок победил!");
            }
            else if (bank_Player < 100 && bank_Kazino < 100)
            {
                MessageBox.Show("Ничья!");
            }
            label8.Text = bank_Player + "$";
            label9.Text = bank_Kazino + "$";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
