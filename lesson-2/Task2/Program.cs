/*
 * Павленко Михаил
 * 2. Написать метод подсчета количества цифр числа
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task2
{
    class Program
    {
        static int CountOfNumbersInNumber(long a)
        {
            int i = 0;
            while (a != 0)
            {
                a = a / 10;
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчитаем количество цифр в числе");
            Console.Write("Введите число: ");
            long a = Convert.ToInt64(Console.ReadLine());
            Console.Write($"Количетсво цифр в числе {a}: {CountOfNumbersInNumber(a)}");

            MyLib.Pause();
        }
    }
}
