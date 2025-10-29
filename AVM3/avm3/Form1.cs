using System;
using System.Linq;
using System.Windows.Forms;

namespace avm3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGrids();
            LoadExample1();
        }

        private void InitializeDataGrids()
        {
            int n = (int)sizeNumericUpDown.Value;
            SetupMatrixGrid(n);
            SetupVectorGrid(n);
        }

        private void SetupMatrixGrid(int n)
        {
            matrixDataGridView.Columns.Clear();
            matrixDataGridView.Rows.Clear();

            for (int i = 0; i < n; i++)
            {
                matrixDataGridView.Columns.Add($"col{i}", $"a{i}");
                matrixDataGridView.Columns[i].Width = 60;
            }

            for (int i = 0; i < n; i++)
            {
                matrixDataGridView.Rows.Add();
            }
        }

        private void SetupVectorGrid(int n)
        {
            vectorFDataGridView.Columns.Clear();
            vectorFDataGridView.Rows.Clear();

            vectorFDataGridView.Columns.Add("vectorCol", "f");
            vectorFDataGridView.Columns[0].Width = 60;

            for (int i = 0; i < n; i++)
            {
                vectorFDataGridView.Rows.Add();
            }
        }

        private double[,] GetMatrixFromGrid()
        {
            int n = (int)sizeNumericUpDown.Value;
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var cell = matrixDataGridView.Rows[i].Cells[j];
                    if (cell.Value != null && double.TryParse(cell.Value.ToString(), out double num))
                    {
                        matrix[i, j] = num;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }

        private double[] GetVectorFromGrid()
        {
            int n = (int)sizeNumericUpDown.Value;
            double[] vector = new double[n];

            for (int i = 0; i < n; i++)
            {
                var cell = vectorFDataGridView.Rows[i].Cells[0];
                if (cell.Value != null && double.TryParse(cell.Value.ToString(), out double num))
                {
                    vector[i] = num;
                }
                else
                {
                    vector[i] = 0;
                }
            }

            return vector;
        }

        private void DisplayResults(double[] solution, double[] residual)
        {
            solutionTextBox.Text = "??????? x:" + Environment.NewLine;
            for (int i = 0; i < solution.Length; i++)
            {
                solutionTextBox.Text += $"x[{i}] = {solution[i]:F6}" + Environment.NewLine;
            }

            residualTextBox.Text = "?????? ???????:" + Environment.NewLine;
            for (int i = 0; i < residual.Length; i++)
            {
                residualTextBox.Text += $"r[{i}] = {residual[i]:E6}" + Environment.NewLine;
            }
        }

        // ???????????? ????? ??????
        private double[] SolveGauss(double[,] A, double[] f)
        {
            int n = f.Length;
            double[,] matrix = (double[,])A.Clone();
            double[] vector = (double[])f.Clone();
            double[] x = new double[n];

            // ?????? ??? (??????????)
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    if (Math.Abs(matrix[k, k]) < 1e-15)
                    {
                        throw new Exception("??????? ???????????? ???????! ??????? ?????????.");
                    }

                    double factor = matrix[i, k] / matrix[k, k];
                    for (int j = k; j < n; j++)
                    {
                        matrix[i, j] -= factor * matrix[k, j];
                    }
                    vector[i] -= factor * vector[k];
                }
            }

            // ???????? ??? (???????????)
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < n; j++)
                {
                    sum += matrix[i, j] * x[j];
                }
                x[i] = (vector[i] - sum) / matrix[i, i];
            }

            return x;
        }

        // ????? ???????? ??? ???????????????? ??????
        private double[] SolveTridiagonal(double[,] A, double[] f)
        {
            int n = f.Length;

            double[] a = new double[n]; // ?????? ????????? (a[0] ?? ????????????)
            double[] b = new double[n]; // ??????? ?????????
            double[] c = new double[n]; // ??????? ????????? (c[n-1] ?? ????????????)
            double[] x = new double[n];

            // ?????????? ?????????? ?? ??????? A
            for (int i = 0; i < n; i++)
            {
                b[i] = A[i, i];
                if (i > 0) a[i] = A[i, i - 1];
                if (i < n - 1) c[i] = A[i, i + 1];
            }

            // ?????? ???
            double[] alpha = new double[n];
            double[] beta = new double[n];

            alpha[0] = c[0] / b[0];
            beta[0] = f[0] / b[0];

            for (int i = 1; i < n - 1; i++)
            {
                double denominator = b[i] - a[i] * alpha[i - 1];
                alpha[i] = c[i] / denominator;
                beta[i] = (f[i] - a[i] * beta[i - 1]) / denominator;
            }

            // ???????? ???
            x[n - 1] = (f[n - 1] - a[n - 1] * beta[n - 2]) / (b[n - 1] - a[n - 1] * alpha[n - 2]);

            for (int i = n - 2; i >= 0; i--)
            {
                x[i] = beta[i] - alpha[i] * x[i + 1];
            }

            return x;
        }

        private double[] CalculateResidual(double[,] A, double[] f, double[] x)
        {
            int n = f.Length;
            double[] residual = new double[n];

            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += A[i, j] * x[j];
                }
                residual[i] = sum - f[i];
            }

            return residual;
        }

        // ?????? 1: ????? ??????? 3×3 (???????: x = [2, 3, -1])
        private void LoadExample1()
        {
            sizeNumericUpDown.Value = 3;
            InitializeDataGrids();

            double[,] exampleMatrix = {
                { 2, 1, -1 },
                { -3, -1, 2 },
                { -2, 1, 2 }
            };

            double[] exampleVector = { 8, -11, -3 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixDataGridView.Rows[i].Cells[j].Value = exampleMatrix[i, j].ToString("F1");
                }
                vectorFDataGridView.Rows[i].Cells[0].Value = exampleVector[i].ToString("F1");
            }
        }

        // ?????? 2: ???????????????? ??????? 4×4
        private void LoadExample2()
        {
            sizeNumericUpDown.Value = 4;
            InitializeDataGrids();

            double[,] exampleMatrix = {
                { 4, 1, 0, 0 },
                { 1, 4, 1, 0 },
                { 0, 1, 4, 1 },
                { 0, 0, 1, 4 }
            };

            double[] exampleVector = { 5, 6, 6, 5 };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrixDataGridView.Rows[i].Cells[j].Value = exampleMatrix[i, j].ToString("F1");
                }
                vectorFDataGridView.Rows[i].Cells[0].Value = exampleVector[i].ToString("F1");
            }
        }

        // ?????? 3: ??????? ??????? 3×3 (???????: x = [1, 1, 1])
        private void LoadExample3()
        {
            sizeNumericUpDown.Value = 3;
            InitializeDataGrids();

            double[,] exampleMatrix = {
                { 2, 1, 1 },
                { 1, 3, 2 },
                { 1, 0, 1 }
            };

            double[] exampleVector = { 4, 6, 2 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixDataGridView.Rows[i].Cells[j].Value = exampleMatrix[i, j].ToString("F1");
                }
                vectorFDataGridView.Rows[i].Cells[0].Value = exampleVector[i].ToString("F1");
            }
        }

        // ??????????? ???????
        private void generateButton_Click(object sender, EventArgs e)
        {
            InitializeDataGrids();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            solutionTextBox.Clear();
            residualTextBox.Clear();
            InitializeDataGrids();
        }

        private void solveGaussButton_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] A = GetMatrixFromGrid();
                double[] f = GetVectorFromGrid();

                double[] x = SolveGauss(A, f);
                double[] residual = CalculateResidual(A, f, x);

                DisplayResults(x, residual);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?????? ??? ??????? ??????? ??????: {ex.Message}", "??????",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void solveTridiagonalButton_Click(object sender, EventArgs e)
        {
            try
            {
                double[,] A = GetMatrixFromGrid();
                double[] f = GetVectorFromGrid();

                // ???????? ?? ??????????????????
                int n = f.Length;
                bool isTridiagonal = true;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (Math.Abs(i - j) > 1 && Math.Abs(A[i, j]) > 1e-10)
                        {
                            isTridiagonal = false;
                            break;
                        }
                    }
                    if (!isTridiagonal) break;
                }

                if (!isTridiagonal)
                {
                    var result = MessageBox.Show("??????? ?? ???????? ????????????????! ????? ???????? ????? ???? ???????????? ??????????. ???????????",
                        "??????????????", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) return;
                }

                double[] x = SolveTridiagonal(A, f);
                double[] residual = CalculateResidual(A, f, x);

                DisplayResults(x, residual);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"?????? ??? ??????? ??????? ????????: {ex.Message}", "??????",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            InitializeDataGrids();
        }

        private void example1Button_Click(object sender, EventArgs e)
        {
            LoadExample1();
        }

        private void example2Button_Click(object sender, EventArgs e)
        {
            LoadExample2();
        }

        private void example3Button_Click(object sender, EventArgs e)
        {
            LoadExample3();
        }
    }
}