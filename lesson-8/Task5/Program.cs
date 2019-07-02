/*
 * Павленко Михаил
 * 
 * 5. **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            StreamReader sr = new StreamReader("students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    students.Add(new Student(s[1] + " " + s[0], int.Parse(s[6]), int.Parse(s[5])));
                }
                catch
                {

                }
            }
            sr.Close();

            SaveXmlFile(students, "students.xml");


            _ = Console.ReadKey();
        }

        static void SaveXmlFile(List<Student> obj, string fName)
        {
            XmlSerializer xmlFile = new XmlSerializer(typeof(List<Student>));
            Stream fStream = new FileStream(fName, FileMode.Create, FileAccess.Write);
            xmlFile.Serialize(fStream, obj);
            fStream.Close();
        }
    }
}
