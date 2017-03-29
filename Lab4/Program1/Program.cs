using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Введiть розмiр першого вектору: ");
            size = int.Parse(Console.ReadLine());
            Vector v1 = new Vector(size);
            Console.Write("Введiть розмiр другого вектору: ");
            size = int.Parse(Console.ReadLine());
            Vector v2 = new Vector(size);
            bool flag = false;
            int app = 0;
            int value;
            while (!flag)
            {
                Console.WriteLine("Оберiть:\n1.Додати елемент до 1-го вектору\n2.Додати елемент до 2-го вектору\n3.Вивести 1-ий вектор\n4.Вивести 2-ий вектор\n5.Вивести розмiр 1-го вектору\n6.Вивести розмiр 2-го вектору\n7.Перемножити вектори\n8.Завершити роботу");
                app = int.Parse(Console.ReadLine());
                switch (app)
                {
                    case 1:
                        Console.Write("Введiть елемент: ");
                        value = int.Parse(Console.ReadLine());
                        v1.Add(value);
                        break;
                    case 2:
                        Console.Write("Введiть елемент: ");
                        value = int.Parse(Console.ReadLine());
                        v2.Add(value);
                        break;
                    case 3:
                        v1.ShowVector();
                        break;
                    case 4:
                        v2.ShowVector();
                        break;
                    case 5:
                        Console.WriteLine(v1.size);
                        break;
                    case 6:
                        Console.WriteLine(v2.size);
                        break;
                    case 7:
                        Console.WriteLine(v1 * v2);
                        break;
                    case 8:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Введено неправильне значення");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
