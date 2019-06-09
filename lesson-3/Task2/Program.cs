/*
 * Павленко Михаил
 * 
 * 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
 *    Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse
 *    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string msg = "Введите число: ";
            string s = "";
            int sum = 0;
            bool f;

            do
            {
                Console.Write(msg);
                f = int.TryParse(Console.ReadLine(), out n);
                
                if (n == 0) break;
                if (n % 2 != 0 && n > 0)
                {
                    s = s + n + " ";
                    sum += n;
                }
            } while (f);

            Console.WriteLine($"\nПоложительные нечетные числа: {s}");
            Console.WriteLine($"Сумма чисел равна: {sum}");

            Console.ReadKey();
        }
    }
}
