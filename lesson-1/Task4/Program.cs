/*
 * Павленко Михаил
 * 4. Написать программу обмена значениями двух переменных:
        а) с использованием третьей переменной;
	    б) *без использования третьей переменной.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4");
            Console.Write("Введите первую переменную: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую переменную: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a={a}; b={b}");
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine($"a={a}; b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a={a}; b={b}");

            Console.ReadKey();
        }
    }
}
