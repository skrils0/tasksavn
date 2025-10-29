namespace AVM2
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 117);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(197, 59);
            button1.TabIndex = 2;
            button1.Text = "Правые";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 255, 255);
            label1.Location = new Point(580, 139);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 255, 255);
            label2.Location = new Point(595, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 313);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(233, 184);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(197, 69);
            button2.TabIndex = 7;
            button2.Text = "Центральные";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(255, 60);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(148, 23);
            comboBox1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 255, 255);
            label3.Location = new Point(490, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 255, 255);
            label4.Location = new Point(13, 316);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 10;
            label4.Text = "Точность:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(474, 15);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 15);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(255, 255, 255);
            label5.Location = new Point(367, 18);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 13;
            label5.Text = "Верхний предел:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(255, 255, 255);
            label6.Location = new Point(71, 18);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 14;
            label6.Text = "Нижний предел:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(255, 255, 255);
            label7.Location = new Point(13, 63);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(234, 15);
            label7.TabIndex = 15;
            label7.Text = "Выберите функцию для интегрирования:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(255, 255, 255);
            label8.Location = new Point(458, 139);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 16;
            label8.Text = "Значение интеграла:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(255, 255, 255);
            label9.Location = new Point(458, 167);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(137, 15);
            label9.TabIndex = 17;
            label9.Text = "Количество разбиений:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(255, 255, 255);
            label10.Location = new Point(458, 192);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 18;
            label10.Text = "Шаг:";
            // 
            // label11
            // 
            label11.ForeColor = Color.FromArgb(255, 255, 255);
            label11.Location = new Point(54, 129);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(171, 90);
            label11.TabIndex = 19;
            label11.Text = "Выберите метод для вычисления интеграла";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 105, 105);
            ClientSize = new Size(656, 344);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Калькулятор интегрирование";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Label label11;
    }
}