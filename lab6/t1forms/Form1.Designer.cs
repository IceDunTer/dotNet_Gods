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
            this.remi = new System.Windows.Forms.Button();
            this.sortl = new System.Windows.Forms.Button();
            this.sear = new System.Windows.Forms.Button();
            this.addl = new System.Windows.Forms.Button();
            this.reml = new System.Windows.Forms.Button();
            this.Resul = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // remi
            // 
            this.remi.Location = new System.Drawing.Point(36, 147);
            this.remi.Name = "remi";
            this.remi.Size = new System.Drawing.Size(217, 24);
            this.remi.TabIndex = 4;
            this.remi.Text = "Удалить по индексу";
            this.remi.UseVisualStyleBackColor = true;
            this.remi.Click += new System.EventHandler(this.remi_Click);
            // 
            // sortl
            // 
            this.sortl.Location = new System.Drawing.Point(36, 177);
            this.sortl.Name = "sortl";
            this.sortl.Size = new System.Drawing.Size(106, 24);
            this.sortl.TabIndex = 5;
            this.sortl.Text = "Сортировать";
            this.sortl.UseVisualStyleBackColor = true;
            this.sortl.Click += new System.EventHandler(this.sortl_Click);
            // 
            // sear
            // 
            this.sear.Location = new System.Drawing.Point(147, 177);
            this.sear.Name = "sear";
            this.sear.Size = new System.Drawing.Size(106, 24);
            this.sear.TabIndex = 6;
            this.sear.Text = "Поиск";
            this.sear.UseVisualStyleBackColor = true;
            this.sear.Click += new System.EventHandler(this.sear_Click);
            // 
            // addl
            // 
            this.addl.Location = new System.Drawing.Point(36, 117);
            this.addl.Name = "addl";
            this.addl.Size = new System.Drawing.Size(106, 24);
            this.addl.TabIndex = 7;
            this.addl.Text = "Добавить";
            this.addl.UseVisualStyleBackColor = true;
            this.addl.Click += new System.EventHandler(this.addl_Click);
            // 
            // reml
            // 
            this.reml.Location = new System.Drawing.Point(147, 117);
            this.reml.Name = "reml";
            this.reml.Size = new System.Drawing.Size(106, 24);
            this.reml.TabIndex = 8;
            this.reml.Text = "Удалить";
            this.reml.UseVisualStyleBackColor = true;
            this.reml.Click += new System.EventHandler(this.reml_Click);
            // 
            // Resul
            // 
            this.Resul.Enabled = false;
            this.Resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resul.Location = new System.Drawing.Point(36, 207);
            this.Resul.Name = "Resul";
            this.Resul.Size = new System.Drawing.Size(217, 22);
            this.Resul.TabIndex = 9;
            this.Resul.TextChanged += new System.EventHandler(this.Resul_TextChanged);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.Location = new System.Drawing.Point(36, 57);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(217, 22);
            this.Enter.TabIndex = 10;
            this.Enter.TextChanged += new System.EventHandler(this.Enter_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(297, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 164);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 405);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Resul);
            this.Controls.Add(this.reml);
            this.Controls.Add(this.addl);
            this.Controls.Add(this.sear);
            this.Controls.Add(this.sortl);
            this.Controls.Add(this.remi);
            this.Name = "Form1";
            this.Text = "Лист букв";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button remi;
        private System.Windows.Forms.Button sortl;
        private System.Windows.Forms.Button sear;
        private System.Windows.Forms.Button addl;
        private System.Windows.Forms.Button reml;
        private System.Windows.Forms.TextBox Enter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Resul;
    }
}

