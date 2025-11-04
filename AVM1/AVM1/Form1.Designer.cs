namespace AVM1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.NumericUpDown numericUpDownNodes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxShowOriginal;
        private System.Windows.Forms.CheckBox checkBoxShowInterpolation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            zedGraphControl = new ZedGraph.ZedGraphControl();
            comboBoxFunction = new ComboBox();
            comboBoxMethod = new ComboBox();
            numericUpDownNodes = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCalculate = new Button();
            groupBox1 = new GroupBox();
            checkBoxShowInterpolation = new CheckBox();
            checkBoxShowOriginal = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNodes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // zedGraphControl
            // 
            zedGraphControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zedGraphControl.Location = new Point(14, 14);
            zedGraphControl.Margin = new Padding(5, 3, 5, 3);
            zedGraphControl.Name = "zedGraphControl";
            zedGraphControl.ScrollGrace = 0D;
            zedGraphControl.ScrollMaxX = 0D;
            zedGraphControl.ScrollMaxY = 0D;
            zedGraphControl.ScrollMaxY2 = 0D;
            zedGraphControl.ScrollMinX = 0D;
            zedGraphControl.ScrollMinY = 0D;
            zedGraphControl.ScrollMinY2 = 0D;
            zedGraphControl.Size = new Size(876, 463);
            zedGraphControl.TabIndex = 0;
            zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // comboBoxFunction
            // 
            comboBoxFunction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFunction.FormattingEnabled = true;
            comboBoxFunction.Items.AddRange(new object[] { "f(x) = x² (малая производная)", "f(x) = 1/(1+25x²) (большая производная)", "f(x) = e^(x²)", "f(x) = |x|" });
            comboBoxFunction.Location = new Point(918, 44);
            comboBoxFunction.Margin = new Padding(4, 3, 4, 3);
            comboBoxFunction.Name = "comboBoxFunction";
            comboBoxFunction.Size = new Size(198, 23);
            comboBoxFunction.TabIndex = 1;
            // 
            // comboBoxMethod
            // 
            comboBoxMethod.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMethod.FormattingEnabled = true;
            comboBoxMethod.Items.AddRange(new object[] { "Полином Лагранжа (равноотстоящие узлы)", "Полином Лагранжа (Чебышевские узлы)", "Кубический сплайн" });
            comboBoxMethod.Location = new Point(918, 95);
            comboBoxMethod.Margin = new Padding(4, 3, 4, 3);
            comboBoxMethod.Name = "comboBoxMethod";
            comboBoxMethod.Size = new Size(198, 23);
            comboBoxMethod.TabIndex = 2;
            // 
            // numericUpDownNodes
            // 
            numericUpDownNodes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownNodes.Location = new Point(918, 145);
            numericUpDownNodes.Margin = new Padding(4, 3, 4, 3);
            numericUpDownNodes.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownNodes.Name = "numericUpDownNodes";
            numericUpDownNodes.Size = new Size(198, 23);
            numericUpDownNodes.TabIndex = 3;
            numericUpDownNodes.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(918, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 4;
            label1.Text = "Функция:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(918, 76);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Метод:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(918, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Количество узлов:";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCalculate.Location = new Point(918, 231);
            buttonCalculate.Margin = new Padding(4, 3, 4, 3);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(198, 35);
            buttonCalculate.TabIndex = 7;
            buttonCalculate.Text = "Построить график";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBoxShowInterpolation);
            groupBox1.Controls.Add(checkBoxShowOriginal);
            groupBox1.Location = new Point(899, 175);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(217, 48);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Показать:";
            // 
            // checkBoxShowInterpolation
            // 
            checkBoxShowInterpolation.AutoSize = true;
            checkBoxShowInterpolation.Checked = true;
            checkBoxShowInterpolation.CheckState = CheckState.Checked;
            checkBoxShowInterpolation.Location = new Point(99, 22);
            checkBoxShowInterpolation.Margin = new Padding(4, 3, 4, 3);
            checkBoxShowInterpolation.Name = "checkBoxShowInterpolation";
            checkBoxShowInterpolation.Size = new Size(120, 19);
            checkBoxShowInterpolation.TabIndex = 1;
            checkBoxShowInterpolation.Text = "Аппроксимацию";
            checkBoxShowInterpolation.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowOriginal
            // 
            checkBoxShowOriginal.AutoSize = true;
            checkBoxShowOriginal.Checked = true;
            checkBoxShowOriginal.CheckState = CheckState.Checked;
            checkBoxShowOriginal.Location = new Point(7, 22);
            checkBoxShowOriginal.Margin = new Padding(4, 3, 4, 3);
            checkBoxShowOriginal.Name = "checkBoxShowOriginal";
            checkBoxShowOriginal.Size = new Size(81, 19);
            checkBoxShowOriginal.TabIndex = 0;
            checkBoxShowOriginal.Text = "Оригинал";
            checkBoxShowOriginal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 489);
            Controls.Add(groupBox1);
            Controls.Add(buttonCalculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownNodes);
            Controls.Add(comboBoxMethod);
            Controls.Add(comboBoxFunction);
            Controls.Add(zedGraphControl);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Аппроксимация функций";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNodes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}