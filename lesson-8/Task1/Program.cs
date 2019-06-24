/*
 * Павленко Михаил
 * 
 * 1. С помощью рефлексии выведите все свойства структуры DateTime
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(DateTime);
            Console.WriteLine("Properties DateTime:\n");
            PropertyInfo[] pInfos = t.GetProperties();
            foreach (PropertyInfo pInfo in pInfos)
            {
                Console.WriteLine($"{pInfo.ToString()};{pInfo.CanRead};{pInfo.CanWrite}");
            }

            Console.ReadKey();
        }
    }
}
