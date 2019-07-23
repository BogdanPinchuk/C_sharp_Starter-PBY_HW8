using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region Базові дані - дані з умови
            // дані користувача
            Console.WriteLine("Дані користувача:\n");

            // кількість платежів
            int nPay = 7;
            Console.WriteLine($"\tКількість платежів: {nPay:N0};");
            // базова платіжка 100 грн
            double pay = 100;
            Console.WriteLine($"\tБазова платіжка: {pay:N2} грн;");
            // пеня за просрочення виплати нехай буде 5%
            double fine = 5 / 100.0;
            Console.WriteLine($"\tПеня за просрочення виплати: {fine * 100:N0}%;");
            // сума до сплати 700 грн
            double sum = nPay * pay;
            Console.WriteLine($"\tCума до сплати: {sum:N2} грн;");
            #endregion

            // Розрахунок:
            AnalisePay(sum, pay, nPay, fine, 0, 0);

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Розрахунок погашення боргу
        /// </summary>
        /// <param name="borg">Сумарний борг</param>
        /// <param name="pay">Базова платіжка</param>
        /// <param name="nPay">Кількість платежів за які необхідно оплатити борг що залишився</param>
        /// <param name="fine">Пеня</param>
        /// <param name="oplata">Переплата або недоплата</param>
        /// <param name="numPay">Номер платежу</param>
        static void AnalisePay(double sum, double pay, int nPay,
            double fine, double oplata, int numPay)
        {
            // Перевірка номеру платежа
            if (numPay > nPay - 1 && sum > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nВсі платежі просрочені!!!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Необхідо визивати колекторів і заставити сплатити: {sum:N2} грн;");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }
            else if (sum == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВітаю, Вас і клієнта, кредит погашено!");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }
            else if (sum < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nВітаю, Вас і клієнта, кредит погашено!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Не забудьте повернути клієнту здачу в розмірі: {-sum:N2} грн");
                Console.ForegroundColor = ConsoleColor.Gray;
                return;
            }

            // Введення наних
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\tНомер платежа: {++numPay}");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"Борг до внесення оплати: {sum:N2} грн;");

            Console.Write("Внесена сума: ");
            bool error = double.TryParse(Console.ReadLine().Replace(".", ","), out double nowPay);
            if (!error || nowPay < 0)
            {
                AnaliseOfInputNumber(false);
            }

            // оновлення переплати/недоплати
            oplata = oplata * (1 + fine) - pay + nowPay;

            // перевірка недоплати і переплати + аналогічно 6-му уроку нарахування складних процентів
            if (oplata < 0)
            {
                Console.WriteLine($"Недоплата становить: {Math.Abs(oplata):N2} грн;");
            }
            else if (oplata > 0)
            {
                Console.WriteLine($"Переплата становить: {Math.Abs(oplata):N2} грн;");
            }

            // розрахунок суми до повної сплати
            sum -= nowPay + ((oplata < 0) ? (oplata * (1 + fine)) : 0);
            Console.WriteLine($"Борг після внесення оплати: {sum:N2} грн;");

            // перехід до наступного платежа
            AnalisePay(sum, pay, nPay, fine, oplata, numPay);
        }

        /// <summary>
        /// Умова коли невірно введені дані
        /// </summary>
        /// <param name="res"></param>
        static void AnaliseOfInputNumber(bool res)
        {
            if (!res)
            {
                Console.WriteLine("\nНевірно введені дані!");
                DoExitOrRepeat();
            }
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
