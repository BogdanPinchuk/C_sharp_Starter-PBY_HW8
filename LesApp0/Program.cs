using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Підтримка Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region Задання чисел
            // Оскільки не вказано, що це має вводити користувач, виберемо числа рандомно
            Random rnd = new Random();

            // Заголовок
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Задані випадкові цілі числа:");
            Console.ForegroundColor = ConsoleColor.Gray;

            // масив для введених даних
            int[] a = new int[3];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(short.MinValue, short.MaxValue);
                Console.Write($"\ta{i} = {a[i]:N0}\n");
            }
            #endregion

            #region Ділення з остачею
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nДілення на 5:");
                Console.ForegroundColor = ConsoleColor.Gray;
                double[] temp = Calculate(a);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"\ta{i} = {temp[i]:N2}\n");
                }
            }
            #endregion

            #region Дідення без остачі
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nДілення на 5 без остачі:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Calculate(ref a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"\ta{i} = {a[i]:N0}\n");
            }
            #endregion

            // повторення
            DoExitOrRepeat();
        }

        /// <summary>
        /// Ділення чисел на 5 без остачі
        /// </summary>
        /// <param name="m">масив чисел</param>
        static void Calculate(ref int[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                m[i] /= 5;
            }
        }

        /// <summary>
        /// Ділення чисел на 5
        /// </summary>
        /// <param name="m">масив чисел</param>
        /// <returns>результат ділення на 5</returns>
        static double[] Calculate(int[] m)
        {
            // створення змінної для розрахунку дійсних чисел
            double[] res = new double[m.Length];

            // ділення на 5
            for (int i = 0; i < m.Length; i++)
            {
                res[i] = m[i] / 5.0;
            }

            return res;
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\nСпробувати ще раз: [т, н]");
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

