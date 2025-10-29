namespace avm3
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.matrixDataGridView = new System.Windows.Forms.DataGridView();
            this.vectorFDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solveGaussButton = new System.Windows.Forms.Button();
            this.solveTridiagonalButton = new System.Windows.Forms.Button();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            this.residualTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.methodGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.matrixGroupBox = new System.Windows.Forms.GroupBox();
            this.example1Button = new System.Windows.Forms.Button();
            this.example2Button = new System.Windows.Forms.Button();
            this.example3Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorFDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.methodGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.matrixGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // matrixDataGridView
            // 
            this.matrixDataGridView.AllowUserToAddRows = false;
            this.matrixDataGridView.AllowUserToDeleteRows = false;
            this.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGridView.Location = new System.Drawing.Point(6, 19);
            this.matrixDataGridView.Name = "matrixDataGridView";
            this.matrixDataGridView.Size = new System.Drawing.Size(400, 200);
            this.matrixDataGridView.TabIndex = 0;
            // 
            // vectorFDataGridView
            // 
            this.vectorFDataGridView.AllowUserToAddRows = false;
            this.vectorFDataGridView.AllowUserToDeleteRows = false;
            this.vectorFDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vectorFDataGridView.Location = new System.Drawing.Point(412, 19);
            this.vectorFDataGridView.Name = "vectorFDataGridView";
            this.vectorFDataGridView.Size = new System.Drawing.Size(150, 200);
            this.vectorFDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Матрица A (n × n):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вектор f (n × 1):";
            // 
            // solveGaussButton
            // 
            this.solveGaussButton.Location = new System.Drawing.Point(6, 19);
            this.solveGaussButton.Name = "solveGaussButton";
            this.solveGaussButton.Size = new System.Drawing.Size(120, 30);
            this.solveGaussButton.TabIndex = 4;
            this.solveGaussButton.Text = "Метод Гаусса";
            this.solveGaussButton.UseVisualStyleBackColor = true;
            this.solveGaussButton.Click += new System.EventHandler(this.solveGaussButton_Click);
            // 
            // solveTridiagonalButton
            // 
            this.solveTridiagonalButton.Location = new System.Drawing.Point(132, 19);
            this.solveTridiagonalButton.Name = "solveTridiagonalButton";
            this.solveTridiagonalButton.Size = new System.Drawing.Size(120, 30);
            this.solveTridiagonalButton.TabIndex = 6;
            this.solveTridiagonalButton.Text = "Метод прогонки";
            this.solveTridiagonalButton.UseVisualStyleBackColor = true;
            this.solveTridiagonalButton.Click += new System.EventHandler(this.solveTridiagonalButton_Click);
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Location = new System.Drawing.Point(6, 32);
            this.solutionTextBox.Multiline = true;
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.ReadOnly = true;
            this.solutionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.solutionTextBox.Size = new System.Drawing.Size(270, 80);
            this.solutionTextBox.TabIndex = 7;
            // 
            // residualTextBox
            // 
            this.residualTextBox.Location = new System.Drawing.Point(282, 32);
            this.residualTextBox.Multiline = true;
            this.residualTextBox.Name = "residualTextBox";
            this.residualTextBox.ReadOnly = true;
            this.residualTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.residualTextBox.Size = new System.Drawing.Size(270, 80);
            this.residualTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Решение x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вектор невязки:";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(44, 19);
            this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.sizeNumericUpDown.TabIndex = 11;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sizeNumericUpDown.ValueChanged += new System.EventHandler(this.sizeNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "n = ";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(100, 17);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Создать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(181, 17);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // methodGroupBox
            // 
            this.methodGroupBox.Controls.Add(this.solveGaussButton);
            this.methodGroupBox.Controls.Add(this.solveTridiagonalButton);
            this.methodGroupBox.Location = new System.Drawing.Point(12, 275);
            this.methodGroupBox.Name = "methodGroupBox";
            this.methodGroupBox.Size = new System.Drawing.Size(260, 60);
            this.methodGroupBox.TabIndex = 15;
            this.methodGroupBox.TabStop = false;
            this.methodGroupBox.Text = "Методы решения";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.label3);
            this.resultGroupBox.Controls.Add(this.solutionTextBox);
            this.resultGroupBox.Controls.Add(this.residualTextBox);
            this.resultGroupBox.Controls.Add(this.label4);
            this.resultGroupBox.Location = new System.Drawing.Point(12, 341);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(560, 120);
            this.resultGroupBox.TabIndex = 16;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Результаты";
            // 
            // matrixGroupBox
            // 
            this.matrixGroupBox.Controls.Add(this.label1);
            this.matrixGroupBox.Controls.Add(this.matrixDataGridView);
            this.matrixGroupBox.Controls.Add(this.vectorFDataGridView);
            this.matrixGroupBox.Controls.Add(this.label2);
            this.matrixGroupBox.Location = new System.Drawing.Point(12, 50);
            this.matrixGroupBox.Name = "matrixGroupBox";
            this.matrixGroupBox.Size = new System.Drawing.Size(568, 225);
            this.matrixGroupBox.TabIndex = 17;
            this.matrixGroupBox.TabStop = false;
            this.matrixGroupBox.Text = "Исходные данные";
            // 
            // example1Button
            // 
            this.example1Button.Location = new System.Drawing.Point(278, 285);
            this.example1Button.Name = "example1Button";
            this.example1Button.Size = new System.Drawing.Size(90, 23);
            this.example1Button.TabIndex = 18;
            this.example1Button.Text = "Пример 1";
            this.example1Button.UseVisualStyleBackColor = true;
            this.example1Button.Click += new System.EventHandler(this.example1Button_Click);
            // 
            // example2Button
            // 
            this.example2Button.Location = new System.Drawing.Point(374, 285);
            this.example2Button.Name = "example2Button";
            this.example2Button.Size = new System.Drawing.Size(90, 23);
            this.example2Button.TabIndex = 19;
            this.example2Button.Text = "Пример 2";
            this.example2Button.UseVisualStyleBackColor = true;
            this.example2Button.Click += new System.EventHandler(this.example2Button_Click);
            // 
            // example3Button
            // 
            this.example3Button.Location = new System.Drawing.Point(470, 285);
            this.example3Button.Name = "example3Button";
            this.example3Button.Size = new System.Drawing.Size(90, 23);
            this.example3Button.TabIndex = 20;
            this.example3Button.Text = "Пример 3";
            this.example3Button.UseVisualStyleBackColor = true;
            this.example3Button.Click += new System.EventHandler(this.example3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 471);
            this.Controls.Add(this.example3Button);
            this.Controls.Add(this.example2Button);
            this.Controls.Add(this.example1Button);
            this.Controls.Add(this.matrixGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.methodGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Name = "Form1";
            this.Text = "Решение СЛАУ";
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorFDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.methodGroupBox.ResumeLayout(false);
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.matrixGroupBox.ResumeLayout(false);
            this.matrixGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixDataGridView;
        private System.Windows.Forms.DataGridView vectorFDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button solveGaussButton;
        private System.Windows.Forms.Button solveTridiagonalButton;
        private System.Windows.Forms.TextBox solutionTextBox;
        private System.Windows.Forms.TextBox residualTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox methodGroupBox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.GroupBox matrixGroupBox;
        private System.Windows.Forms.Button example1Button;
        private System.Windows.Forms.Button example2Button;
        private System.Windows.Forms.Button example3Button;
    }
}