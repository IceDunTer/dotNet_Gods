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
        private List<string> letters = new List<string>();

        
        public Form1()
        {
            InitializeComponent();
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var letter in letters)
            {
                listBox1.Items.Add(letter);
            }
        }
        


        private void sortl_Click(object sender, EventArgs e)
        {
            letters.Sort();
            UpdateListBox();
            Resul.Text = "Список отсортирован";
        }

        private void addl_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                letters.Add(Enter.Text);
                UpdateListBox();
                Resul.Text = $"Добавлена буква {Enter.Text}";
                Enter.Clear();
            }
            else { Resul.Text = "Введите букву для добавления"; }
        }

        private void reml_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                string remle = Enter.Text;
                if (letters.Remove(remle))
                {
                    UpdateListBox();
                    Resul.Text = $"Буква {remle} удалена";
                    Enter.Clear();
                }
                else Resul.Text = $"Буквы {Enter.Text} не найдено";
                
            }
            else { Resul.Text = "Введите букву для удаления"; }
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
                if (int.TryParse(Enter.Text, out int idx) && idx >= 0 && idx < letters.Count)
                {
                    string remle = letters[idx];
                    letters.RemoveAt(idx);
                    UpdateListBox();
                    Resul.Text = $"Буква {remle} с индексом {idx} удалена";
                    Enter.Clear();
                }
                else Resul.Text = "Некорректный индекс";
            }
            else { Resul.Text = "Введите индекс для удаления"; }
        }

        private void sear_Click(object sender, EventArgs e)
        {
            letters.Sort();
            UpdateListBox();
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                int index = letters.BinarySearch(Enter.Text);
                if (index >= 0)
                {
                    Resul.Text = $"Буквы найдена по индексу {index}";
                }
                else
                {
                    Resul.Text = $"Буквы не найдена";
                }
                Enter.Clear();
            }
            else { Resul.Text = "Введите букву для поиска"; }
        }
    }
    }

