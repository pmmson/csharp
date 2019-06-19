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
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        int c5 = 0;
        int c6 = 0;

        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        int[] courses = new int[6];
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
                if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                {
                    courses[int.Parse(s[6]) - 1]++;
                }
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
        for (int i = 0; i < courses.Length; i++) Console.Write($"Кол-во студентов в возрасте от 18 до 20 на {i + 1} курсе: {courses[i]}\n");
        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);

        Console.ReadKey();
    }
}