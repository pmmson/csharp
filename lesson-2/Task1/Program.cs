/* 
 * Павленко Михаил
 * 1. Написать метод, возвращающий минимальное из трех чисел
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static int Min3Numbers(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else { return c; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Поиск минимального значения из трех чисел");
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Минимальное число: {Min3Numbers(a, b, c)}");
            MyLib.Pause();
        }
    }
}
