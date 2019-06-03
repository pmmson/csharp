/*
 * Павленко Михаил
 * 
 * 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 *    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 *    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 *    программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля 
 *    тремя попытками.
 *    
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task4
{
    class Program
    {
        static bool CheckLoginPass(string login, string password)
        {
            return (login == "root" && password == "GeekBrains");
        }
        static void Main(string[] args)
        {


            Console.WriteLine("Пожалуйста, введите учетные данные: ");
            int i = 1; //кол-во попыток
            string login;
            string password;
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("пароль: ");
                password = Console.ReadLine();
                if (CheckLoginPass(login, password))
                {
                    Console.WriteLine("Успешная авторизация!");
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

            MyLib.Pause();
        }
    }
}
