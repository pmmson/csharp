/*
 * Павленко Михаил
 * 
 * 6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
      «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени 
      выполнения программы, используя структуру DateTime.
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task6
{
    class Program
    {
        static int GoodNumbers(int a, int b)
        {
            int i = 0;  //счетчик "хороших" чисел
            while (a <= b)
            {
                if (a % SumNumbers(a) == 0)
                {
                    //Console.Write($"{a} "); //для вывода списка чисел
                    i++;
                }
                a++; //переходим к следующему числу
            }
            return i;
        }
        static int SumNumbers(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum = sum + n % 10; //получаем последнюю цифру
                n = n / 10; //отбрасываем последнюю цифру
            }
            return sum;
        }
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Console.WriteLine($"\nКол-во 'хороших' чисел в диапазоне от 1 до 1 000 000 000: {GoodNumbers(1, 1000000000):N0}");
            Console.WriteLine(DateTime.Now - start);    //~3,5 мин для 1 000 000 000

            MyLib.Pause();
        }
    }
}
