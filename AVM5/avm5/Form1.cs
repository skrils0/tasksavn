using System;
using System.Windows.Forms;
using System.Data;

namespace avm5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateMatrix();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            GenerateMatrix();
        }

        private void GenerateMatrix()
        {
            int size = (int)sizeNumericUpDown.Value;
            matrixDataGridView.Columns.Clear();
            matrixDataGridView.Rows.Clear();

            // Создаем столбцы
            for (int i = 0; i < size; i++)
            {
                matrixDataGridView.Columns.Add($"col{i}", $"a{i + 1}");
                matrixDataGridView.Columns[i].Width = 50;
            }

            // Создаем строки и заполняем случайными значениями
            matrixDataGridView.Rows.Add(size);
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixDataGridView.Rows[i].Cells[j].Value = rand.Next(-10, 11).ToString();
                }
            }
        }

        private double[,] GetMatrixFromGrid()
        {
            int size = matrixDataGridView.Rows.Count;
            double[,] matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    string value = matrixDataGridView.Rows[i].Cells[j].Value?.ToString();
                    if (string.IsNullOrEmpty(value))
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = double.Parse(value);
                    }
                }
            }
            return matrix;
        }

        private void powerIterationButton_Click(object sender, EventArgs e)
        {
            try
            {
                double epsilon = double.Parse(epsilonTextBox.Text);
                double[,] matrix = GetMatrixFromGrid();
                int size = matrix.GetLength(0);

                // Метод прямой итерации (степенной метод)
                double[] eigenvector = new double[size];
                for (int i = 0; i < size; i++)
                    eigenvector[i] = 1.0;

                double eigenvalue = 0;
                double prevEigenvalue = 0;
                int iterations = 0;
                double error = double.MaxValue;

                while (error > epsilon && iterations < 1000)
                {
                    // Умножаем матрицу на вектор
                    double[] newVector = MultiplyMatrixVector(matrix, eigenvector);

                    // Находим максимальный элемент (приближение собственного значения)
                    double maxElement = 0;
                    for (int i = 0; i < size; i++)
                    {
                        if (Math.Abs(newVector[i]) > Math.Abs(maxElement))
                            maxElement = newVector[i];
                    }

                    // Нормализуем вектор
                    for (int i = 0; i < size; i++)
                        eigenvector[i] = newVector[i] / maxElement;

                    prevEigenvalue = eigenvalue;
                    eigenvalue = maxElement;

                    if (iterations > 0)
                        error = Math.Abs(eigenvalue - prevEigenvalue);

                    iterations++;
                }

                resultsTextBox.Text = $"МЕТОД ПРЯМОЙ ИТЕРАЦИИ:\r\n";
                resultsTextBox.Text += $"Наибольшее собственное число: {eigenvalue:F6}\r\n";
                resultsTextBox.Text += $"Количество итераций: {iterations}\r\n";
                resultsTextBox.Text += $"Точность: {epsilon}\r\n";
                resultsTextBox.Text += $"Собственный вектор: [";
                for (int i = 0; i < size; i++)
                    resultsTextBox.Text += $" {eigenvector[i]:F4} ";
                resultsTextBox.Text += "]";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rotationMethodButton_Click(object sender, EventArgs e)
        {
            try
            {
                double epsilon = double.Parse(epsilonTextBox.Text);
                double[,] matrix = GetMatrixFromGrid();
                int size = matrix.GetLength(0);

                // Метод вращений Якоби
                double[,] A = (double[,])matrix.Clone();
                double[,] eigenvectors = CreateIdentityMatrix(size);
                int iterations = 0;
                double maxOffDiagonal = double.MaxValue;

                while (maxOffDiagonal > epsilon && iterations < 1000)
                {
                    maxOffDiagonal = 0;
                    int p = 0, q = 0;

                    // Находим максимальный внедиагональный элемент
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = i + 1; j < size; j++)
                        {
                            if (Math.Abs(A[i, j]) > maxOffDiagonal)
                            {
                                maxOffDiagonal = Math.Abs(A[i, j]);
                                p = i;
                                q = j;
                            }
                        }
                    }

                    if (maxOffDiagonal <= epsilon)
                        break;

                    // Вычисляем угол вращения
                    double theta = 0.5 * Math.Atan2(2 * A[p, q], A[q, q] - A[p, p]);
                    double cosTheta = Math.Cos(theta);
                    double sinTheta = Math.Sin(theta);

                    // Обновляем матрицу A
                    double[,] newA = (double[,])A.Clone();

                    for (int i = 0; i < size; i++)
                    {
                        if (i != p && i != q)
                        {
                            newA[p, i] = A[p, i] * cosTheta - A[q, i] * sinTheta;
                            newA[i, p] = newA[p, i];
                            newA[q, i] = A[q, i] * cosTheta + A[p, i] * sinTheta;
                            newA[i, q] = newA[q, i];
                        }
                    }

                    newA[p, p] = A[p, p] * cosTheta * cosTheta + A[q, q] * sinTheta * sinTheta - 2 * A[p, q] * cosTheta * sinTheta;
                    newA[q, q] = A[p, p] * sinTheta * sinTheta + A[q, q] * cosTheta * cosTheta + 2 * A[p, q] * cosTheta * sinTheta;
                    newA[p, q] = newA[q, p] = 0;

                    A = newA;

                    // Обновляем матрицу собственных векторов
                    double[,] newEigenvectors = (double[,])eigenvectors.Clone();
                    for (int i = 0; i < size; i++)
                    {
                        newEigenvectors[i, p] = eigenvectors[i, p] * cosTheta - eigenvectors[i, q] * sinTheta;
                        newEigenvectors[i, q] = eigenvectors[i, p] * sinTheta + eigenvectors[i, q] * cosTheta;
                    }
                    eigenvectors = newEigenvectors;

                    iterations++;
                }

                // Получаем собственные значения из диагонали
                double[] eigenvalues = new double[size];
                for (int i = 0; i < size; i++)
                    eigenvalues[i] = A[i, i];

                resultsTextBox.Text = $"МЕТОД ВРАЩЕНИЙ:\r\n";
                resultsTextBox.Text += $"Количество итераций: {iterations}\r\n";
                resultsTextBox.Text += $"Точность: {epsilon}\r\n";
                resultsTextBox.Text += $"Собственные числа:\r\n";
                for (int i = 0; i < size; i++)
                    resultsTextBox.Text += $"λ{i + 1} = {eigenvalues[i]:F6}\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double[] MultiplyMatrixVector(double[,] matrix, double[] vector)
        {
            int size = vector.Length;
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i] += matrix[i, j] * vector[j];
                }
            }

            return result;
        }

        private double[,] CreateIdentityMatrix(int size)
        {
            double[,] identity = new double[size, size];
            for (int i = 0; i < size; i++)
                identity[i, i] = 1.0;
            return identity;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultsTextBox.Clear();
        }
    }
}