/*
 * Павленко Михаил
 * 
 * 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        а) используя  склеивание;
	    б) используя форматированный вывод;
	    в) используя вывод со знаком $.
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
            Console.WriteLine("Задание 1");
            Console.WriteLine("Пожалуйста последовательно введите");
            Console.Write("имя: ");
            string name = Console.ReadLine();
            Console.Write("фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("рост(см): ");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.Write("вес(кг): ");
            double weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(name + " " + surname + ": возраст: " + age + ", рост: " + height + " см, вес: " + weight + " кг.");
            Console.WriteLine("{0} {1}: возраст: {2}, рост: {3} см, вес: {4} кг.", name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname}: возраст: {age}, рост: {height} см, вес: {weight} кг.");

            Console.ReadKey();
        }
    }
}