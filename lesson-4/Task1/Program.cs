/*
 * Павленко Михаил
 * 
 * 1. Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
 * Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, 
 * в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. 
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
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

            //int[] arr = { 6, 2, 9, -3, 6 }; //for test
            int count = 0;
            if (arr.Length % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i += 2)
                {
                    if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    {
                        count++;
                        //Console.Write($"\n({arr[i]}, {arr[i+1]})");
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length - 1; i += 2)
                {
                    if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    {
                        count++;
                        //Console.Write($"\n({arr[i]}, {arr[i + 1]})");
                    }
                }
            }

            PrintArr(arr);
            Console.WriteLine($"\nКол-во пар элементов массива, в которых только одно число делится на 3: {count}");

            Console.ReadKey();
        }

        static void PrintArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
    }
}
