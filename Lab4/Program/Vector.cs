using System;

namespace Program
{
    class Vector
    {
        private int[] numberArray;
        private int size;
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

        public void GetVectorSize()
        {
            Console.WriteLine("Розмiр вектору: {0}", size);
        }

        public int[] GetVector()
        {
            return numberArray;
        }

        public void ShowVector()
        {
            for (int i = 0; i < currPosition; i++)
            {
                Console.Write("{0} ", numberArray[i]);
            }
        }

        public static int operator * (Vector first, Vector second)
        {
            int result = 1;
            int[] f = first.GetVector();
            int[] s = second.GetVector();
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
