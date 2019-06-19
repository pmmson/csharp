/*
 * Павленко Михаил
 * 
 * 3. Переделать программу ​Пример использования коллекций​для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) *отсортировать список по курсу и возрасту студента;
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        int c5 = 0;
        int c6 = 0;
        // int[] a = new int[100]; // предполагаем что больше 100 лет студентов нет
        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        ArrayList ages = new ArrayList();
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("students.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Console.WriteLine("{0}", s[0], s[1], s[2], s[3], s[4]);
                list.Add(s[1] + " " + s[0]); // Добавляем склееные имя и фамилию
                // ages.Add(int.Parse(s[5])); // считываем возраст студентов
                if (int.Parse(s[6]) < 5)
                {
                    bakalavr++;
                }
                else
                {
                    magistr++;
                    if (int.Parse(s[6]) == 5) c5++;
                    else if (int.Parse(s[6]) == 6) c6++;
                }
                //foreach(int val in ages)
                //{
                //    a[val]++;
                //}
            }
            catch
            {

            }
        }
        sr.Close();
        list.Sort();
        Console.WriteLine("Всего студентов:{0}", list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        foreach (var v in list) Console.WriteLine(v);
        Console.WriteLine("Студентов на 5 курсе: {0}, на 6: {1}", c5, c6);
        //foreach (var v in a) if (v != 0) Console.WriteLine(v);
        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);

        Console.ReadKey();
    }
}