namespace avm4
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
            this.components = new System.ComponentModel.Container();
            this.matrixDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.matrixSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vectorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.initialApproxTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.maxIterationsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixDataGridView
            // 
            this.matrixDataGridView.AllowUserToAddRows = false;
            this.matrixDataGridView.AllowUserToDeleteRows = false;
            this.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixDataGridView.Location = new System.Drawing.Point(12, 32);
            this.matrixDataGridView.Name = "matrixDataGridView";
            this.matrixDataGridView.Size = new System.Drawing.Size(400, 200);
            this.matrixDataGridView.TabIndex = 0;
            this.toolTip1.SetToolTip(this.matrixDataGridView, "Введите матрицу коэффициентов");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Матрица A";
            // 
            // matrixSizeComboBox
            // 
            this.matrixSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matrixSizeComboBox.FormattingEnabled = true;
            this.matrixSizeComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.matrixSizeComboBox.Location = new System.Drawing.Point(337, 6);
            this.matrixSizeComboBox.Name = "matrixSizeComboBox";
            this.matrixSizeComboBox.Size = new System.Drawing.Size(75, 21);
            this.matrixSizeComboBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.matrixSizeComboBox, "Выберите размер матрицы");
            this.matrixSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.matrixSizeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вектор b (через ,)";
            // 
            // vectorTextBox
            // 
            this.vectorTextBox.Location = new System.Drawing.Point(109, 242);
            this.vectorTextBox.Name = "vectorTextBox";
            this.vectorTextBox.Size = new System.Drawing.Size(303, 20);
            this.vectorTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.vectorTextBox, "Введите вектор правой части через запятую");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начальное приближение x₀ (через , или 0):";
            // 
            // initialApproxTextBox
            // 
            this.initialApproxTextBox.Location = new System.Drawing.Point(243, 268);
            this.initialApproxTextBox.Name = "initialApproxTextBox";
            this.initialApproxTextBox.Size = new System.Drawing.Size(169, 20);
            this.initialApproxTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.initialApproxTextBox, "Введите начальное приближение через запятую или 0 для нулевого вектора");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Точность";
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(72, 294);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(100, 20);
            this.epsilonTextBox.TabIndex = 8;
            this.epsilonTextBox.Text = "0.0001";
            this.toolTip1.SetToolTip(this.epsilonTextBox, "Задайте точность вычислений");
            // 
            // maxIterationsTextBox
            // 
            this.maxIterationsTextBox.Location = new System.Drawing.Point(312, 294);
            this.maxIterationsTextBox.Name = "maxIterationsTextBox";
            this.maxIterationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxIterationsTextBox.TabIndex = 10;
            this.maxIterationsTextBox.Text = "1000";
            this.toolTip1.SetToolTip(this.maxIterationsTextBox, "Максимальное количество итераций");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Макс. число итераций";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(12, 320);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(200, 30);
            this.solveButton.TabIndex = 11;
            this.solveButton.Text = "Решить";
            this.toolTip1.SetToolTip(this.solveButton, "Запустить вычисления");
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(218, 320);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(194, 30);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Очистить";
            this.toolTip1.SetToolTip(this.clearButton, "Очистить все поля");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(12, 380);
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size(400, 150);
            this.resultsTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Результат";
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "Оба метода",
            "Метод Якоби",
            "Метод Зейделя"});
            this.methodComboBox.Location = new System.Drawing.Point(430, 6);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(200, 21);
            this.methodComboBox.TabIndex = 16;
            this.toolTip1.SetToolTip(this.methodComboBox, "Выберите метод решения");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "График зависимости нормы невязки от номера итерации";
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(430, 32);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(500, 300);
            this.zedGraphControl.TabIndex = 18;
            this.toolTip1.SetToolTip(this.zedGraphControl, "График зависимости нормы невязки от номера итерации");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.zedGraphControl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.maxIterationsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.initialApproxTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vectorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrixSizeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matrixDataGridView);
            this.Name = "Form1";
            this.Text = "Решение СЛАУ итерационными методами";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox matrixSizeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vectorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox initialApproxTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.TextBox maxIterationsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private ZedGraph.ZedGraphControl zedGraphControl;
    }
}