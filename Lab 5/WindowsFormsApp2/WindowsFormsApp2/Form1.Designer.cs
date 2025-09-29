namespace WindowsFormsApp2
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
            this.t1_lbl1 = new System.Windows.Forms.Label();
            this.t1_tb1 = new System.Windows.Forms.TextBox();
            this.t1_tb2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.t1_ans = new System.Windows.Forms.Label();
            this.t1_btn = new System.Windows.Forms.Button();
            this.t2_lbl1 = new System.Windows.Forms.Label();
            this.t2_tb = new System.Windows.Forms.TextBox();
            this.t2_btn = new System.Windows.Forms.Button();
            this.t2_ans = new System.Windows.Forms.Label();
            this.t2_lbl2 = new System.Windows.Forms.Label();
            this.t3_lbl1 = new System.Windows.Forms.Label();
            this.t3_tb = new System.Windows.Forms.TextBox();
            this.t3_btn = new System.Windows.Forms.Button();
            this.t3_ans = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t1_lbl1
            // 
            this.t1_lbl1.AutoSize = true;
            this.t1_lbl1.Location = new System.Drawing.Point(37, 9);
            this.t1_lbl1.Name = "t1_lbl1";
            this.t1_lbl1.Size = new System.Drawing.Size(108, 13);
            this.t1_lbl1.TabIndex = 0;
            this.t1_lbl1.Text = "Введите две строки";
            // 
            // t1_tb1
            // 
            this.t1_tb1.Location = new System.Drawing.Point(12, 35);
            this.t1_tb1.Name = "t1_tb1";
            this.t1_tb1.Size = new System.Drawing.Size(163, 20);
            this.t1_tb1.TabIndex = 1;
            // 
            // t1_tb2
            // 
            this.t1_tb2.Location = new System.Drawing.Point(12, 61);
            this.t1_tb2.Name = "t1_tb2";
            this.t1_tb2.Size = new System.Drawing.Size(163, 20);
            this.t1_tb2.TabIndex = 2;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(276, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(62, 13);
            this.result.TabIndex = 3;
            this.result.Text = "Результат:";
            // 
            // t1_ans
            // 
            this.t1_ans.AutoSize = true;
            this.t1_ans.Location = new System.Drawing.Point(287, 38);
            this.t1_ans.Name = "t1_ans";
            this.t1_ans.Size = new System.Drawing.Size(37, 13);
            this.t1_ans.TabIndex = 4;
            this.t1_ans.Text = "Ответ";
            // 
            // t1_btn
            // 
            this.t1_btn.Location = new System.Drawing.Point(12, 87);
            this.t1_btn.Name = "t1_btn";
            this.t1_btn.Size = new System.Drawing.Size(163, 33);
            this.t1_btn.TabIndex = 5;
            this.t1_btn.Text = "Сравнить";
            this.t1_btn.UseVisualStyleBackColor = true;
            this.t1_btn.Click += new System.EventHandler(this.t1_btn_Click);
            // 
            // t2_lbl1
            // 
            this.t2_lbl1.AutoSize = true;
            this.t2_lbl1.Location = new System.Drawing.Point(9, 153);
            this.t2_lbl1.Name = "t2_lbl1";
            this.t2_lbl1.Size = new System.Drawing.Size(235, 13);
            this.t2_lbl1.TabIndex = 6;
            this.t2_lbl1.Text = "Введите последовательность через запятую";
            // 
            // t2_tb
            // 
            this.t2_tb.Location = new System.Drawing.Point(12, 178);
            this.t2_tb.Name = "t2_tb";
            this.t2_tb.Size = new System.Drawing.Size(232, 20);
            this.t2_tb.TabIndex = 7;
            // 
            // t2_btn
            // 
            this.t2_btn.Location = new System.Drawing.Point(12, 204);
            this.t2_btn.Name = "t2_btn";
            this.t2_btn.Size = new System.Drawing.Size(232, 33);
            this.t2_btn.TabIndex = 8;
            this.t2_btn.Text = "Перевернуть строку";
            this.t2_btn.UseVisualStyleBackColor = true;
            this.t2_btn.Click += new System.EventHandler(this.t2_btn_Click);
            // 
            // t2_ans
            // 
            this.t2_ans.AutoSize = true;
            this.t2_ans.Location = new System.Drawing.Point(287, 182);
            this.t2_ans.Name = "t2_ans";
            this.t2_ans.Size = new System.Drawing.Size(37, 13);
            this.t2_ans.TabIndex = 10;
            this.t2_ans.Text = "Ответ";
            // 
            // t2_lbl2
            // 
            this.t2_lbl2.AutoSize = true;
            this.t2_lbl2.Location = new System.Drawing.Point(276, 153);
            this.t2_lbl2.Name = "t2_lbl2";
            this.t2_lbl2.Size = new System.Drawing.Size(62, 13);
            this.t2_lbl2.TabIndex = 9;
            this.t2_lbl2.Text = "Результат:";
            // 
            // t3_lbl1
            // 
            this.t3_lbl1.AutoSize = true;
            this.t3_lbl1.Location = new System.Drawing.Point(63, 262);
            this.t3_lbl1.Name = "t3_lbl1";
            this.t3_lbl1.Size = new System.Drawing.Size(82, 13);
            this.t3_lbl1.TabIndex = 11;
            this.t3_lbl1.Text = "Введите слово";
            this.t3_lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // t3_tb
            // 
            this.t3_tb.Location = new System.Drawing.Point(12, 278);
            this.t3_tb.Name = "t3_tb";
            this.t3_tb.Size = new System.Drawing.Size(186, 20);
            this.t3_tb.TabIndex = 12;
            // 
            // t3_btn
            // 
            this.t3_btn.Location = new System.Drawing.Point(12, 304);
            this.t3_btn.Name = "t3_btn";
            this.t3_btn.Size = new System.Drawing.Size(186, 33);
            this.t3_btn.TabIndex = 13;
            this.t3_btn.Text = "Удвоить согласные";
            this.t3_btn.UseVisualStyleBackColor = true;
            this.t3_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // t3_ans
            // 
            this.t3_ans.AutoSize = true;
            this.t3_ans.Location = new System.Drawing.Point(287, 291);
            this.t3_ans.Name = "t3_ans";
            this.t3_ans.Size = new System.Drawing.Size(37, 13);
            this.t3_ans.TabIndex = 15;
            this.t3_ans.Text = "Ответ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t3_ans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t3_btn);
            this.Controls.Add(this.t3_tb);
            this.Controls.Add(this.t3_lbl1);
            this.Controls.Add(this.t2_ans);
            this.Controls.Add(this.t2_lbl2);
            this.Controls.Add(this.t2_btn);
            this.Controls.Add(this.t2_tb);
            this.Controls.Add(this.t2_lbl1);
            this.Controls.Add(this.t1_btn);
            this.Controls.Add(this.t1_ans);
            this.Controls.Add(this.result);
            this.Controls.Add(this.t1_tb2);
            this.Controls.Add(this.t1_tb1);
            this.Controls.Add(this.t1_lbl1);
            this.Name = "Form1";
            this.Text = "Lab 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label t1_lbl1;
        private System.Windows.Forms.TextBox t1_tb1;
        private System.Windows.Forms.TextBox t1_tb2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label t1_ans;
        private System.Windows.Forms.Button t1_btn;
        private System.Windows.Forms.Label t2_lbl1;
        private System.Windows.Forms.TextBox t2_tb;
        private System.Windows.Forms.Button t2_btn;
        private System.Windows.Forms.Label t2_ans;
        private System.Windows.Forms.Label t2_lbl2;
        private System.Windows.Forms.Label t3_lbl1;
        private System.Windows.Forms.TextBox t3_tb;
        private System.Windows.Forms.Button t3_btn;
        private System.Windows.Forms.Label t3_ans;
        private System.Windows.Forms.Label label2;
    }
}

