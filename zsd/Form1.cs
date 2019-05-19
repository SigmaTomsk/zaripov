using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace zsd
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=Title.db;Version=3;New=True;");
            try
            {
                StreamReader ReadCSV = new StreamReader("deniro.csv");
                while (!ReadCSV.EndOfStream)
                {
                    string list = ReadCSV.ReadLine().Replace("\"", "");
                    string[] arr = list.Split(',');


                }
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }



        }
    }
}
