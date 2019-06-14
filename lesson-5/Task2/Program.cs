/*
 * Павленко Михаил
 * 
 * 2. Разработать статический класс ​Message,​ содержащий следующие статические методы для
 *    обработки текста:
 * а) Вывести только те слова сообщения, которые содержат не более n букв.
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 * в) Найти самое длинное слово сообщения.
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
 *    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 *    
 */

using System;
using System.IO;

namespace Task2
{
    class Message
    {
        string[][] text;

        public Message(string path)
        {
            string[] str = File.ReadAllLines(path);
            text = new string[str.Length][];
            for (int i = 0; i < str.Length; i++)
            {
                text[i] = str[i].Split(' ');
            }
        }
        /// <summary>
        /// Выводит слова сообщения, которые содержат не более n букв
        /// </summary>
        /// <param name="n"></param>
        public void PrintWords(int n)
        {
            int count;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    count = text[i][j].Length;
                    if (count <= n) Console.WriteLine(text[i][j]);
                }
            }
        }
        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="c"></param>
        public void DeleteWords(char c)
        {
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    char[] letters = text[i][j].ToCharArray();
                    if(letters[letters.Length-1] == c)
                    {
                        text[i][j] = "";
                    }
                }
            }
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (text[i][j] == "") continue;
                    str += text[i][j] + " ";
                }
                str += "\n";
            }

            return str;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("message.txt");
            msg.PrintWords(7);
            Console.WriteLine(msg.ToString());
            msg.DeleteWords('я');
            Console.WriteLine(msg.ToString());


            Console.ReadKey();
        }
    }
}
