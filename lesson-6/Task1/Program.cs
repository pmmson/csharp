/*
 * Павленко Михаил
 * 
 * 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate double Fun(double a, double x);
    class Program
    {
        public static void Table(Fun F, double a, double min, double max)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (min <= max)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", min, F(a, min));
                min++;
                Console.WriteLine("---------------------");
            }
        }

        public static double MyFunc1(double a, double x)
        {
            return a * x * x;
        }

        public static double MyFunc2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(MyFunc1, 10, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(MyFunc2, 10, -2, 2);

            Console.ReadKey();
        }
    }
}