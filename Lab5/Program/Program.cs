using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Visiting v;
            int start = 0;
            Console.WriteLine("1.Створити нову чергу\n2.Завантажити з файлу");
            start = int.Parse(Console.ReadLine());
            if (start == 1) v = new Visiting();
            else
            {
                Console.Write("Введіть шлях до файлу: ");
                string filePath = Console.ReadLine();
                v = new Visiting(filePath);
            }
            bool flag = false;
            int app = 0;
            while (!flag)
            {
                Console.WriteLine(
                    "Оберiть:\n1.Список людей\n2.Загальна к-ть пропускiв\n3.Загальна к-ть виправданих пропускiв\n4.Загальну пропущених годин\n5.Додати студента\n6.Завершити роботу");
                app = int.Parse(Console.ReadLine());
                switch (app)
                {
                    case 1:
                    {
                        foreach (Student item in v.studentQueue)
                        {
                            item.ShowStudent();
                            Console.WriteLine("Пропущено годин: " + item.MissTotal() + "\nПропущено у вiдсотках: " +
                                              item.MissPercent());
                            Console.WriteLine();
                        }
                    }
                        break;
                    case 2:
                    {
                        v.ShowTotalMissings();
                    }
                        break;
                    case 3:
                    {
                        v.ShowTotalJustifiedMissings();
                    }
                        break;
                    case 4:
                    {
                        v.ShowTotalMissingHours();
                    }
                        break;
                    case 5:
                    {
                        string secondName;
                        int missingTotal = 0, missingJustified = 0;
                        Console.Write("Введiть прiзвище: ");
                        secondName = Console.ReadLine();
                        Console.Write("Введiть к-ть пропускiв: ");
                        missingTotal = int.Parse(Console.ReadLine());
                        Console.Write("Введiть к-ть виправданих пропускiв: ");
                        missingJustified = int.Parse(Console.ReadLine());
                        v.Add(new Student(secondName, missingTotal, missingJustified));
                    }
                        break;
                    case 6:
                    {
                        flag = true;
                        Console.WriteLine("Записати в файл? Y/N");
                        if (Console.ReadLine() == "Y")
                        {
                            Console.Write("Введіть шлях до файлу: ");
                            v.WriteToFile(Console.ReadLine());
                        }
                    }
                        break;
                    default:
                        Console.WriteLine("Введено неправильне значення");
                        break;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
