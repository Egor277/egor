using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор3._0
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void two_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 2;
        }

        private void three_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 9;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + 0;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            conclusion.Text = "";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                conclusion.Text = "-" + conclusion.Text;
                znak = false;
            }
            else if (znak == false)
            {
                conclusion.Text = conclusion.Text.Replace("-", "");
                znak = true;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            a = float.Parse(conclusion.Text);
            conclusion.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            a = float.Parse(conclusion.Text);
            conclusion.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            a = float.Parse(conclusion.Text);
            conclusion.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            a = float.Parse(conclusion.Text);
            conclusion.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void smooth_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void point_Click(object sender, EventArgs e)
        {
            conclusion.Text = conclusion.Text + ",";
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(conclusion.Text);
                    conclusion.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(conclusion.Text);
                    conclusion.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(conclusion.Text);
                    conclusion.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(conclusion.Text);
                    conclusion.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
