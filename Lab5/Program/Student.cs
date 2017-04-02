using System;

namespace Program
{
    class Student
    {
        public string secondName { get; private set; }
        public int missingTotal { get; private set; }
        public int missingJustified { get; private set; }

        public Student(string secondName, int missingTotal, int missingJustified)
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
            return string.Format("{0}&{1}&{2}", secondName, missingTotal, missingJustified);
        }

        public void ShowStudent()
        {
            Console.WriteLine(string.Format("Прiзвище: {0}, К-ть пропускiв: {1}, К-ть виправданих пропускiв: {2}", secondName, missingTotal, missingJustified));
        }
    }
}
