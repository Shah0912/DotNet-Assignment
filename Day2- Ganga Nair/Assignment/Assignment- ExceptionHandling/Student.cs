using ExceptionLibrary;
namespace Assignment3
{
    public class Student
    {
        public readonly Guid ID;
        private string Name;
        private int Marks;
        public Student(string name, int marks)
        {
            ID = Guid.NewGuid();
            Name = name;
            if (marks < 0)
            {
                throw new MarksNegativeException();
            }
            else if (marks > 100)
            {
                throw new MarksOverException();
            }
            else
            {
                Marks = marks;
            }

        }

    }
}