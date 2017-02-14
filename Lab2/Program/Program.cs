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
            Visiting[] array = new Visiting[size];
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
                array[i] = new Visiting(secondName, missingTotal, missingJustified);
            }
            bool flag = false;
            int app = 0;
            while (!flag)
            {
                Console.WriteLine("Оберiть:\n1.Список людей\n2.Загальна к-ть пропускiв\n3.Загальна к-ть виправданих пропускiв\n4.Загальну пропущених годин\n5.Завершити роботу");
                app = int.Parse(Console.ReadLine());
                switch (app)
                {
                    case 1:
                        {
                            foreach (Visiting item in array)
                            {
                                Console.WriteLine(item.ToString() + "\nПропущено годин: " + item.MissTotal().ToString() + "\nПропущено у вiдсотках: " + item.MissPercent().ToString());
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        {
                            int result = 0;
                            foreach (Visiting item in array)
                            {
                                result += item.MissingTotal;
                            }
                            Console.WriteLine("Загальна к-ть пропускiв: {0}", result);
                        }
                        break;
                    case 3:
                        {
                            int result = 0;
                            foreach (Visiting item in array)
                            {
                                result += item.MissingJustified;
                            }
                            Console.WriteLine("Загальна к-ть виправданих пропускiв: {0}", result);
                        }
                        break;
                    case 4:
                        {
                            int result = 0;
                            foreach (Visiting item in array)
                            {
                                result += item.MissTotal();
                            }
                            Console.WriteLine("Загальна к-ть пропущених годин: {0}", result);
                        }
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

    class Visiting
    {
        private string secondName;
        private int missingTotal;
        private int missingJustified;

        public int MissingTotal
        {
            get { return missingTotal; }
        }

        public int MissingJustified
        {
            get { return missingJustified; }
        }

        public Visiting(string secondName, int missingTotal, int missingJustified)
        {
            this.secondName = secondName;
            this.missingTotal = missingTotal;
            this.missingJustified = missingJustified;
        }

        public int MissTotal()
        {
            return missingTotal - missingJustified;
        }

        public double MissPercent()
        {
            if (missingTotal == 0) return 0;
            return ((double)MissTotal() * 100) / missingTotal;
        }

        public override string ToString()
        {
            return String.Format("Прiзвище: {0}, К-ть пропускiв: {1}, К-ть виправданих пропускiв: {2}", secondName, missingTotal, missingJustified);
        }
    }
}
