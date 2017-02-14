using System;
using static System.Math;

namespace Program2
{
    class Sphere : ISolid
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public void GetVolume()
        {
            double result = (4 * PI * Pow(radius, 3)) / 3;
            Console.WriteLine("Об'єм кулi: {0}\n", result);
        }
    }
}
