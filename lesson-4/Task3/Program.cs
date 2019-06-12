/*
 * Павленко Михаил
 * 
 * 3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив определенного размера
 * и заполняющий массив числами от начального значения с заданным шагом. Создать свойство Sum, которое возвращает сумму 
 * элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива 
 * (старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, 
 * свойство MaxCount, возвращающее количество максимальных элементов.
 * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 * е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 * 
 */

using System;
namespace ArrayClass
{
    class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        //  Создание массива и заполнение его числами от 3 с заданным шагом
        public MyArray(int step)
        {
            a = new int[15];
            a[0] = 3;
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        //public int this[int i]
        //{
        //    get { return a[i]; }
        //    set { a[i] = value; }
        //}

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int MaxCount
        {
            get
            {
                int count = 0;
                for (int i = 1; i < a.Length; i++)
                    if (a[i - 1] >= a[i]) count++;
                return count;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }

        public int[] Inverse()
        {
            int[] x = new int[a.Length];
            a.CopyTo(x, 0);
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * -1;
            return x;
        }
        public int[] Multi(int n)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] * n;
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, -5, 5);
            MyArray b = new MyArray(7, 3);
            MyArray c = new MyArray(9);
            Console.WriteLine($"Массив заполненный одним элементом: {b.ToString()}");
            Console.WriteLine($"Массив с заданным шаговым значением: {c.ToString()}");
            Console.WriteLine($"\nМассив: {a.ToString()}");
            Console.WriteLine($"Максимальное число массива: {a.Max}");
            Console.WriteLine($"Минимальное число массива: {a.Min}");
            Console.WriteLine($"Кол-во положительных чисел в массиве: {a.CountPositiv}");
            Console.WriteLine($"Сумма чисел в массиве: {a.Sum}");

            int[] z = a.Inverse();
            Console.WriteLine($"\nИнверсия массива:\n{a.ToString()}");
            for (int i = 0; i < z.Length; i++)
            {
                Console.Write($"{z[i]} ");
            }

            a.Multi(4);
            Console.WriteLine($"\nМассив каждый элемент умноженный на 4:\n{a.ToString()}");
            Console.WriteLine($"Количество максимальных элементов в массиве: {a.MaxCount}");

            Console.ReadKey();
        }
    }
}
