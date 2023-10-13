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
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || ((textBox1.Text)[0] == '0' & (textBox1.Text)[1] != ',') || ((textBox2.Text)[0] == '0' & (textBox2.Text)[1] != ','))
                {
                    textBox3.Text = "";
                }
                else
                {
                    try
                    {
                        double calc = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
                        if (calc > 0)
                            textBox3.Text = (Math.Round((calc),2)).ToString();
                        else
                            textBox3.Text = (Math.Round((calc), 2)).ToString() + " Не выгодно";
                    }
                    catch
                    {

                    }
                }
            }
            catch { }
        }
        private void calcJpt()
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || ((textBox2.Text)[0] == '0' & (textBox2.Text)[1] != ',') || ((textBox2.Text)[0] == '0' & (textBox2.Text)[1] != ','))
                {
                    textBox4.Text = "";
                }
                else
                {
                    try
                    {
                        textBox4.Text = (Math.Round((double.Parse(textBox2.Text) / double.Parse(textBox1.Text)),2)).ToString();
                    }
                    catch
                    {

                    }
                }
            }
            catch { }
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
            try
            {
                if (textBox5.Text == "" || textBox6.Text == "" || ((textBox5.Text)[0] == '0' & (textBox5.Text)[1] != ',') || ((textBox6.Text)[0] == '0' & (textBox6.Text)[1] != ','))
                {
                    textBox8.Text = "";
                }
                else
                {
                    try
                    {
                        textBox8.Text = (double.Parse(textBox5.Text) - double.Parse(textBox6.Text)).ToString();
                    }
                    catch
                    {

                    }
                }
            } catch { }
        }

        private void calcJst()
        {
            try
            {
                if (textBox5.Text == "" || textBox6.Text == "" || ((textBox5.Text)[0] == '0' & (textBox5.Text)[1] != ',') || ((textBox6.Text)[0] == '0' & (textBox6.Text)[1] != ','))
                {
                    textBox7.Text = "";
                }
                else
                {
                    try
                    {
                        textBox7.Text = Math.Round((double.Parse(textBox5.Text) / double.Parse(textBox6.Text)),2).ToString();
                    }
                    catch
                    {

                    }
                }
            }
            catch { }
        }
        private void calcTok()
        {
            try
            {
                if (textBox5.Text == "" || textBox6.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || ((textBox5.Text)[0] == '0' & (textBox5.Text)[1] != ',') || ((textBox6.Text)[0] == '0' & (textBox6.Text)[1] != ',') || ((textBox9.Text)[0] == '0' & (textBox9.Text)[1] != ',') || ((textBox10.Text)[0] == '0' & (textBox10.Text)[1] != ',') || ((textBox11.Text)[0] == '0' & (textBox11.Text)[1] != ','))
                {
                    textBox12.Text = "";
                }
                else
                {
                    try
                    {
                        textBox12.Text = Math.Round((((double.Parse(textBox9.Text) + double.Parse(textBox10.Text)) * double.Parse(textBox11.Text)) / (double.Parse(textBox6.Text) - double.Parse(textBox5.Text))), 2).ToString();
                    }
                    catch
                    {

                    }
                }
            }
            catch 
            {
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
}
