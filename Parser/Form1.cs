using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public Label lb;
        public PictureBox PB;
        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Url=@"https://vk.com";
                driver.FindElement(By.Id("index_email")).SendKeys("89131170202");
                driver.FindElement(By.XPath(".//div[@id='index_login']/form/input[@id='index_pass']")).SendKeys("TimurTopchik");
                driver.FindElement(By.Id("index_login_button")).Click();
                Thread.Sleep(500);
                driver.Url = @"https://vk.com/friends";
                var Frlist = driver.FindElements(By.XPath(".//div[@class = 'friends_list_bl']/div"));
                int flag = 0, x = 150, y = 12;
                foreach (IWebElement friend in Frlist)
                {
                    var ff = friend.FindElement(By.CssSelector(".friends_field"));
                    var ph_chel = friend.FindElement(By.CssSelector(".friends_photo_img")).GetAttribute("src");
                    var Name = ff.FindElement(By.TagName("a"));
                    this.lb=new Label()
                    {
                        Name = "Labeeel" + flag.ToString(),
                        Location = new Point(x, y),
                        Size = new Size(150,20),
                        AutoSize = false,
                        Text = Name.Text,
                        Tag= Name.GetAttribute("href")

                    };
                    lb.Click += lb_Click;
                    Controls.Add(this.lb);
                    this.PB = new PictureBox()
                    {
                        Name = "PB" + flag.ToString(),
                        Location = new Point(x, y+30),
                        AutoSize = false,
                        Text = Name.Text,
                        Size = new Size(150, 150),
                        ImageLocation = ph_chel,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Tag = Name.GetAttribute("href")
                    };
                    PB.Click += pb_Click;
                    Controls.Add(this.PB);
                    
                    flag++;
                    y += 200;
                    if (flag == 3) break;
                }
                //driver.Quit();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
                driver.Quit();
            }
            finally
            {
                
            }
        }

        private void lb_Click(object sender, EventArgs e)
        {
            this.lb = (sender as Label);
            System.Diagnostics.Process.Start( lb.Tag.ToString());
            
        }

        private void pb_Click(object sender, EventArgs e)
        {
            this.PB = (sender as PictureBox);
            System.Diagnostics.Process.Start( PB.Tag.ToString());

        }
    }
}
