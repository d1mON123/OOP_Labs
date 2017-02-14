using System;

namespace Program
{
    class Visiting
    {
        private Student[] studentArray;

        public Visiting(int size)
        {
            studentArray = new Student[size];
            for (int i = 0; i < size; i++)
            {
                string secondName;
                int missingTotal = 0, missingJustified = 0;
                Console.Write("Введiть прiзвище: ");
                secondName = Console.ReadLine();
                Console.Write("Введiть к-ть пропускiв: ");
                missingTotal = int.Parse(Console.ReadLine());
                Console.Write("Введiть к-ть виправданих пропускiв: ");
                missingJustified = int.Parse(Console.ReadLine());
                studentArray[i] = new Student(secondName, missingTotal, missingJustified);
            }
        }

        public void MissingTotal()
        {
            int result = 0;
            foreach (Student item in studentArray)
            {
                result += item.MissingTotal;
            }
            Console.WriteLine("Загальна к-ть пропускiв: {0}", result);
        }

        public void MissingJustified()
        {
            int result = 0;
            foreach (Student item in studentArray)
            {
                result += item.MissingJustified;
            }
            Console.WriteLine("Загальна к-ть виправданих пропускiв: {0}", result);
        }

        public void MissingHours()
        {
            double result = 0;
            foreach (Student item in studentArray)
            {
                result += item.MissTotal();
            }
            Console.WriteLine("Загальна к-ть пропущених годин: {0}", result);
        }

        public void ShowArray()
        {
            foreach (Student item in studentArray)
            {
                Console.WriteLine(item.ToString() + "\nПропущено годин: " + item.MissTotal().ToString() + "\nПропущено у вiдсотках: " + item.MissPercent().ToString() + "\n");
            }
        }
    }
}
