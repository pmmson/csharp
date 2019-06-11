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

        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = -a[i];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 0, 10);
            MyArray b = new MyArray(5);
            Console.WriteLine(b.ToString());
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Max);
            Console.WriteLine(a.Min);
            Console.WriteLine(a.CountPositiv);
            Console.WriteLine(a.Sum);

            Console.ReadKey();
        }
    }
}
