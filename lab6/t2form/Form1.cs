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
        private List<Human> humans = new List<Human>();
        struct Human
        {
            private string name;
            private int age;

            public Human(string n, int a)
            {
                name = n;
                age = a;
            }
            public string outname()
            {
                return name;
            }
            public string displayInfo()
            {
                return ($"Имя: {name} Возраст: {age}");
            }
        }

        public Form1()
        {
            InitializeComponent();
            Human Artem = new Human("Artem", 12);
            Human Kirill = new Human("Kirill", 52);
            humans.Add(Kirill);
            humans.Add(Artem);
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var letter in humans)
            {
                listBox1.Items.Add(letter.displayInfo());
            }
        }



        private void sortl_Click(object sender, EventArgs e)
        {
            humans.Sort((x, y)=> x.outname().CompareTo(y.outname()));
            UpdateListBox();
            Resul.Text = "Список отсортирован";
        }

        private void addl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Enter.Text) && !string.IsNullOrWhiteSpace(EnterAge.Text))
            {
                if (int.TryParse(EnterAge.Text, out int idx) && idx >= 0)
                {
                 
                    humans.Add(new Human(Enter.Text, int.Parse(EnterAge.Text)));
                    UpdateListBox();
                    Resul.Text = $"Добавлен человек {Enter.Text} {EnterAge.Text}";
                    Enter.Clear();
                    EnterAge.Clear();
                }
                else Resul.Text = "Некорректный возраст";
            }
            else { Resul.Text = "Введите человека и возраст для добавления"; }
        }

        private void reml_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                string remle = Enter.Text;
                Human htorem = humans.Find(h => h.outname() == remle);
                if (humans.Remove(htorem))
                {
                    UpdateListBox();
                    Resul.Text = $"Человек {htorem.outname()} удален";
                    Enter.Clear();
                    EnterAge.Clear();
                }
                else Resul.Text = $"Человек {htorem.outname()} не найден";

            }
            else { Resul.Text = "Введите имя для удаления"; }
        }


        private void Resul_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                if (int.TryParse(Enter.Text, out int idx) && idx >= 0 && idx < humans.Count)
                {
                    Human remle = humans[idx];
                    humans.RemoveAt(idx);
                    UpdateListBox();
                    Resul.Text = $"Человек {remle.outname()} с индексом {idx} удален";
                    Enter.Clear();
                    EnterAge.Clear();
                }
                else Resul.Text = "Некорректный индекс";
            }
            else { Resul.Text = "Введите индекс для удаления"; }
        }

        private void sear_Click(object sender, EventArgs e)
        {
            humans.Sort((x, y) => x.outname().CompareTo(y.outname()));
            UpdateListBox();
            string nametoSear = Enter.Text;
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                nametoSear = Enter.Text;
                int index = humans.BinarySearch(new Human(nametoSear, 0), 
                    Comparer<Human>.Create((x, y)=> x.outname().CompareTo(y.outname())));
                if (index >= 0)
                {
                    Resul.Text = $"Человек найден по индексу {index}";
                }
                else
                {
                    Resul.Text = $"Человек не найден";

                }
                Enter.Clear();
                EnterAge.Clear();
            }
            else { Resul.Text = "Введите имя для поиска"; }
        }

        

        private void EnterAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

