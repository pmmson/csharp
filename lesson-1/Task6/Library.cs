using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Library
    {
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }
        public static void Print(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(s);
        }
    }
}
