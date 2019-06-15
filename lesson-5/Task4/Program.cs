﻿/*
 * Павленко Михаил
 * 
 * 4. *Задача ЕГЭ.
 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
 * В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
 * <Фамилия> <Имя> <оценки>, где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, 
 * <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
 * <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
 * Иванов Петр 4 5 3
 * Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников. 
 * Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
 */

using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("ratings.txt");
            string[][] rates = new string[int.Parse(file[0])][];

            for (int i = 0; i < rates.Length; i++)
            {
                rates[i] = file[i + 1].Split(' ');
            }

            for (int i = 0; i < rates.Length; i++)
            {
                double avB1 = (int.Parse(rates[i][2]) + int.Parse(rates[i][3]) + int.Parse(rates[i][4])) / 3.0; // рассчитали средний балл текущего ученика
                string[] tmp = new string[rates[i].Length];
                for (int k = i; k < rates.Length; k++)
                {
                    double avB2 = (int.Parse(rates[k][2]) + int.Parse(rates[k][3]) + int.Parse(rates[k][4])) / 3.0; // рассчитываем балл каждого следующего
                    if (avB1 < avB2)
                    {
                        rates[k].CopyTo(tmp, 0);
                        rates[i].CopyTo(rates[k], 0);
                        tmp.CopyTo(rates[i], 0);
                        i = -1;
                        break;
                    }
                    else if (avB1 == avB2) continue;
                    else break;
                }
            }

            for (int i = 0; i < rates.Length; i++)
            {
                for (int j = 0; j < rates[i].Length; j++)
                {
                    Console.Write(rates[i][j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
