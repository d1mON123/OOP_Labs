using System;
using static System.Math;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            int app = 0;
            while (!flag)
            {
                Console.WriteLine("Оберiть програму:\n1.Вивести прiзвище i дату\n2.Обчислити вираз\n3.Конвертор температури\n4.Завершити роботу");
                app = int.Parse(Console.ReadLine());
                switch (app)
                {
                    case 1:
                        {
                            Console.Write("Введiть своє прiзвище: ");
                            string SecondName = Console.ReadLine();
                            ShowNameDate(SecondName);
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Введiть число:");
                            double Number = double.Parse(Console.ReadLine());
                            MathProblem(Number);
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Введiть нижню межу:");
                            int LeftLim = int.Parse(Console.ReadLine());
                            Console.Write("Введiть верхню межу:");
                            int RightLim = int.Parse(Console.ReadLine());
                            if (RightLim <= LeftLim) Console.WriteLine("Неправильнi межi");
                            else ConvertTemperature(LeftLim, RightLim);
                        }
                        break;
                    case 4:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Введено неправильне значення");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void ShowNameDate(string SecondName)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("Прiзвище: {0}\nДата: {1:dd.mm.yyyy}\nЧас: {1:HH:mm:ss}", SecondName, dt);
        }

        static void MathProblem(double Number)
        {
            double number = (Number * PI) / 180;
            double Result = (1f / Tan(number)) * (180.0 / PI);
            Console.WriteLine("ctg({0}) = {1}`", Number, Result);
        }

        static void ConvertTemperature(int LeftLim, int RightLim)
        {
            for (int i = LeftLim; i <= RightLim; i++)
            {
                double Result = (5 * ((double)i - 32)) / 9;
                Console.WriteLine("{0} гр.Фаренгейта = {1:0.00} гр.Цельсiя", i, Result);
            }
        }
    }
}
