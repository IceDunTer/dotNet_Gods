namespace WindowsFormsApp1
{
    partial class Lab3
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
            this.t5_lbl1 = new System.Windows.Forms.Label();
            this.t5_tb = new System.Windows.Forms.TextBox();
            this.t5_btn = new System.Windows.Forms.Button();
            this.t5_lbl2 = new System.Windows.Forms.Label();
            this.t5_lbl3 = new System.Windows.Forms.Label();
            this.t6_lbl1 = new System.Windows.Forms.Label();
            this.t6_btn = new System.Windows.Forms.Button();
            this.t6_lbl2 = new System.Windows.Forms.Label();
            this.t6_lbl3 = new System.Windows.Forms.Label();
            this.t7_tb = new System.Windows.Forms.TextBox();
            this.t7_lbl1 = new System.Windows.Forms.Label();
            this.t7_btn = new System.Windows.Forms.Button();
            this.t7_lbl3 = new System.Windows.Forms.Label();
            this.t7_lbl2 = new System.Windows.Forms.Label();
            this.t8_lbl3 = new System.Windows.Forms.Label();
            this.tx_lbl2 = new System.Windows.Forms.Label();
            this.t8_btn = new System.Windows.Forms.Button();
            this.t8_lbl1 = new System.Windows.Forms.Label();
            this.t8_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // t5_lbl1
            // 
            this.t5_lbl1.AutoSize = true;
            this.t5_lbl1.Location = new System.Drawing.Point(31, 9);
            this.t5_lbl1.Name = "t5_lbl1";
            this.t5_lbl1.Size = new System.Drawing.Size(161, 13);
            this.t5_lbl1.TabIndex = 0;
            this.t5_lbl1.Text = "Введите точность eps (eps > 0)";
            // 
            // t5_tb
            // 
            this.t5_tb.Location = new System.Drawing.Point(34, 25);
            this.t5_tb.Name = "t5_tb";
            this.t5_tb.Size = new System.Drawing.Size(192, 20);
            this.t5_tb.TabIndex = 1;
            this.t5_tb.Text = "eps =";
            // 
            // t5_btn
            // 
            this.t5_btn.Location = new System.Drawing.Point(34, 51);
            this.t5_btn.Name = "t5_btn";
            this.t5_btn.Size = new System.Drawing.Size(192, 33);
            this.t5_btn.TabIndex = 2;
            this.t5_btn.Text = "Рассчитать";
            this.t5_btn.UseVisualStyleBackColor = true;
            this.t5_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // t5_lbl2
            // 
            this.t5_lbl2.AutoSize = true;
            this.t5_lbl2.Location = new System.Drawing.Point(256, 9);
            this.t5_lbl2.Name = "t5_lbl2";
            this.t5_lbl2.Size = new System.Drawing.Size(62, 13);
            this.t5_lbl2.TabIndex = 4;
            this.t5_lbl2.Text = "Результат:";
            this.t5_lbl2.Click += new System.EventHandler(this.t5_lbl2_Click);
            // 
            // t5_lbl3
            // 
            this.t5_lbl3.AutoSize = true;
            this.t5_lbl3.Location = new System.Drawing.Point(267, 32);
            this.t5_lbl3.Name = "t5_lbl3";
            this.t5_lbl3.Size = new System.Drawing.Size(37, 13);
            this.t5_lbl3.TabIndex = 5;
            this.t5_lbl3.Text = "Ответ";
            // 
            // t6_lbl1
            // 
            this.t6_lbl1.AutoSize = true;
            this.t6_lbl1.Location = new System.Drawing.Point(31, 104);
            this.t6_lbl1.Name = "t6_lbl1";
            this.t6_lbl1.Size = new System.Drawing.Size(195, 13);
            this.t6_lbl1.TabIndex = 6;
            this.t6_lbl1.Text = "Значения [0;6] для рассчета функции";
            this.t6_lbl1.Click += new System.EventHandler(this.t6_lbl1_Click);
            // 
            // t6_btn
            // 
            this.t6_btn.Location = new System.Drawing.Point(34, 120);
            this.t6_btn.Name = "t6_btn";
            this.t6_btn.Size = new System.Drawing.Size(192, 32);
            this.t6_btn.TabIndex = 8;
            this.t6_btn.Text = "Рассчитать";
            this.t6_btn.UseVisualStyleBackColor = true;
            this.t6_btn.Click += new System.EventHandler(this.t6_btn_Click);
            // 
            // t6_lbl2
            // 
            this.t6_lbl2.AutoSize = true;
            this.t6_lbl2.Location = new System.Drawing.Point(256, 104);
            this.t6_lbl2.Name = "t6_lbl2";
            this.t6_lbl2.Size = new System.Drawing.Size(62, 13);
            this.t6_lbl2.TabIndex = 9;
            this.t6_lbl2.Text = "Результат:";
            // 
            // t6_lbl3
            // 
            this.t6_lbl3.AutoSize = true;
            this.t6_lbl3.Location = new System.Drawing.Point(267, 130);
            this.t6_lbl3.Name = "t6_lbl3";
            this.t6_lbl3.Size = new System.Drawing.Size(37, 13);
            this.t6_lbl3.TabIndex = 10;
            this.t6_lbl3.Text = "Ответ";
            // 
            // t7_tb
            // 
            this.t7_tb.Location = new System.Drawing.Point(39, 205);
            this.t7_tb.Name = "t7_tb";
            this.t7_tb.Size = new System.Drawing.Size(187, 20);
            this.t7_tb.TabIndex = 11;
            // 
            // t7_lbl1
            // 
            this.t7_lbl1.AutoSize = true;
            this.t7_lbl1.Location = new System.Drawing.Point(36, 189);
            this.t7_lbl1.Name = "t7_lbl1";
            this.t7_lbl1.Size = new System.Drawing.Size(118, 13);
            this.t7_lbl1.TabIndex = 12;
            this.t7_lbl1.Text = "Введите строку чисел";
            this.t7_lbl1.Click += new System.EventHandler(this.t7_lbl1_Click);
            // 
            // t7_btn
            // 
            this.t7_btn.Location = new System.Drawing.Point(39, 231);
            this.t7_btn.Name = "t7_btn";
            this.t7_btn.Size = new System.Drawing.Size(187, 32);
            this.t7_btn.TabIndex = 13;
            this.t7_btn.Text = "Рассчитать";
            this.t7_btn.UseVisualStyleBackColor = true;
            this.t7_btn.Click += new System.EventHandler(this.t7_btn_Click);
            // 
            // t7_lbl3
            // 
            this.t7_lbl3.AutoSize = true;
            this.t7_lbl3.Location = new System.Drawing.Point(267, 215);
            this.t7_lbl3.Name = "t7_lbl3";
            this.t7_lbl3.Size = new System.Drawing.Size(37, 13);
            this.t7_lbl3.TabIndex = 15;
            this.t7_lbl3.Text = "Ответ";
            // 
            // t7_lbl2
            // 
            this.t7_lbl2.AutoSize = true;
            this.t7_lbl2.Location = new System.Drawing.Point(256, 189);
            this.t7_lbl2.Name = "t7_lbl2";
            this.t7_lbl2.Size = new System.Drawing.Size(62, 13);
            this.t7_lbl2.TabIndex = 14;
            this.t7_lbl2.Text = "Результат:";
            // 
            // t8_lbl3
            // 
            this.t8_lbl3.AutoSize = true;
            this.t8_lbl3.Location = new System.Drawing.Point(267, 305);
            this.t8_lbl3.Name = "t8_lbl3";
            this.t8_lbl3.Size = new System.Drawing.Size(37, 13);
            this.t8_lbl3.TabIndex = 20;
            this.t8_lbl3.Text = "Ответ";
            // 
            // tx_lbl2
            // 
            this.tx_lbl2.AutoSize = true;
            this.tx_lbl2.Location = new System.Drawing.Point(256, 279);
            this.tx_lbl2.Name = "tx_lbl2";
            this.tx_lbl2.Size = new System.Drawing.Size(62, 13);
            this.tx_lbl2.TabIndex = 19;
            this.tx_lbl2.Text = "Результат:";
            // 
            // t8_btn
            // 
            this.t8_btn.Location = new System.Drawing.Point(39, 321);
            this.t8_btn.Name = "t8_btn";
            this.t8_btn.Size = new System.Drawing.Size(187, 32);
            this.t8_btn.TabIndex = 18;
            this.t8_btn.Text = "Рассчитать";
            this.t8_btn.UseVisualStyleBackColor = true;
            this.t8_btn.Click += new System.EventHandler(this.t8_btn_Click);
            // 
            // t8_lbl1
            // 
            this.t8_lbl1.AutoSize = true;
            this.t8_lbl1.Location = new System.Drawing.Point(36, 279);
            this.t8_lbl1.Name = "t8_lbl1";
            this.t8_lbl1.Size = new System.Drawing.Size(139, 13);
            this.t8_lbl1.TabIndex = 17;
            this.t8_lbl1.Text = "Введите значение N (N>0)";
            this.t8_lbl1.Click += new System.EventHandler(this.label3_Click);
            // 
            // t8_tb
            // 
            this.t8_tb.Location = new System.Drawing.Point(39, 295);
            this.t8_tb.Name = "t8_tb";
            this.t8_tb.Size = new System.Drawing.Size(187, 20);
            this.t8_tb.TabIndex = 16;
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 461);
            this.Controls.Add(this.t8_lbl3);
            this.Controls.Add(this.tx_lbl2);
            this.Controls.Add(this.t8_btn);
            this.Controls.Add(this.t8_lbl1);
            this.Controls.Add(this.t8_tb);
            this.Controls.Add(this.t7_lbl3);
            this.Controls.Add(this.t7_lbl2);
            this.Controls.Add(this.t7_btn);
            this.Controls.Add(this.t7_lbl1);
            this.Controls.Add(this.t7_tb);
            this.Controls.Add(this.t6_lbl3);
            this.Controls.Add(this.t6_lbl2);
            this.Controls.Add(this.t6_btn);
            this.Controls.Add(this.t6_lbl1);
            this.Controls.Add(this.t5_lbl3);
            this.Controls.Add(this.t5_lbl2);
            this.Controls.Add(this.t5_btn);
            this.Controls.Add(this.t5_tb);
            this.Controls.Add(this.t5_lbl1);
            this.Name = "Lab3";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label t5_lbl1;
        private System.Windows.Forms.TextBox t5_tb;
        private System.Windows.Forms.Button t5_btn;
        private System.Windows.Forms.Label t5_lbl2;
        private System.Windows.Forms.Label t5_lbl3;
        private System.Windows.Forms.Label t6_lbl1;
        private System.Windows.Forms.Button t6_btn;
        private System.Windows.Forms.Label t6_lbl2;
        private System.Windows.Forms.Label t6_lbl3;
        private System.Windows.Forms.TextBox t7_tb;
        private System.Windows.Forms.Label t7_lbl1;
        private System.Windows.Forms.Button t7_btn;
        private System.Windows.Forms.Label t7_lbl3;
        private System.Windows.Forms.Label t7_lbl2;
        private System.Windows.Forms.Label t8_lbl3;
        private System.Windows.Forms.Label tx_lbl2;
        private System.Windows.Forms.Button t8_btn;
        private System.Windows.Forms.Label t8_lbl1;
        private System.Windows.Forms.TextBox t8_tb;
    }
}

