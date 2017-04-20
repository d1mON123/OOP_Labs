using System;
using System.Text.RegularExpressions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nВведiть Exit, щоб вийти або введiть рядок для перевiрки");
                Console.Write("Введiть рядок: ");
                string str = Console.ReadLine();
                if (str == "Exit") break;
                if (isLettersOnBeginning(str) || isNumber(str)) Console.WriteLine("Вiдповiдає шаблону");
                else Console.WriteLine("Не вiдповiдає шаблону");
            }
        }

        static bool isNumber(string input)
        {
            var regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input);
        }

        static bool isLettersOnBeginning(string input)
        {
            var regex = new Regex(@"^([a-z])([0-9a-z]+$)");
            return regex.IsMatch(input);
        }
    }
}
