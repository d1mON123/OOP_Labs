using System;

namespace Program2
{
    class Pyramid : ISolid
    {
        private double lentgh;
        private double height;

        public Pyramid(double lentgh, double height)
        {
            this.lentgh = lentgh;
            this.height = height;
        }

        public void GetVolume()
        {
            double result = (lentgh * lentgh * height) / 3;
            Console.WriteLine("Об'єм пiрамiди: {0}\n", result);
        }
    }
}
