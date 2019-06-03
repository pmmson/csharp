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
            height = height / 100;
            return weight / (height * height);
        }
        
        static double CheckWeight(double height, double weight)
        {
            double bmi = BMI(height, weight);
            height = height / 100;
            double bmiMin = 18.5;
            double bmiMax = 24.99;

            if (bmi <= bmiMin)
            {
                return weight - bmiMin * height * height;
            }
            else if (bmi >= bmiMax)
            {
                return weight - bmiMax * height * height;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчитаем ваш индекс массы тела!");

            Console.Write("Введите рост(см): ");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес(кг): ");
            double weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Индекс массы тела (BMI): {BMI(height, weight):F2}");

            double check = CheckWeight(height, weight);
            Console.WriteLine($"Вам нужно поправиться на {deltaWeight:F2} кг!");

            Console.WriteLine($"Вам нужно похудеть на {deltaWeight:F2} кг!");

            Console.WriteLine($"Ваш вес в норме!");




            MyLib.Pause();
        }
    }
}
