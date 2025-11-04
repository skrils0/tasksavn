using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace avm4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrixSizeComboBox.SelectedIndex = 1; // 3x3 по умолчанию
            methodComboBox.SelectedIndex = 0; // Оба метода
            InitializeZedGraph();
            InitializeDefaultMatrix();
        }

        private void InitializeZedGraph()
        {
            GraphPane pane = zedGraphControl.GraphPane;
            pane.Title.Text = "Зависимость нормы невязки от номера итерации";
            pane.XAxis.Title.Text = "Номер итерации";
            pane.YAxis.Title.Text = "Норма невязки";
            pane.YAxis.Type = AxisType.Log;

            // Очищаем предыдущие кривые
            pane.CurveList.Clear();

            // Настраиваем сетку
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.IsVisible = true;

            // Обновляем график
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void matrixSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeDefaultMatrix();
        }

        private void InitializeDefaultMatrix()
        {
            if (matrixSizeComboBox.SelectedItem == null) return;

            int size = int.Parse(matrixSizeComboBox.SelectedItem.ToString());

            // Очищаем DataGridView
            matrixDataGridView.Columns.Clear();
            matrixDataGridView.Rows.Clear();

            // Добавляем столбцы
            for (int i = 0; i < size; i++)
            {
                matrixDataGridView.Columns.Add($"col{i}", $"x{i + 1}");
                matrixDataGridView.Columns[i].Width = 50;
            }

            // Добавляем строки
            for (int i = 0; i < size; i++)
            {
                matrixDataGridView.Rows.Add();
            }

            // Заполняем тестовыми данными
            FillTestData(size);
        }

        private void FillTestData(int size)
        {
            // Пример матрицы с диагональным преобладанием для сходимости
            double[,] testMatrix = GetTestMatrix(size);
            double[] testVector = GetTestVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixDataGridView.Rows[i].Cells[j].Value = testMatrix[i, j].ToString("F1");
                }
            }

            vectorTextBox.Text = string.Join(", ", testVector.Select(x => x.ToString("F1")));
            initialApproxTextBox.Text = "0"; // Нулевое начальное приближение
        }

        private double[,] GetTestMatrix(int size)
        {
            var random = new Random();
            var matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                double sum = 0;
                for (int j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        matrix[i, j] = random.NextDouble() * 2 - 1; // [-1, 1]
                        sum += Math.Abs(matrix[i, j]);
                    }
                }
                // Обеспечиваем диагональное преобладание
                matrix[i, i] = sum + random.NextDouble() + 1;
            }

            return matrix;
        }

        private double[] GetTestVector(int size)
        {
            var random = new Random();
            var vector = new double[size];
            for (int i = 0; i < size; i++)
            {
                vector[i] = random.NextDouble() * 10 - 5; // [-5, 5]
            }
            return vector;
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из формы
                int size = int.Parse(matrixSizeComboBox.SelectedItem.ToString());
                double[,] A = GetMatrixFromGrid(size);
                double[] b = GetVectorFromTextBox(vectorTextBox.Text, size);
                double[] x0 = GetInitialApproximation(size);
                double epsilon = double.Parse(epsilonTextBox.Text);
                int maxIterations = int.Parse(maxIterationsTextBox.Text);

                // Очищаем предыдущие результаты
                resultsTextBox.Clear();
                InitializeZedGraph();

                bool solveJacobi = methodComboBox.SelectedIndex != 2; // Не только Зейдель
                bool solveSeidel = methodComboBox.SelectedIndex != 1; // Не только Якоби

                // Решаем выбранными методами
                if (solveJacobi)
                {
                    var (solution, iterations, residuals) = SolveJacobi(A, b, x0, epsilon, maxIterations);
                    DisplayResults("Метод Якоби", solution, iterations, residuals);
                    PlotResiduals(residuals, "Метод Якоби", Color.Blue);
                }

                if (solveSeidel)
                {
                    var (solution, iterations, residuals) = SolveSeidel(A, b, x0, epsilon, maxIterations);
                    DisplayResults("Метод Зейделя", solution, iterations, residuals);
                    PlotResiduals(residuals, "Метод Зейделя", Color.Red);
                }

                // Обновляем график
                zedGraphControl.AxisChange();
                zedGraphControl.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[,] GetMatrixFromGrid(int size)
        {
            double[,] matrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrixDataGridView.Rows[i].Cells[j].Value == null ||
                        string.IsNullOrEmpty(matrixDataGridView.Rows[i].Cells[j].Value.ToString()))
                    {
                        throw new Exception($"Не заполнена ячейка матрицы [{i + 1},{j + 1}]");
                    }
                    matrix[i, j] = double.Parse(matrixDataGridView.Rows[i].Cells[j].Value.ToString());
                }
            }
            return matrix;
        }

        private double[] GetVectorFromTextBox(string text, int size)
        {
            string[] parts = text.Split(',');
            if (parts.Length != size)
            {
                throw new Exception($"Размер вектора b должен быть {size}");
            }

            double[] vector = new double[size];
            for (int i = 0; i < size; i++)
            {
                vector[i] = double.Parse(parts[i].Trim());
            }
            return vector;
        }

        private double[] GetInitialApproximation(int size)
        {
            if (initialApproxTextBox.Text == "0")
            {
                return new double[size]; // Нулевой вектор
            }

            return GetVectorFromTextBox(initialApproxTextBox.Text, size);
        }

        private (double[] solution, int iterations, List<double> residuals) SolveJacobi(double[,] A, double[] b, double[] x0, double epsilon, int maxIterations)
        {
            int n = b.Length;
            double[] x = new double[n];
            double[] xNew = new double[n];
            Array.Copy(x0, x, n);

            var residuals = new List<double>();
            int iterations = 0;

            for (int k = 0; k < maxIterations; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (i != j)
                        {
                            sum += A[i, j] * x[j];
                        }
                    }
                    xNew[i] = (b[i] - sum) / A[i, i];
                }

                // Вычисляем норму невязки
                double residual = CalculateResidual(A, xNew, b);
                residuals.Add(residual);

                // Проверяем условие сходимости
                if (residual < epsilon)
                {
                    iterations = k + 1;
                    break;
                }

                Array.Copy(xNew, x, n);
                iterations = k + 1;
            }

            return (xNew, iterations, residuals);
        }

        private (double[] solution, int iterations, List<double> residuals) SolveSeidel(double[,] A, double[] b, double[] x0, double epsilon, int maxIterations)
        {
            int n = b.Length;
            double[] x = new double[n];
            Array.Copy(x0, x, n);

            var residuals = new List<double>();
            int iterations = 0;

            for (int k = 0; k < maxIterations; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    double sum1 = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum1 += A[i, j] * x[j];
                    }

                    double sum2 = 0;
                    for (int j = i + 1; j < n; j++)
                    {
                        sum2 += A[i, j] * x[j];
                    }

                    x[i] = (b[i] - sum1 - sum2) / A[i, i];
                }

                // Вычисляем норму невязки
                double residual = CalculateResidual(A, x, b);
                residuals.Add(residual);

                // Проверяем условие сходимости
                if (residual < epsilon)
                {
                    iterations = k + 1;
                    break;
                }

                iterations = k + 1;
            }

            return (x, iterations, residuals);
        }

        private double CalculateResidual(double[,] A, double[] x, double[] b)
        {
            int n = b.Length;
            double[] residualVector = new double[n];

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += A[i, j] * x[j];
                }
                residualVector[i] = b[i] - sum;
            }

            // Норма L2
            return Math.Sqrt(residualVector.Sum(r => r * r));
        }

        private void DisplayResults(string methodName, double[] solution, int iterations, List<double> residuals)
        {
            // Выводим решение
            resultsTextBox.AppendText($"{methodName}:\r\n");
            resultsTextBox.AppendText($"Решение: [{string.Join(", ", solution.Select(x => x.ToString("F6")))}]\r\n");
            resultsTextBox.AppendText($"Количество итераций: {iterations}\r\n");
            resultsTextBox.AppendText($"Достигнутая точность: {residuals.Last():E4}\r\n");
            resultsTextBox.AppendText("----------------------------------------\r\n");
        }

        private void PlotResiduals(List<double> residuals, string label, Color color)
        {
            GraphPane pane = zedGraphControl.GraphPane;

            // Создаем точки для графика
            PointPairList points = new PointPairList();
            for (int i = 0; i < residuals.Count; i++)
            {
                points.Add(i + 1, residuals[i]);
            }

            // Добавляем кривую на график
            LineItem curve = pane.AddCurve(label, points, color, SymbolType.Circle);
            curve.Line.IsSmooth = true;
            curve.Symbol.Fill = new Fill(color);
            curve.Symbol.Size = 4;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            matrixDataGridView.Rows.Clear();
            vectorTextBox.Clear();
            initialApproxTextBox.Text = "0";
            epsilonTextBox.Text = "0.0001";
            maxIterationsTextBox.Text = "1000";
            resultsTextBox.Clear();
            InitializeZedGraph();
            InitializeDefaultMatrix();
        }
    }
}