using System;

namespace Program1
{
    class Pyramid : Solid
    {
        private double lentgh;
        private double height;

        public Pyramid(double lentgh, double height)
        {
            this.lentgh = lentgh;
            this.height = height;
        }

        public override void GetVolume()
        {
            double result = (lentgh * lentgh * height) / 3;
            Console.WriteLine("Об'єм пiрамiди: {0}\n", result);
        }
    }
}
