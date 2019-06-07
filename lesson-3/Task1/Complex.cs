using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ComplexClass
    {
        // Поля приватные.
        private double im;
        // По умолчанию элементы приватные, поэтому private можно не писать.
        double re;

        // Конструктор без параметров.
        public ComplexClass()
        {
            re = 0;
            im = 0;
        }

        // Конструктор, в котором задаем поля.    
        // Специально создадим параметр re, совпадающий с именем поля в классе.
        public ComplexClass(double re, double _im)
        {
            // Здесь имена не совпадают, и компилятор легко понимает, что чем является.              
            im = _im;
            // Чтобы показать, что к полю нашего класса присваивается параметр,
            // используется ключевое слово this
            // Поле параметр
            this.re = re;
        }

        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static ComplexClass Plus(ComplexClass x1, ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = x1.re + x2.re;
            x3.im = x1.im + x2.im;
            
            return x3;
        }

        /// <summary>
        /// Метод нахождения разности комплексных чисел
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static ComplexClass Minus(ComplexClass x1, ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = x1.re - x2.re;
            x3.im = x1.im - x2.im;

            return x3;
        }

        // Свойства - это механизм доступа к данным класса.
        public double Im
        {
            get { return im; }
            set
            {
                // Для примера ограничимся только положительными числами.
                if (value >= 0) im = value;
            }
        }

        /// <summary>
        /// Метод нахождения произведения комплексных чисел
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static ComplexClass Multi(ComplexClass x1, ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.re = x1.re * x2.re - x1.im * x2.im;
            x3.im = x1.re * x2.im + x1.im * x2.re;

            return x3;
        }

        // Специальный метод, который возвращает строковое представление данных.
        public string PrintComplexClass()
        {
            return (im < 0) ? re + "" + im + "i" : re + "+" + im + "i";
        }
    }
}