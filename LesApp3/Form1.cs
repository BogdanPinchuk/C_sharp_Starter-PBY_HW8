using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Розрахунок за вибраною операцією
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt1_Click(object sender, EventArgs e)
        {
            // Очищення області повідомлень
            tssl1.Text = string.Empty;

            #region Перевірка введених даних
            bool error = double.TryParse(tb1.Text.Replace(".", ","), out double a);

            if (!error)
            {
                tssl1.Text = "Невірний ввід даних!";
                tb3.Text = string.Empty;
                return;
            }

            error = double.TryParse(tb2.Text.Replace(".", ","), out double b);

            if (!error)
            {
                tssl1.Text = "Невірний ввід даних!";
                tb3.Text = string.Empty;
                return;
            }
            #endregion

            #region Виконання операції
            if (rb0.Checked)
            {
                // розрахунок залишку
                tb3.Text = DoMod(a, b).ToString("N2");
            }
            else if (rb1.Checked)
            {
                // степінь
                tb3.Text = Math.Pow(a, b).ToString("N2");
            }
            else if (rb2.Checked)
            {
                // ділення
                tb3.Text = DoDiv(a, b).ToString("N2");
            }
            #endregion

        }


        /// <summary>
        /// Частка чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private double DoDiv(double a, double b)
        {
            // перевірка на 0
            double temp = default;

            if (a == 0 && b == 0)
            {
                temp = double.NaN;
            }
            else if (a > 0 && b == 0)
            {
                temp = double.PositiveInfinity;
            }
            else if (a < 0 && b == 0)
            {
                temp = double.NegativeInfinity;
            }
            else
            {
                temp = a / b;
            }

            // вивід
            return temp;
        }

        /// <summary>
        /// Залишок від ділення
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private double DoMod(double a, double b)
        {
            // перевірка на 0
            double temp = default;

            if ((a == 0 && b == 0) ||
                (a > 0 && b == 0) ||
                (a < 0 && b == 0))
            {
                temp = double.NaN;
            }
            else
            {
                temp = a % b;
            }

            // вивід
            return temp;
        }

    }
}
