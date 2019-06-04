/*
 * Павленко Михаил
 * 6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Михаил Павленко, Краснодар";
            Library.Print("Пауза...");
            Library.Pause();
            Library.Print(s);
            Library.Pause();
            Library.Print(s, 45, 2);
            Library.Pause();
        }
    }
}
