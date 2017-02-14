using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0, height = 0, radius = 0;
            Console.Write("Введiть довжину сторони основи пiрамiди: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Введiть висоту пiрамiди: ");
            height = double.Parse(Console.ReadLine());
            Pyramid p = new Pyramid(length, height);
            p.GetVolume();
            Console.Write("Введiть радiус кулi: ");
            radius = double.Parse(Console.ReadLine());
            Sphere s = new Sphere(radius);
            s.GetVolume();
            Console.ReadLine();
        }
    }
}
