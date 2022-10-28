using ExceptionLibrary;

namespace StudentLibrary
{
    public class Student
    {
        private static int counter;
        public int Id { get; private set; }
        private string Name;
        private int Marks;

        public Student(string name, int marks)
        {
            counter++;
            Id = counter;
            Name = name;

                if (marks <= 100 && marks >= 0)
                {
                    Marks = marks;
                    Console.WriteLine("Details Added");
                }
                else if (marks >= 100)
                    throw new MarksOverException();
                else if (marks <= 0)
                    throw new MarksNegativeException();

        }

        public override string ToString()
        {
            return $"{Name} {Marks}";
        }
    }
}