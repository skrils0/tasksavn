namespace avm5
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
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.powerIterationButton = new System.Windows.Forms.Button();
            this.rotationMethodButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.matrixLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixDataGridView
            // 
            this.matrixDataGridView.AllowUserToAddRows = false;
            this.matrixDataGridView.AllowUserToDeleteRows = false;
            this.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGridView.Location = new System.Drawing.Point(12, 32);
            this.matrixDataGridView.Name = "matrixDataGridView";
            this.matrixDataGridView.RowHeadersWidth = 51;
            this.matrixDataGridView.Size = new System.Drawing.Size(400, 300);
            this.matrixDataGridView.TabIndex = 0;
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(430, 32);
            this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.sizeNumericUpDown.TabIndex = 1;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(427, 12);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(139, 16);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Размер матрицы (n):";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(430, 60);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(150, 30);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(430, 120);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(150, 22);
            this.epsilonTextBox.TabIndex = 4;
            this.epsilonTextBox.Text = "0,0001";
            // 
            // epsilonLabel
            // 
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Location = new System.Drawing.Point(427, 100);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(76, 16);
            this.epsilonLabel.TabIndex = 5;
            this.epsilonLabel.Text = "Точность ε:";
            // 
            // powerIterationButton
            // 
            this.powerIterationButton.Location = new System.Drawing.Point(430, 160);
            this.powerIterationButton.Name = "powerIterationButton";
            this.powerIterationButton.Size = new System.Drawing.Size(150, 40);
            this.powerIterationButton.TabIndex = 6;
            this.powerIterationButton.Text = "Метод прямой итерации";
            this.powerIterationButton.UseVisualStyleBackColor = true;
            this.powerIterationButton.Click += new System.EventHandler(this.powerIterationButton_Click);
            // 
            // rotationMethodButton
            // 
            this.rotationMethodButton.Location = new System.Drawing.Point(430, 210);
            this.rotationMethodButton.Name = "rotationMethodButton";
            this.rotationMethodButton.Size = new System.Drawing.Size(150, 40);
            this.rotationMethodButton.TabIndex = 7;
            this.rotationMethodButton.Text = "Метод вращений";
            this.rotationMethodButton.UseVisualStyleBackColor = true;
            this.rotationMethodButton.Click += new System.EventHandler(this.rotationMethodButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(12, 360);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size(568, 150);
            this.resultsTextBox.TabIndex = 8;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(12, 341);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(79, 16);
            this.resultsLabel.TabIndex = 9;
            this.resultsLabel.Text = "Результаты:";
            // 
            // matrixLabel
            // 
            this.matrixLabel.AutoSize = true;
            this.matrixLabel.Location = new System.Drawing.Point(12, 12);
            this.matrixLabel.Name = "matrixLabel";
            this.matrixLabel.Size = new System.Drawing.Size(63, 16);
            this.matrixLabel.TabIndex = 10;
            this.matrixLabel.Text = "Матрица:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(430, 260);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 30);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(592, 522);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.matrixLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.rotationMethodButton);
            this.Controls.Add(this.powerIterationButton);
            this.Controls.Add(this.epsilonLabel);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.matrixDataGridView);
            this.Name = "Form1";
            this.Text = "Вычисление собственных чисел матрицы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixDataGridView;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Label epsilonLabel;
        private System.Windows.Forms.Button powerIterationButton;
        private System.Windows.Forms.Button rotationMethodButton;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label matrixLabel;
        private System.Windows.Forms.Button clearButton;
    }
}