/*
 * Павленко Михаил
 * 
 * 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчитаем сумму всех введеных нечётных положительных чисел");
            Console.WriteLine("Для выхода введите \"0\" !");
            Console.WriteLine($"Сумма всех введеных нечётных положительных чисел: {SumOfOddNumbers()}");

            MyLib.Pause();
        }

        private static int SumOfOddNumbers()
        {
            int i;
            int sum = 0;
            do
            {
                Console.Write("Введите число: ");
                i = Convert.ToInt32(Console.ReadLine());
                if (i > 0 && i % 2 != 0)
                {
                    sum += i;
                }
            }
            while (i != 0);
            return sum;
        }
    }
}
