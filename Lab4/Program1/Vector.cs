using System;

namespace Program
{
    class Vector
    {
        public int[] numberArray { get; }
        public int size { get; }
        private int currPosition;

        public Vector(int size)
        {
            this.size = size;
            numberArray = new int[size];
            currPosition = 0;
        }

        public void Add(int value)
        {
            if (currPosition != size) numberArray[currPosition++] = value;
            else Console.WriteLine("Вектор повний");
        }

        public void ShowVector()
        {
            for (int i = 0; i < currPosition; i++)
            {
                Console.Write("{0} ", numberArray[i]);
            }
        }

        public static int operator *(Vector first, Vector second)
        {
            int result = 1;
            int[] f = first.numberArray;
            int[] s = second.numberArray;
            foreach (int item in f)
            {
                if (item < 0) result *= item;
            }
            foreach (int item in s)
            {
                if (item < 0) result *= item;
            }
            return result;
        }
    }
}
