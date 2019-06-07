/*
 * Павленко Михаил
 * 
 * 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
 *       Продемонстрировать работу структуры;
 *    б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;
 *    в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex(double Re, double Im)
        {
            re = Re;
            im = Im;
        }

        public static Complex Plus(Complex z1, Complex z2)
        {
            return new Complex(z1.re + z2.re, z1.im + z2.im);
        }
        public static Complex Minus(Complex z1, Complex z2)
        {
            return new Complex(z1.re - z2.re, z1.im - z2.im);
        }
        public static Complex Multi(Complex z1, Complex z2)
        {
            return new Complex(z1.re * z2.re - z1.im * z2.im, z1.re * z2.im + z1.im * z2.re);
        }
        public string Print()
        {
            return (im < 0) ? re + "-" + Math.Abs(im) + "i" : re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 10;
            complex1.im = 15;
            
            Complex complex2;
            complex2.re = 20;
            complex2.im = 25;

            Console.WriteLine($"Демонстрация работы структуры Complex с комплексными числами z1={complex1.Print()} и z2={complex2.Print()}");

            Complex result = Complex.Plus(complex1, complex2);
            Console.WriteLine($"Результат сложения: {result.Print()}");

            result = Complex.Minus(complex1, complex2);
            Console.WriteLine($"Результат вычитания: {result.Print()}");

            result = Complex.Multi(complex1, complex2);
            Console.WriteLine($"Результат произведения: {result.Print()}");

            // работа с class ComplexClass

            // Описали ссылку на объект.
            ComplexClass z1;
            // Создали объект и сохранили ссылку на него в z1.
            z1 = new ComplexClass(10, 15);
            // Описали объект и создали его.
            ComplexClass z2 = new ComplexClass(20, 10);
            Console.WriteLine();
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            z2.Im = 25;
            
            Console.WriteLine($"Демонстрация работы класса ComplexClass с комплексными числами z1={z1.PrintComplexClass()} и z2={z2.PrintComplexClass()}");
            // Создали ссылку на объект.
            ComplexClass r;
            // Так как в методе Plus создается новый объект,
            // в r сохраняем ссылку на вновь созданный объект.
            Console.WriteLine("Для сложения нажмите - 1, для произведения нажмите - 2, для вычитания нажмите - 3, для выхода нажмите Enter");

            bool flag;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out int key);
                switch (key)
                {
                    case 1:
                        r = ComplexClass.Plus(z1, z2);
                        Console.WriteLine(r.PrintComplexClass());
                        break;
                    case 2:
                        r = ComplexClass.Multi(z1, z2);
                        Console.WriteLine(r.PrintComplexClass());
                        break;
                    case 3:
                        r = ComplexClass.Minus(z1, z2);
                        Console.WriteLine(r.PrintComplexClass());
                        break;
                    default:
                        Console.WriteLine("Неизвестный выбор. Повторите попытку.");
                        break;
                }
            } while (flag);
        }
    }
}
