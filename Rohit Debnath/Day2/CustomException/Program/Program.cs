using ExceptionLibrary;
using StudentLibrary;

namespace ProgramLibrary
{
    class Program
    {
        static Dictionary<int, Student>? students;
         static void Main()
        {
            string shouldContinue = "y";
            students = new Dictionary<int, Student>();
            do
            {
                Console.WriteLine("Enter Choice");
                Console.WriteLine("1. Enter Students");
                Console.WriteLine("2. Display All Students");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 1)
                {
                    Console.WriteLine("Enter Name of Student");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter Marks");
                    int marks = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Student student = new Student(Name, marks);
                        students.Add(student.Id, student);
                    }
                    catch (MarksNegativeException)
                    {
                        Console.WriteLine("Marks should be above or eqaul to 0");
                    }
                    catch (MarksOverException)
                    {
                        Console.WriteLine("Marks should be less or eqaul to 100");
                    }
                    
                }
                else if (ans == 2)
                {
                    DisplayStudents(students);
                }
                else
                {
                    Console.WriteLine("Enter valid choice");
                }

                Console.WriteLine("Do you want to continue(Press 'y' to continue)");
                shouldContinue = Console.ReadLine().ToString();
            }while(shouldContinue.Equals("y") || shouldContinue.Equals("Y"));
        }

        static void DisplayStudents(Dictionary<int, Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No Student Details Added");
                return;
            }
            foreach(KeyValuePair<int ,Student> item in students)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
