/*
 * Павленко Михаил
 * 
 * 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
      где m — масса тела в килограммах, h — рост в метрах.

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("Рассчитаем ваш индекс массы телы!");
            Console.Write("Введите рост(см): ");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес(кг): ");
            double weight = Convert.ToInt32(Console.ReadLine());
            height = height / 100;
            double bmi = weight / (height * height);
            Console.WriteLine($"Индекс массы тела (BMI): {bmi:F2}");
            Console.ReadKey();
        }
    }
}