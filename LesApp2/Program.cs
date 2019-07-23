using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// не рекомендується використовувати рекурсію, так як
// це одна із 8 критичних помилок, що призводить до переповнення стека
// а після помилки процес убивається

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Введення даних
            Console.Write("\nКількість клієнтів: ");

            // перевірка правильності вводу
            bool error = int.TryParse(Console.ReadLine(), out int cust);
            // аналіз чи можна далі продовжувати 
            if (!error || cust <= 0)
            {
                AnaliseOfInputNumber(false);
            }

# if true   // не рекомендований варіант
            Console.WriteLine("\nНе рекомендований варіант");
            Console.WriteLine($"Кількість можливих варіантів доставки: {FactorialNR(cust):N0}");
#endif

#if true    // рекомендований варіант
            
            Console.WriteLine("\nРекомендований варіант");
            Console.WriteLine($"Кількість можливих варіантів доставки: {FactorialR(cust):N0}");
#endif


            // повторення
            DoExitOrRepeat();
        }


        /// <summary>
        /// Розрахунок факторіалу, не рекомендований варіант
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        static int FactorialNR(int f)
        {
            if (f < 2)
            {
                return 1;
            }
            else
            {
                return f * FactorialNR(--f);
            }
        }

        /// <summary>
        /// Розрахунок факторіалу, рекомендований варіант
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        static int FactorialR(int f)
        {
            double factor;

            // формула Стірлінга і Рамануджана https://uk.wikipedia.org/wiki/Факторіал
            if (f > 1)
            {
                factor = Math.Sqrt(2 * Math.PI * f) * Math.Pow(f / Math.E, f) *
                    Math.Exp((1 / (12.0 * f)) - (1 / (360.0 * f * f * f)));
            }
            else
            {
                factor = 1;
            }

            // необхідно округлювати так як є проблеми з точністю
            return (int)Math.Round(factor, MidpointRounding.AwayFromZero);
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
