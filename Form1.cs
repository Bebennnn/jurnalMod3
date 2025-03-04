using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnalmod3
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hasil.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            hasil.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hasil.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hasil.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hasil.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hasil.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hasil.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hasil.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hasil.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hasil.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            x = int.Parse(hasil.Text);
            hasil.Text = "";

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int hasiljj = int.Parse(hasil.Text) + x;
            hasil.Text = hasiljj.ToString(); 
            hasil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            hasil.Text = ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
