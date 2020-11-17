using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        public static int money = 0;
        public static int multipliers = 1;
        public static int Crums = 30000;
        public static int howMany = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            money = (money + (1 * (multipliers)));
            Crums = (Crums - (1 * multipliers));
            label1.Text = "Curent money " + (Convert.ToString(money));
            label2.Text = "Cookie Crums Left : " + Convert.ToString(Crums);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money > 99 && howMany < 1)
            {
                multipliers = 2;
                howMany++;
                money = money - 100;
                label1.Text = "Curent money " + (Convert.ToString(money));
            }
            else
            {
                MessageBox.Show("Already puchased or not enough money");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money > 499 && howMany == 1)
            {
                multipliers = 5;
                howMany++;
                money = money - 500;
                label1.Text = "Curent money " + (Convert.ToString(money));
            }
            else
            {
                MessageBox.Show("Already puchased or not enough money");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money > 999 && howMany == 2)
            {
                multipliers = 20;
                howMany++;
                money = money - 1000;
                label1.Text = "Curent money " + (Convert.ToString(money));
            }
            else
            {
                MessageBox.Show("Already puchased or not enough money");
            }
        }
    }
}
