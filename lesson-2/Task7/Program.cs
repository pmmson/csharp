/*
 * Павленко Михаил
 * 
 * 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
      б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task7
{
    class Program
    {
        static void PrintA2B(int a, int b)
        {
            Console.Write(a + " ");
            if (a < b)
            {
                PrintA2B(a + 1, b);
            }
        }

        static int SumA2B(int a, int b)
        {
            if (a < b)
            {
                a = a + SumA2B(a + 1, b);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выведем числа от a до b (a < b) и посчитаем их сумму");
            Console.Write("Введите a: "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите b: "); int b = Convert.ToInt32(Console.ReadLine());
            PrintA2B(a, b);
            int sum = SumA2B(a, b);
            Console.WriteLine($"\n{sum}");

            MyLib.Pause();
        }
    }
}
