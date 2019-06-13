/*
 * Павленко Михаил
 * 
 * 2. Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в)**Добавьте обработку ситуации отсутствия файла на диске.
 * 
 */

using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10000, 10000);
            }

            PrintArr(arr);

            int result = StaticClass.CountDivByThree(arr);
            Console.WriteLine($"\nКол-во пар элементов массива, в которых только одно число делится на 3: {result}");

            Console.ReadKey();

            Console.WriteLine("\nЧитаем массив из файла");
            int[] arrFromFile = ArrayFromFile(@"Task2.txt");
            PrintArr(arrFromFile);

            Console.WriteLine("\nЧитаем не существующий файл");
            arrFromFile = ArrayFromFile(@"Task2_.txt");
            PrintArr(arrFromFile);

            Console.ReadKey();
        }
        static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        static int[] ArrayFromFile(string p)
        {
            try
            {
                StreamReader s = new StreamReader(p);
                int[] array = new int[int.Parse(s.ReadLine())]; // первое число в файле задает размерность массива
                int i = 0;
                while (!s.EndOfStream)
                {
                    string str = s.ReadLine();
                    int a = int.Parse(str);
                    array.SetValue(a, i);
                    i++;
                }
                s.Close();

                return array;
            }
            catch
            {
                Console.WriteLine("Файл не найден!");
                return new int[] { };
            }
        }
    }
}
