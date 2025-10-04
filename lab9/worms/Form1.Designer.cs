namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rnb = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.outt = new System.Windows.Forms.TextBox();
            this.rnf = new System.Windows.Forms.Button();
            this.addnf = new System.Windows.Forms.Button();
            this.copyf = new System.Windows.Forms.Button();
            this.Enter2 = new System.Windows.Forms.TextBox();
            this.rnb2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.infof = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rnb
            // 
            this.rnb.Location = new System.Drawing.Point(455, 34);
            this.rnb.Name = "rnb";
            this.rnb.Size = new System.Drawing.Size(75, 23);
            this.rnb.TabIndex = 0;
            this.rnb.Text = "Проводник";
            this.rnb.UseVisualStyleBackColor = true;
            this.rnb.Click += new System.EventHandler(this.rnb_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(23, 36);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(426, 20);
            this.Enter.TabIndex = 1;
            this.Enter.TextChanged += new System.EventHandler(this.Enter_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поле для ввода";
            // 
            // outt
            // 
            this.outt.Enabled = false;
            this.outt.Location = new System.Drawing.Point(27, 202);
            this.outt.Multiline = true;
            this.outt.Name = "outt";
            this.outt.Size = new System.Drawing.Size(426, 209);
            this.outt.TabIndex = 3;
            this.outt.TextChanged += new System.EventHandler(this.outt_TextChanged);
            // 
            // rnf
            // 
            this.rnf.Location = new System.Drawing.Point(23, 88);
            this.rnf.Name = "rnf";
            this.rnf.Size = new System.Drawing.Size(159, 39);
            this.rnf.TabIndex = 4;
            this.rnf.Text = "Добавить случайные числа в файл и найти min и max";
            this.rnf.UseVisualStyleBackColor = true;
            this.rnf.Click += new System.EventHandler(this.rnf_Click);
            // 
            // addnf
            // 
            this.addnf.Location = new System.Drawing.Point(188, 88);
            this.addnf.Name = "addnf";
            this.addnf.Size = new System.Drawing.Size(159, 39);
            this.addnf.TabIndex = 5;
            this.addnf.Text = "Добавить число на случайную позицию";
            this.addnf.UseVisualStyleBackColor = true;
            this.addnf.Click += new System.EventHandler(this.addnf_Click);
            // 
            // copyf
            // 
            this.copyf.Location = new System.Drawing.Point(23, 133);
            this.copyf.Name = "copyf";
            this.copyf.Size = new System.Drawing.Size(159, 39);
            this.copyf.TabIndex = 6;
            this.copyf.Text = "Скопировать файл";
            this.copyf.UseVisualStyleBackColor = true;
            this.copyf.Click += new System.EventHandler(this.copyf_Click);
            // 
            // Enter2
            // 
            this.Enter2.Enabled = false;
            this.Enter2.Location = new System.Drawing.Point(23, 62);
            this.Enter2.Name = "Enter2";
            this.Enter2.Size = new System.Drawing.Size(426, 20);
            this.Enter2.TabIndex = 7;
            this.Enter2.TextChanged += new System.EventHandler(this.Enter2_TextChanged);
            // 
            // rnb2
            // 
            this.rnb2.Enabled = false;
            this.rnb2.Location = new System.Drawing.Point(455, 60);
            this.rnb2.Name = "rnb2";
            this.rnb2.Size = new System.Drawing.Size(75, 23);
            this.rnb2.TabIndex = 8;
            this.rnb2.Text = "Проводник";
            this.rnb2.UseVisualStyleBackColor = true;
            this.rnb2.Visible = false;
            this.rnb2.Click += new System.EventHandler(this.rnb2_Click);
            // 
            // infof
            // 
            this.infof.Location = new System.Drawing.Point(188, 133);
            this.infof.Name = "infof";
            this.infof.Size = new System.Drawing.Size(159, 39);
            this.infof.TabIndex = 9;
            this.infof.Text = "Информация о файле";
            this.infof.UseVisualStyleBackColor = true;
            this.infof.Click += new System.EventHandler(this.infof_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.infof);
            this.Controls.Add(this.rnb2);
            this.Controls.Add(this.Enter2);
            this.Controls.Add(this.copyf);
            this.Controls.Add(this.addnf);
            this.Controls.Add(this.rnf);
            this.Controls.Add(this.outt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.rnb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rnb;
        private System.Windows.Forms.TextBox Enter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outt;
        private System.Windows.Forms.Button rnf;
        private System.Windows.Forms.Button addnf;
        private System.Windows.Forms.Button copyf;
        private System.Windows.Forms.TextBox Enter2;
        private System.Windows.Forms.Button rnb2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button infof;
    }
}

