using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void t1_btn_Click(object sender, EventArgs e)
        {
            string a = t1_tb1.Text;
            string b = t1_tb2.Text;

            if (a.Length > b.Length)
            {
                t1_ans.Text = ($"Строка А больше строки В на {a.Length - b.Length}");
            }
            else if (a.Length == b.Length) { t1_ans.Text = ("Обе строки одинаковой длины."); }
            else t1_ans.Text = ($"Строка B больше строки A на {a.Length - b.Length}");
        }

        private void t2_btn_Click(object sender, EventArgs e)
        {
            string a = t2_tb.Text;
            string[] b = a.Split(',');

            b[b.Length - 1] = b[b.Length - 1].TrimEnd('.');

            if (b.Length <= 30 && b.Length >= 1)
            {
                foreach (string word in b)
                {
                    if (word.Length > 6)
                    {
                        t2_ans.Text = ("В слове больше 5 букв!");
                        return;
                    }
                }

                Array.Reverse(b);

                t2_ans.Text = ("Последовательность в обратном порядке:");
                t2_ans.Text = (string.Join(", ", b) + ".");
            }
            else
            {
                t2_ans.Text = ("Количество слов должно быть от 1 до 30!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = t3_tb.Text;
            string cons = "бвгджзйклмнпрстфхцчшщ";
            StringBuilder b = new StringBuilder();

            foreach (char c in a)
            {
                if (cons.Contains(c))
                {
                    b.Append(c);
                    b.Append(c);
                }
                else b.Append(c);
            }
            t3_ans.Text = ($"{b.ToString()}");
        }
    }
}
