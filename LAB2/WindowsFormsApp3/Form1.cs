using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ;
        }
        static double CountA(double x, double y, double z)
        {
            return (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / 1 + (x * x / 2) + (y * y / 4);
        }

        static double CountB(double x, double y, double z)
        {
            return (x * (Math.Atan(z) + Math.E));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, z;
            x = Convert.ToDouble(textBoxX.Text);
            y = Convert.ToDouble(textBoxY.Text);
            z = Convert.ToDouble(textBoxZ.Text);

            textBoxA.Text = ($"{CountA(x, y, z)}");
            textBoxB.Text = ($"{CountB(x, y, z)}");

        }

        static double Volume(double a1, double b2)
        {
            return ((Math.Pow(a1, 2)) * b2) / 3;
        }
        static double sqare(double a1, double b2)
        {
            double z, s;
            z = Math.Sqrt(Math.Pow(a1 / 2, 2) + Math.Pow(b2, 2));
            s = (a1 * z) / 2;
            return s * 4 + (a1 * a1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a1, b2, c1, d1;
            a1 = Convert.ToDouble(textBoxSide.Text);
            b2 = Convert.ToDouble(textBoxHeight.Text);

            textBoxVolume.Text = ($"{Volume(a1, b2)}");
            textBoxPl.Text = ($"{sqare(a1, b2)}");
        }
        static double minim(double a, double b)
        {
            if (a == b) return a;
            if (a < b) return a;
            else return b;
        }
        static double maxim(double a, double b)
        {
            if (a == b) return a;
            if (a > b) return a;
            else return b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double min, min1, min2;

            string input = textBoxABC.Text;
            string[] nums = input.Split(' ');
            double a = double.Parse(nums[0]);
            double b = double.Parse(nums[1]);
            double c = double.Parse(nums[2]);

            min = minim(a, minim(b, c));
            if (min == a)
            {
                min1 = minim(b, c);
                min2 = maxim(b, c);
            }
            else if (min == b)
            {
                min1 = minim(a, c);
                min2 = maxim(a, c);
            }
            else
            {
                min1 = minim(a, b);
                min2 = maxim(a, b);
            }

            textBoxLOW.Text = ($"{min2},{min1},{min}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] stud = new string[5] { "abakumov", "anoxin", "boev", "xarebin", "syrkov" };
            string[] nomera = new string[5] { "a111a", "b222b", "c333c", "d444d", "e555e" };

            string poisk = textBoxNumber.Text;
            int cnt = 0;
            for (int i = 0; i < stud.Length; i++)
            {
                if (nomera[i] == poisk)
                {
                    textBoxRES.Text = ($"{stud[i]}");
                    cnt++;
                    break;
                }
            }
            if (cnt == 0) { textBoxRES.Text = ("Номер не найден"); }


        }
        struct Human
        {
            public string name;
            public int age;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            Human bogdan;
            string input = textBoxNAMEAGE.Text;
            string[] nums = input.Split(' ');
            bogdan.name = (nums[0]);
            bogdan.age = int.Parse(nums[1]);
          

            
            textBoxNAMEAGE1.Text = ($"Имя: {bogdan.name} Возраст: {bogdan.age}");
        }
    }
}