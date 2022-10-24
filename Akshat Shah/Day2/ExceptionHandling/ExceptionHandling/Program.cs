using MarksExceptionLibrary;

namespace ExceptionHandling
{
    internal class Program
    {
        
        static SortedList<string, Student> students = new SortedList<string, Student>();

        static void Main(string[] args)
        {
            string option = "";
            do
            {
                Console.WriteLine("-----Students Database-----");
                Console.WriteLine("MENU (Enter option number to select option, or enter q to quit)");
                Console.WriteLine("1 - Add Student");
                Console.WriteLine("2 - View particular student");
                Console.WriteLine("3 - View all students");
                Console.WriteLine("q - Quit");

                option = Console.ReadLine();
                if (option == "1")
                    AddStudent();
                else if (option == "2")
                    GetStudent();
                else if (option == "3")
                    GetAllStudents();
                else if (option == "q")
                    Console.WriteLine("Quitting...");
                else
                    Console.WriteLine("Invalid input, try again");
                Console.WriteLine();

            } while (option?.ToLower() != "q" || false);
        }

        private static void AddStudent()
        {
            Console.WriteLine("Adding student");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Marks: ");
            if (int.TryParse(Console.ReadLine(), out int marks))
            {
                try
                {
                    Student student = new Student(name, marks);
                    students[student.Id] = student;

                    Console.WriteLine("Student added. Details:");
                    Console.WriteLine(student);
                }
                catch (AbstractMarksException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Invalid marks, try again");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid marks, try again");
            }
        }

        private static void GetStudent()
        {
            Console.Write("Enter student ID: ");
            string? studentId = Console.ReadLine();
            if (students.TryGetValue(studentId ?? "", out Student? student))
            {
                Console.WriteLine("Student Found!");
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("No such student found");
            }
        }

        private static void GetAllStudents()
        {
            Console.WriteLine("Listing all students...");
            foreach (KeyValuePair<string, Student> studentKvp in students)
            {
                Console.WriteLine(studentKvp.Value);
                Console.WriteLine("---");
            }
        }
    }
}