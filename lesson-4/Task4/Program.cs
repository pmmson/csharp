/*
 * Павленко Михаил
 * 
 * 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
 * Создайте структуру Account, содержащую Login и Password.
 * 
 */

using System;
using System.IO;

namespace Task4
{
    struct Account
    {
        public string Login;
        public string Password;
    }

    class Program
    {
        static bool CheckLoginPass(Account user)
        {
            StreamReader sr = new StreamReader(@"accounts.txt");
            int count = int.Parse(sr.ReadLine()); // узнаем кол-во пользователей
            string[][] account = new string[count][];
            int i = 0;
            bool flag = false;
            while (!sr.EndOfStream)
            {
                account[i] = sr.ReadLine().Split(';');
                if (account[i][0] == user.Login && account[i][1] == user.Password)
                {
                    flag = true;
                    break;
                } else
                {
                    i++;
                }
            }

            return flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста, введите учетные данные: ");
            int i = 1; //кол-во попыток
            Account user;
            do
            {
                Console.Write("Введите логин: ");
                user.Login = Console.ReadLine();
                Console.Write("пароль: ");
                user.Password = Console.ReadLine();
                if (CheckLoginPass(user))
                {
                    Console.WriteLine($"{user.Login} - успешная авторизация!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный логин или пароль!");
                    i++;
                }
            } while (i <= 3);
            if (i > 3)
            {
                Console.WriteLine("Превышено кол-во попыток авторизации!");
            }

            Console.ReadKey();
        }
    }
}

