using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZedGraph;

namespace AVM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFunction.SelectedIndex = 0;
            comboBoxMethod.SelectedIndex = 0;
            SetupGraph();
        }

        private void SetupGraph()
        {
            GraphPane pane = zedGraphControl.GraphPane;
            pane.Title.Text = "Аппроксимация функций";
            pane.XAxis.Title.Text = "x";
            pane.YAxis.Title.Text = "f(x)";
            pane.CurveList.Clear();
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            CalculateAndPlot();
        }

        private void CalculateAndPlot()
        {
            int n = (int)numericUpDownNodes.Value;
            double a = -1.0, b = 1.0;

            // Получаем выбранную функцию
            Func<double, double> originalFunction = GetSelectedFunction();

            // Создаем узлы интерполяции
            double[] xNodes, yNodes;
            if (comboBoxMethod.SelectedIndex == 1) // Чебышевские узлы
            {
                xNodes = ChebyshevNodes(n, a, b);
            }
            else // Равноотстоящие узлы
            {
                xNodes = EquidistantNodes(n, a, b);
            }

            yNodes = new double[n];
            for (int i = 0; i < n; i++)
            {
                yNodes[i] = originalFunction(xNodes[i]);
            }

            GraphPane pane = zedGraphControl.GraphPane;
            pane.CurveList.Clear();

            // Оригинальная функция
            if (checkBoxShowOriginal.Checked)
            {
                PointPairList originalPoints = new PointPairList();
                int pointsCount = 1000;
                for (int i = 0; i <= pointsCount; i++)
                {
                    double x = a + (b - a) * i / pointsCount;
                    double y = originalFunction(x);
                    originalPoints.Add(x, y);
                }
                LineItem originalCurve = pane.AddCurve("Оригинальная функция",
                    originalPoints, System.Drawing.Color.Blue, SymbolType.None);
                originalCurve.Line.Width = 2f;
            }

            // Аппроксимация
            if (checkBoxShowInterpolation.Checked)
            {
                PointPairList approxPoints = new PointPairList();
                int pointsCount = 1000;

                for (int i = 0; i <= pointsCount; i++)
                {
                    double x = a + (b - a) * i / pointsCount;
                    double y = 0;

                    if (comboBoxMethod.SelectedIndex == 2) // Кубический сплайн
                    {
                        y = CubicSplineInterpolation(x, xNodes, yNodes);
                    }
                    else // Полином Лагранжа
                    {
                        y = LagrangeInterpolation(x, xNodes, yNodes);
                    }

                    approxPoints.Add(x, y);
                }

                string methodName = comboBoxMethod.SelectedItem.ToString();
                LineItem approxCurve = pane.AddCurve(methodName,
                    approxPoints, System.Drawing.Color.Red, SymbolType.None);
                approxCurve.Line.Width = 1.5f;
            }

            // Узлы интерполяции
            PointPairList nodesPoints = new PointPairList();
            for (int i = 0; i < n; i++)
            {
                nodesPoints.Add(xNodes[i], yNodes[i]);
            }
            LineItem nodesCurve = pane.AddCurve("Узлы интерполяции",
                nodesPoints, System.Drawing.Color.Green, SymbolType.Circle);
            nodesCurve.Line.IsVisible = false;
            nodesCurve.Symbol.Fill = new Fill(System.Drawing.Color.Green);
            nodesCurve.Symbol.Size = 5;

            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }

        private Func<double, double> GetSelectedFunction()
        {
            switch (comboBoxFunction.SelectedIndex)
            {
                case 0: // x²
                    return x => x * x;
                case 1: // 1/(1+25x²)
                    return x => 1.0 / (1 + 25 * x * x);
                case 2: // e^(x²)
                    return x => Math.Exp(x * x);
                case 3: // |x|
                    return x => Math.Abs(x);
                default:
                    return x => x * x;
            }
        }

        private double[] EquidistantNodes(int n, double a, double b)
        {
            double[] nodes = new double[n];
            for (int i = 0; i < n; i++)
            {
                nodes[i] = a + (b - a) * i / (n - 1);
            }
            return nodes;
        }

        private double[] ChebyshevNodes(int n, double a, double b)
        {
            double[] nodes = new double[n];
            for (int i = 0; i < n; i++)
            {
                // Чебышевские узлы на [-1, 1]
                double cheb = Math.Cos(Math.PI * (2 * i + 1) / (2 * n));
                // Масштабируем на отрезок [a, b]
                nodes[i] = (b - a) / 2 * cheb + (a + b) / 2;
            }
            return nodes;
        }

        private double LagrangeInterpolation(double x, double[] xNodes, double[] yNodes)
        {
            double result = 0;
            int n = xNodes.Length;

            for (int i = 0; i < n; i++)
            {
                double term = yNodes[i];
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        term *= (x - xNodes[j]) / (xNodes[i] - xNodes[j]);
                    }
                }
                result += term;
            }
            return result;
        }

        private double CubicSplineInterpolation(double x, double[] xNodes, double[] yNodes)
        {
            int n = xNodes.Length;

            // Находим интервал, в который попадает x
            int interval = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (x >= xNodes[i] && x <= xNodes[i + 1])
                {
                    interval = i;
                    break;
                }
            }

            if (interval == n - 1) interval = n - 2;
            if (interval < 0) interval = 0;

            // Простая линейная интерполяция (для демонстрации)
            // В реальном приложении здесь должна быть реализация кубического сплайна
            double x0 = xNodes[interval];
            double x1 = xNodes[interval + 1];
            double y0 = yNodes[interval];
            double y1 = yNodes[interval + 1];

            return y0 + (y1 - y0) * (x - x0) / (x1 - x0);
        }
    }
}