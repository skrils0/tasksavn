using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AVMno2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateIntegral("?????? ???????????????");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateIntegral("??????????? ???????????????");
        }

        private void CalculateIntegral(string methodName)
        {
            double eps = 0;
            try
            {
                eps = Convert.ToDouble(textBox1.Text);
                if (eps <= 0)
                {
                    label11.Text = "??????! ???????? ?????? ???? ?????????????";
                    return;
                }
            }
            catch
            {
                label11.Text = "??????! ???????? ???? ????????";
                return;
            }

            double a = 0;
            double b = 1;
            try
            {
                a = Convert.ToDouble(textBox3.Text);
                b = Convert.ToDouble(textBox2.Text);
                if (a >= b)
                {
                    label11.Text = "??????! ????? ?????? ?????? ???? ?????? ???????";
                    return;
                }
            }
            catch
            {
                label11.Text = "??????! ???????? ???? ?????????";
                return;
            }

            functions selectedFunction = GetSelectedFunction();
            if (selectedFunction == null) return;

            try
            {
                int n = 0;
                double integralValue = 0;
                double h = 0;

                if (methodName == "?????? ???????????????")
                {
                    n = RungeRightRectangles(eps, a, b, selectedFunction);
                    h = (b - a) / n;
                    integralValue = RightRectangles(a, b, n, selectedFunction);
                }
                else if (methodName == "??????????? ???????????????")
                {
                    n = RungeCenterRectangles(eps, a, b, selectedFunction);
                    h = (b - a) / n;
                    integralValue = CenterRectangles(a, b, n, selectedFunction);
                }

                label3.Text = h.ToString("F6");
                label2.Text = n.ToString();
                label1.Text = integralValue.ToString("F8");
                label11.Text = $"?????: {methodName}\n" +
                              $"???????: {comboBox1.Text}\n" +
                              $"????????: [{a:F2}, {b:F2}]\n" +
                              $"????????: {eps}";
            }
            catch (Exception ex)
            {
                label11.Text = $"?????? ??????????: {ex.Message}";
            }
        }

        // ????? ?????? ???????????????
        public double RightRectangles(double a, double b, int n, functions f)
        {
            double h = (b - a) / n;
            double integral = 0;

            for (int i = 1; i <= n; i++)
            {
                double x = a + i * h; // ?????? ?????
                integral += f(x);
            }

            return integral * h;
        }

        // ????? ??????????? ???????????????
        public double CenterRectangles(double a, double b, int n, functions f)
        {
            double h = (b - a) / n;
            double integral = 0;

            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * h; // ??????????? ?????
                integral += f(x);
            }

            return integral * h;
        }

        // ??????? ????? ??? ?????? ?????? ??????????????? (??????? ???????? p = 1)
        public int RungeRightRectangles(double eps, double a, double b, functions func)
        {
            int n = 4;
            while (n <= 1000000)
            {
                double I_n = RightRectangles(a, b, n, func);
                double I_2n = RightRectangles(a, b, 2 * n, func);

                double error = Math.Abs(I_n - I_2n); // ??? ?????? 1-?? ???????

                if (error < eps)
                    return n;

                n *= 2;
            }
            return n;
        }

        // ??????? ????? ??? ?????? ??????????? ??????????????? (??????? ???????? p = 2)
        public int RungeCenterRectangles(double eps, double a, double b, functions func)
        {
            int n = 4;
            while (n <= 1000000)
            {
                double I_n = CenterRectangles(a, b, n, func);
                double I_2n = CenterRectangles(a, b, 2 * n, func);

                double error = Math.Abs(I_n - I_2n) / 3; // ??? ?????? 2-?? ???????

                if (error < eps)
                    return n;

                n *= 2;
            }
            return n;
        }

        public delegate double functions(double x);


        public double f1(double x) => Math.Exp(-x) * Math.Cos(x);
        public double f2(double x) => Math.Sqrt(1 + x * x);
        public double f3(double x) => Math.Sin(x) / x;
        public double f4(double x) => Math.Exp(-x * x);
        public double f5(double x) => Math.Pow(x, 1.5) * Math.Log(x + 1);
        public double f6(double x) => Math.Tan(x) / (1 + Math.Cos(x));

        private functions GetSelectedFunction()
        {
            switch (comboBox1.Text)
            {
                case "y = e^(-x)*cos(x)": return f1;
                case "y = sqrt(1+x^2)": return f2;
                case "y = sin(x)/x": return f3;
                case "y = e^(-x^2)": return f4;
                case "y = x^1.5*ln(x+1)": return f5;
                case "y = tan(x)/(1+cos(x))": return f6;
                default:
                    label11.Text = "??????: ???????? ???????";
                    return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            textBox2.Text = "2";
            textBox1.Text = "0.001";

            comboBox1.Items.AddRange(new string[] {
                "y = e^(-x)*cos(x)",
                "y = sqrt(1+x^2)",
                "y = sin(x)/x",
                "y = e^(-x^2)",
                "y = x^1.5*ln(x+1)",
                "y = tan(x)/(1+cos(x))"
            });
            comboBox1.SelectedIndex = 0;

        }
    }
}