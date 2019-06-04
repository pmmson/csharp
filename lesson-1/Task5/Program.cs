/* 
 * Павленко Михаил
 * 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
      б) * Сделать задание, только вывод организовать в центре экрана.
      в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Print(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            string s = "Михаил Павленко, Краснодар";
            Console.WriteLine(s);
            Console.ReadKey();
            Console.SetCursorPosition(45, 1);
            Console.WriteLine(s);
            Console.ReadKey();
            Print(s, 45, 2);

            Console.ReadKey();
        }
    }
}
