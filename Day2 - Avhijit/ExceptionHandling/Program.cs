using ExceptionLibrary;

namespace ExceptionHandling
{
    public class Student
    {
        public static int Id = 0;
        private string Name;
        private int Marks;

        public Student(int id, string name, int marks)
        {
            Id++;
            Id = id;
            Name = name;
            try
            {
                if (marks <= 100 && marks >= 0)
                    Marks = marks;
                else if (marks >= 100)
                    throw new MarksOverException();
                else if (marks <= 0)
                    throw new MarksNegativeException();
            }
            catch(MarksOverException e)
            {
                Console.WriteLine("Marks should be less than or equal to 100");
            }
            catch(MarksNegativeException e)
            {
                Console.WriteLine("Marks should be greater than or equal to 0");
            }
        }
        static void Main()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();
            Console.WriteLine("Do you wanna add a student? (y/n)");
            string ans = Console.ReadLine().ToLower();
            if (ans.Equals("y") || ans.Equals("yes"))
            {
                Console.WriteLine("Enter Student name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter marks: ");
                int marks = (int)Convert.ToInt32(Console.ReadLine());
                Student s = new Student(Id, name, marks);
                students.Add(Id, s);
                Console.WriteLine("Student with ID: " + Id + " added successfully");
                Main();
            }
        }

    }
}