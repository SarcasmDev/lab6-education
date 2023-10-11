using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcTek();
            calcJpt();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcTek();
            calcJpt();
        }

        private void calcTek()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                textBox3.Text = "";
            }
            try
            {
                int calc = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                if (calc > 0)
                    textBox3.Text = (calc).ToString();
                else
                    textBox3.Text = (calc).ToString() + " Не выгодно";
            }
            catch
            {

            }
        }
        private void calcJpt()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                textBox4.Text = "";
            }
            try
            {
                textBox4.Text = (double.Parse(textBox2.Text) / double.Parse(textBox1.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            calcTok();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            calcTok();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            calcTok();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calcCek();
            calcJst();
            calcTok();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calcCek();
            calcJst();
            calcTok();
        }

        private void calcCek()
        {
            if (textBox5.Text == "" || textBox6.Text == "")
            {
                textBox8.Text = "";
            }
            try
            {
                textBox8.Text = (int.Parse(textBox5.Text) - int.Parse(textBox6.Text)).ToString();
            }
            catch
            {

            }
        }

        private void calcJst()
        {
            if (textBox5.Text == "" || textBox6.Text == "")
            {
                textBox7.Text = "";
            }
            try
            {
                textBox7.Text = (double.Parse(textBox5.Text) / double.Parse(textBox6.Text)).ToString();
            }
            catch
            {

            }
        }
        private void calcTok()
        {
            if (textBox5.Text == "" || textBox6.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                textBox12.Text = "";
            }
            try
            {
                textBox12.Text = Math.Round((((double.Parse(textBox9.Text) + double.Parse(textBox10.Text)) * double.Parse(textBox11.Text)) / (double.Parse(textBox6.Text) - double.Parse(textBox5.Text))), 2).ToString();
            }
            catch
            {

            }
        }

    }
}
