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
using System.Collections.Generic;
using System.IO;
using System.Text;

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
                    if (text[i][j] != "")
                    {
                        char[] letters = text[i][j].ToCharArray();
                        int l = letters.Length;
                        if (letters[l - 1] == ',')
                        {
                            l -= 1;
                            if (letters[l - 1] == c)
                            {
                                text[i][j] = ""; text[i][j - 1] = text[i][j - 1] + ",";
                            }
                        }
                        else if (letters[l - 1] == '.')
                        {
                            l -= 1;
                            if (letters[l - 1] == c)
                            {
                                text[i][j] = ""; text[i][j - 1] = text[i][j - 1] + ".";
                            }
                        }
                        if (letters[l - 1] == c) text[i][j] = "";
                    }
                }
            }
        }
        /// <summary>
        /// Находит самое длинное слово сообщения.
        /// Если в сообщении несколько самых длинных слов - выводит все через пробел
        /// </summary>
        /// <returns></returns>
        public string MaxWord()
        {
            int count;
            int max = 0;
            string maxWord = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    count = text[i][j].Length;
                    if (count > max)
                    {
                        max = count;
                        maxWord = text[i][j];
                    } else if (count == max)
                    {
                        maxWord += " " + text[i][j];
                    }
                }
            }

            return maxWord;
        }
        public string[][] ToArray()
        {
            return text;
        }
        /// <summary>
        /// Частотный анализ текста по массиву слов
        /// </summary>
        /// <param name="words"></param>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static Dictionary<string, int> WordFrequency(string[] words, Message txt)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            string[][] a = txt.ToArray();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    for (int k = 0; k < words.Length; k++)
                    {
                        if (words[k] == a[i][j])
                        {
                            if (result.ContainsKey(words[k])) result[words[k]]++;
                            else result.Add(words[k], 1);
                        }
                    }
                }
            }

            return result;
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
            
            // а) Вывести только те слова сообщения, которые содержат не более n букв.
            msg.PrintWords(7);
            
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            Console.WriteLine("\nТекст до удаления слова с последним символом 'я'\n" + msg.ToString());
            msg.DeleteWords('я');
            Console.WriteLine("\nТекст после удаления слова с последним символом 'я'\n" + msg.ToString());
            
            // в) Найти самое длинное слово сообщения.
            Console.WriteLine($"Самое длинное слово сообщения: {msg.MaxWord()}");
            
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            msg.DeleteWords('r');
            StringBuilder strb = new StringBuilder();
            strb.Append(msg.MaxWord());
            Console.WriteLine($"Cамые длинные слова сообщения (после удаления слов заканчивающихся на 'r','я'): {strb}");

            // д) ***Создать метод, который производит частотный анализ текста.
            Console.WriteLine("\nЧастотный анализ текста:\n");
            string[] myWords = { "массив", "класс", "текст", "метод", "сообщения", "слова" };
            Dictionary<string, int> result = Message.WordFrequency(myWords, msg);
            foreach (string val in result.Keys)
            {
                Console.WriteLine($"{val}: {result[val]}");
            }

            Console.ReadKey();
        }
    }
}
