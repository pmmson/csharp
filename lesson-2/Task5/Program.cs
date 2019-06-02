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
        static void Main(string[] args)
        {
            Console.WriteLine("Рассчитаем ваш индекс массы тела!");
            Console.Write("Введите рост(см): ");
            double height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес(кг): ");
            double weight = Convert.ToInt32(Console.ReadLine());
            height = height / 100;
            double bmi = weight / (height * height);
            Console.WriteLine($"Индекс массы тела (BMI): {bmi:F2}");
            double bmiMin = 18.5;
            double bmiMax = 24.99;
            double deltaWeight;

            if (bmi <= bmiMin)
            {
                deltaWeight = bmiMin * height * height - weight;
                Console.WriteLine($"У вас дефицит массы тела. Вам нужно набрать вес на {deltaWeight:F2} кг!");
            }
            else if (bmi >= bmiMax)
            {
                deltaWeight = weight - bmiMax * height * height;
                Console.WriteLine($"Избыточная масса тела. Вам нужно похудеть на {deltaWeight:F2} кг!");
            }
            else
            {
                Console.WriteLine($"Ваш вес {weight:F2} кг в норме!");
            }
            
            

            MyLib.Pause();
        }
    }
}
