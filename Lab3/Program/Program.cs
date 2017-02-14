using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Введiть розмiр масиву: ");
            size = int.Parse(Console.ReadLine());
            Visiting v = new Visiting(size);
            bool flag = false;
            int app = 0;
            while (!flag)
            {
                Console.WriteLine("Оберiть:\n1.Список людей\n2.Загальна к-ть пропускiв\n3.Загальна к-ть виправданих пропускiв\n4.Загальну пропущених годин\n5.Завершити роботу");
                app = int.Parse(Console.ReadLine());
                switch (app)
                {
                    case 1:
                        v.ShowArray();
                        break;
                    case 2:
                        v.MissingTotal();
                        break;
                    case 3:
                        v.MissingJustified();
                        break;
                    case 4:
                        v.MissingHours();
                        break;
                    case 5:
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
