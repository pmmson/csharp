/*
 * Павленко Михаил
 * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум через параметр (с использованием модификатора out).
 * 
 */

using System;
using System.IO;

namespace Task2
{
    public delegate double Function(double x);
    class Program
    {
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return 3 * x * x - 5 * x + 10;
        }
        public static double F3(double x)
        {
            return x * x * x + x - 3;
        }
        public static double F4(double x)
        {
            return Math.Sin(x * x  - 3 * x);
        }

        public static double F5(double x)
        {
            return 3 * Math.Pow(x, 5) - 20 * Math.Pow(x, 3) - 54;
        }
        public static void SaveFunc(Function X, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(X(x));
                x += h;

            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            double[] arrayD = new double[fs.Length / sizeof(double)];  // наш возвращаемый массив
            for (int i = 0; i < fs.Length / sizeof(double); i++)  // fs.Length / sizeof(double) ?
            {
                d = bw.ReadDouble();
                arrayD[i] = d;  // заносим считанное значение в наш массив
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return arrayD;
        }
        static void Main(string[] args)
        {
            Function[] ArrayFunctions = new Function[]
            {
                F1, F2, F3, F4, F5
            };

            Console.WriteLine("Программа поиска минимума функции на выбранном интервале");
            Console.Write("x^2 - 50x + 10\t\t=> 1\n3x^2 - 5x + 10\t\t=> 2\nx^3 + x - 3\t\t=> 3\nsin(x^2 - 3x)\t\t=> 4\n3x^5 - 20x^3 - 54\t=> 5\n");
            bool flag;
            do
            {
                Console.Write("Пожалуйста выбирете функцию (введите номер меню, для выхода введите 0 или Enter): ");
                flag = int.TryParse(Console.ReadLine(), out int key);
                if (!flag || key == 0) break;
                else if (key > ArrayFunctions.Length) { Console.WriteLine($"К сожалению, функции {key} нет в моей памяти..."); continue; }
                Console.Write("введите интервал поиска минимума\nот: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("до: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("введите шаг поиска минимума: ");
                double h = Convert.ToDouble(Console.ReadLine());
                double[] arrayD = Load("data.bin", out double minFunction); // возвращаем минимум и массив считанных значений
                string output = $"\nминимум ф-ии {key} на выбранном интервале: {minFunction}";
                for (int i = 0; i < arrayD.Length; i++)
                {
                    Console.Write($"{arrayD[i]} ");
                }
                switch (key)
                {
                    case 1:
                        SaveFunc(ArrayFunctions[key - 1], "data.bin", a, b, h);
                        Console.WriteLine(output);
                        continue;
                    case 2:
                        SaveFunc(ArrayFunctions[key - 1], "data.bin", a, b, h);
                        Console.WriteLine(output);
                        continue;
                    case 3:
                        SaveFunc(ArrayFunctions[key - 1], "data.bin", a, b, h);
                        Console.WriteLine(output);
                        continue;
                    case 4:
                        SaveFunc(ArrayFunctions[key - 1], "data.bin", a, b, h);
                        Console.WriteLine(output);
                        continue;
                    case 5:
                        SaveFunc(ArrayFunctions[key - 1], "data.bin", a, b, h);
                        Console.WriteLine(output);
                        continue;
                    default:
                        continue;
                }
            }
            while (flag);
        }
    }
}