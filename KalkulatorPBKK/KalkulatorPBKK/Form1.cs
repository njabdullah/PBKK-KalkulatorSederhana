using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPBKK
{
    public partial class Form1 : Form
    {

        string CalTotal;
        float num1;
        float num2;
        string option;
        float result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void SamaDengan_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(textBox1.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("x"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textBox1.Text = result + "";
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void Kurang_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void Kali_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void Bagi_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = float.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
