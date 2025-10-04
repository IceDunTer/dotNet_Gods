using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void rnb_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            Enter.Text = filename;
        }

        private void outt_TextChanged(object sender, EventArgs e)
        {

        }
        Random rnd = new Random();
        double[] add = new double[11];
        double[] test1 = new double[10];
        double max = -1000, min = 1000;
        string path;
        private void rnf_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < test1.Length; i++)
            {
                test1[i] = rnd.Next(1, 100) + rnd.NextDouble();
            }
            if (!File.Exists(Enter.Text))
            {
                outt.Text = "Исходный файл не существует или указан неправильный путь!";
            }
            else
            {
                outt.Clear();
                path = Enter.Text;
                try
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                    {
                        foreach (double s in test1)
                        {
                            writer.Write(s);
                        }
                    }
                    outt.Text = "Числа успешно записаны\r\n";
                    using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                    {
                        while (reader.BaseStream.Position < reader.BaseStream.Length)
                        {
                            double yo = reader.ReadDouble();
                            outt.AppendText(yo + "\r\n");
                            if (yo > max) { max = yo; }
                            if (yo < min) { min = yo; }
                        }
                        outt.AppendText($"Сумма минимального ({min}) и максимального ({max}) чисел равна {min+max}\r\n");
                    }
                }
                catch (Exception d)
                {
                    outt.Text = d.Message;
                }
            }
        }

        private void Enter_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyf_Click(object sender, EventArgs e)
        {
            Enter2.Enabled = true;
            rnb2.Enabled = true;
            rnb2.Visible = true;
            if (!string.IsNullOrWhiteSpace(Enter.Text) && !string.IsNullOrWhiteSpace(Enter2.Text))
            {
                string sourceFile = Enter.Text;
                string targetDirectory = Path.GetDirectoryName(Enter2.Text);
                try
                {
                    if (!File.Exists(sourceFile))
                    {
                        outt.Text = ("Исходный файл не существует!");
                    }

                    string fileName = Path.GetFileName(sourceFile);
                    string destinationFile = Path.Combine(targetDirectory, fileName);

                    File.Copy(sourceFile, destinationFile, true);
                    outt.Text = ($"Файл успешно скопирован в: {destinationFile}");
                    Enter2.Enabled = false;
                    rnb2.Enabled = false;
                    rnb2.Visible = false;
                    Enter2.Clear();
                    Enter.Clear();
                }
                catch (Exception d)
                {
                    outt.Text = ("Ошибка при копировании: " + d.Message);
                }
            }
            else { outt.Text = ("Введите путь к исходному файлу и путь к целевому каталогу в новом поле"); }
        }

        private void rnb2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog folderDialog = new OpenFileDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    Enter2.Text = folderDialog.FileName;
                }
            }
        }

        private void Enter2_TextChanged(object sender, EventArgs e)
        {

        }

        private void infof_Click(object sender, EventArgs e)
        {
            Enter2.Enabled = true;
            rnb2.Enabled = true;
            rnb2.Visible = true;
            if (!string.IsNullOrWhiteSpace(Enter.Text) && !string.IsNullOrWhiteSpace(Enter2.Text))
            {
                string target = Enter.Text;
                string logi = Enter2.Text;
                if (File.Exists(target) && File.Exists(logi))
                {
                    outt.Clear();
                    string log = string.Format("Файл {0} существует. Время создания: {1}\r\nВремя последнего доступа: {2}\r\n" +
                        "Время последнего изменения: {3}\r\n",
                        Path.GetFileName(target),
                        File.GetCreationTime(target),
                        File.GetLastAccessTime(target),
                        File.GetLastWriteTime(target));
                    Console.WriteLine(log);
                    try
                    {
                        if (!File.Exists(logi))
                        {
                            File.Create(logi).Close();
                        }

                        using (BinaryWriter writer =
                            new BinaryWriter(File.Open(logi, FileMode.Append)))
                        {
                            writer.Write(log);
                        }
                        using (BinaryReader reader =
                            new BinaryReader(File.Open(logi, FileMode.Open)))
                        {
                            while (reader.BaseStream.Position < reader.BaseStream.Length)
                            {
                                outt.AppendText(reader.ReadString() + "\r\n");
                            }
                        }
                        Enter2.Enabled = false;
                        rnb2.Enabled = false;
                        rnb2.Visible = false;
                        Enter2.Clear();
                        Enter.Clear();
                    }
                    catch (Exception d)
                    {
                        Console.WriteLine(d.Message);
                    }
                }
                else Console.WriteLine("Не найден файл или logs.txt\n");
            }
            else { outt.Text = ("Введите путь к нужному файлу и путь к файлу logs.txt(если нет, необходимо создать)"); }

        }

        private void addnf_Click(object sender, EventArgs e)
        {
            int addd, y, b = rnd.Next(0, add.Length);
            if (!string.IsNullOrWhiteSpace(Enter.Text))
            {
                if (int.TryParse(Enter.Text, out int idx))
                {
                    outt.Clear();
                    addd = int.Parse(Enter.Text);
                    for (int i = 0; i < add.Length; i++)
                    {
                        if (i < b) { add[i] = test1[i]; }
                        else if (i == b) { add[i] = addd; }
                        else { add[i] = test1[i - 1]; }
                    }
                    try
                    {
                        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                        {
                            foreach (double s in add)
                            {
                                writer.Write(s);
                            }
                        }
                        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                        {
                            while (reader.BaseStream.Position < reader.BaseStream.Length)
                            {
                                double yo = reader.ReadDouble();
                                outt.AppendText(yo + "\r\n");
                                if (yo > max) { max = yo; }
                                if (yo < min) { min = yo; }
                            }
                            outt.AppendText($"Сумма минимального ({min}) и максимального ({max}) чисел равна {min + max}\r\n");
                        }
                    }
                    catch (Exception d)
                    {
                        outt.Text = d.Message;
                    }
                    Enter.Clear();
                }
                else outt.Text = "Некорректное число";
            }
            else { outt.Text = "Введите число для добавления"; }
        }
    }
}
