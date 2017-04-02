using System;
using System.Collections.Generic;
using System.IO;

namespace Program
{
    class Visiting
    {
        public Queue<Student> studentQueue { get; }

        public Visiting()
        {
            studentQueue = new Queue<Student>();
        }

        public Visiting(string filePath)
        {
            studentQueue = new Queue<Student>();
            ReadFromFile(filePath);
        }

        public void Add(Student student)
        {
            studentQueue.Enqueue(student);
        }

        public void ShowTotalMissings()
        {
            int result = 0;
            foreach (Student item in studentQueue)
            {
                result += item.missingTotal;
            }
            Console.WriteLine("Загальна к-ть пропускiв: {0}", result);
        }

        public void ShowTotalJustifiedMissings()
        {
            int result = 0;
            foreach (Student item in studentQueue)
            {
                result += item.missingJustified;
            }
            Console.WriteLine("Загальна к-ть виправданих пропускiв: {0}", result);
        }

        public void ShowTotalMissingHours()
        {
            int result = 0;
            foreach (Student item in studentQueue)
            {
                result += item.MissTotal();
            }
            Console.WriteLine("Загальна к-ть пропущених годин: {0}", result);
        }

        private void ReadFromFile(string filePath)
        {
            try
            {
                FileStream fIn = new FileStream(filePath, FileMode.Open);
                StreamReader sw = new StreamReader(fIn);
                string line = null;
                while ((line = sw.ReadLine()) != null)
                {
                    string[] tokens = line.Split('&');
                    studentQueue.Enqueue(new Student(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2])));
                }
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Невірний шлях");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Невірні данні у файлі");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void WriteToFile(string filePath)
        {
            try
            {
                FileStream fOut = new FileStream(filePath, FileMode.Create);
                StreamWriter sw = new StreamWriter(fOut);
                foreach (Student item in studentQueue)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
