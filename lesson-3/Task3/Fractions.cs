using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Fractions
    {
        int _p; // числитель
        int _q = 1; // знаменатель

        /// <summary>
        /// Обыкновенная дробь p/q
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public Fractions(int p, int q)
        {
            _p = p;
            if (q == 0) { throw new ArgumentException("Знаменатель не может быть равен 0"); }
            else { _q = q; }
        }
        /// <summary>
        /// Доступ к изменению числителя
        /// </summary>
        public int P
        {
            get { return _p; }
            set { _p = value; }
        }
        /// <summary>
        /// Доступ к изменению знаменателя
        /// </summary>
        public int Q
        {
            get { return _q; }
            set
            {
                if (value == 0) { throw new ArgumentException("Знаменатель не может быть равен 0"); }
                else { _q = value; }
            }
        }
        /// <summary>
        /// Десятичное представление обыкновенной дроби
        /// </summary>
        public double DecimalFraction
        {
            get { return (double)_p / _q; }
        }
        /// <summary>
        /// Метод печати обыкновенной дроби в формате p/q
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public static string ToString(Fractions z)
        {
            if (z._p == 0) return "0";
            else return $"{z._p}/{z._q}";
        }

        /// <summary>
        /// Метод сложения обыкновенных дробей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fractions AddFractions(Fractions a, Fractions b)
        {
            return new Fractions(a._p * (NOK(a._q, b._q) / a._q) + b._p * (NOK(a._q, b._q) / b._q), NOK(a._q, b._q));
        }

        /// <summary>
        /// Метод вычитания обыкновенных дробей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fractions SubFractions(Fractions a, Fractions b)
        {
            return new Fractions(a._p * (NOK(a._q, b._q) / a._q) - b._p * (NOK(a._q, b._q) / b._q), NOK(a._q, b._q));
        }
        /// <summary>
        /// Метод умножения обыкновенных дробей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fractions MultiFractions(Fractions a, Fractions b)
        {
            return new Fractions(a._p * b._p, a._q * b._q);
        }
        /// <summary>
        /// Метод деления обыкновенных дробей
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Fractions DivFractions(Fractions a, Fractions b)
        {
            return new Fractions(a._p * b._q, a._q * b._p);
        }

        static int NOD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return a + b;
        }

        static int NOK(int a, int b)
        {
            return a * b / NOD(a, b);
        }
    }
}
