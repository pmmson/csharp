/*
 * Павленко Михаил
 * 
 * 3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
 *     Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
 *     Добавить свойства типа int для доступа к числителю и знаменателю;
 *     Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
 *     ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 *     *** Добавить упрощение дробей.
 *     
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обыкновенные Дроби");
            try
            {
                int a, b, c, d;

                Console.Write("Введите числитель первой дроби: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знаменатель первой дроби: ");
                b = Convert.ToInt32(Console.ReadLine());
                Fractions a1 = new Fractions(a, b);
                string a1String = Fractions.ToString(a1);

                Console.Write("Введите числитель второй дроби: ");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знаменатель второй дроби: ");
                d = Convert.ToInt32(Console.ReadLine());
                Fractions a2 = new Fractions(c, d);
                string a2String = Fractions.ToString(a2);

                Fractions add = Fractions.AddFractions(a1, a2);
                string addString = Fractions.ToString(add);
                Fractions sub = Fractions.SubFractions(a1, a2);
                string subString = Fractions.ToString(sub);
                Fractions multi = Fractions.MultiFractions(a1, a2);
                string multiString = Fractions.ToString(multi);
                Fractions div = Fractions.DivFractions(a1, a2);
                string divString = Fractions.ToString(div);

                Console.WriteLine("\n1. Арифметические методы работы с дробями");
                Console.WriteLine($"Cложение:\t{a1String}+{a2String}={addString}");
                Console.WriteLine($"Вычитание:\t{a1String}-{a2String}={subString}");
                Console.WriteLine($"Умножение:\t{a1String}*{a2String}={multiString}");
                Console.WriteLine($"Деление:\t{a1String}:{a2String}={divString}");
                Enter();

                Console.WriteLine("2. Демонстрация доступа к числителю и знаменателю");
                Fractions a3 = new Fractions(a1.P, a1.Q);
                Console.WriteLine($"до изменения:\t {Fractions.ToString(a3)}");
                Console.Write("Введите числитель новой дроби: ");
                a3.P = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите знаменатель новой дроби: ");
                a3.Q = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"   после:\t {Fractions.ToString(a3)}");
                Enter();

                Console.WriteLine("3. Десятичные дроби чисел:");
                Console.WriteLine($"{a1String}={a1.DecimalFraction}");
                Console.WriteLine($"{a2String}={a2.DecimalFraction}");
                Console.WriteLine($"{addString}={add.DecimalFraction}");
                Console.WriteLine($"{subString}={sub.DecimalFraction}");
                Console.WriteLine($"{multiString}={multi.DecimalFraction}");
                Console.WriteLine($"{divString}={div.DecimalFraction}");
                Console.WriteLine($"{Fractions.ToString(a3)}={a3.DecimalFraction}");
                Enter();
            }
            catch (ArgumentException e) { Console.WriteLine($"{e.GetType().Name}: {e.Message}"); Enter(); }
        }

        static void Enter()
        {
            Console.WriteLine("\nДля продолжения нажмите Enter\n");
            Console.ReadKey();
        }
    }
}
