/*
 * Павленко Михаил
 * 
 * 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
         нужно ли человеку похудеть, набрать вес или всё в норме.
      б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task5
{
    class Program
    {
        static double BMI(double height, double weight)
        {
            return weight / (height * height);
        }

        static void CheckWeight(double height, double weight)
        {
            double bmi = BMI(height, weight);
            Console.WriteLine($"Индекс массы тела (BMI): {bmi:F2}");

            double bmiMin = 18.5;
            double bmiMax = 24.99;

            if (bmi <= bmiMin)
            {
                Console.WriteLine($"Вам нужно поправиться на {bmiMin * height * height - weight:F2} кг!");
            }
            else if (bmi >= bmiMax)
            {
                Console.WriteLine($"Вам нужно похудеть на {weight - bmiMax * height * height:F2} кг!");
            }
            else
            {
                Console.WriteLine($"Ваш вес в норме!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчитаем ваш индекс массы тела!");

            Console.Write("Введите рост(см): ");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Введите вес(кг): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            CheckWeight(height, weight);


            MyLib.Pause();
        }
    }
}
