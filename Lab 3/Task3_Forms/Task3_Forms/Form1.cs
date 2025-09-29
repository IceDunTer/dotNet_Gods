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

namespace WindowsFormsApp1
{
    public partial class Lab3 : Form
    {
        public Lab3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eps = Convert.ToDouble(t5_tb.Text);
            double sum = 0;
            double term = 1;
            double product = 1;
            int n = 1;

            while (Math.Abs(term) >= eps)
            {
                sum += term;
                product *= n;
                term = 1.0 / Math.Sqrt(product);

                n++;

            }
            t5_lbl3.Text = $"{n}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void t5_lbl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double f(double x)
        {
            double a = (2 * (x-2) * (x-2) * (8 - x) - 1);
            if (a < 0) return 0;
            else return Math.Sqrt(2 * (x - 2) * (x - 2) * (8 - x) - 1);
        }

        private void t6_btn_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double res;
            int start = 0;
            while (start < 7) 
            {
                res = f(start);
                sum += res;
                start++;
            }

            t6_lbl3.Text = Convert.ToString(sum);

        }

        private void t6_lbl1_Click(object sender, EventArgs e)
        {

        }

        private void t7_lbl1_Click(object sender, EventArgs e)
        {

        }

        private void t7_btn_Click(object sender, EventArgs e)
        {
            long num = Convert.ToInt64(t7_tb.Text);
            int sum = 0, count = 0;

            while (num > 0)
            {
                int digit = (int)(num % 10);
                if (digit % 2 == 0)
                {
                    sum += digit;
                    count++;

                }
                num /= 10;
            }

            if (count == 0)
            {
                t7_lbl3.Text = "NO";
            }
            else t7_lbl3.Text = $"{(double)sum / count}";
        }

        public int f(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void t8_btn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(t8_tb.Text);
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                count += f(i);
            }

            t8_lbl3.Text = $"{count}";
        }
    }
}

