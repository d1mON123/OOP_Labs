using System;

namespace Program
{
    class Student
    {
        private string secondName;
        private int missingTotal;
        private int missingJustified;

        public Student(string secondName, int missingTotal, int missingJustified)
        {
            SecondName = secondName;
            MissingTotal = missingTotal;
            MissingJustified = missingJustified;
        }

        public int MissingJustified
        {
            get { return missingJustified; }
            set { missingJustified = value; }
        }

        public int MissingTotal
        {
            get { return missingTotal; }
            set { missingTotal = value; }
        }

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public int MissTotal()
        {
            return MissingTotal - MissingJustified;
        }

        public double MissPercent()
        {
            if (MissingTotal == 0) return 0;
            return ((double)MissTotal() * 100) / MissingTotal;
        }

        public override string ToString()
        {
            return String.Format("Прiзвище: {0}, \nК-ть пропускiв: {1}, \nК-ть виправданих пропускiв: {2}", secondName, missingTotal, missingJustified);
        }
    }
}
