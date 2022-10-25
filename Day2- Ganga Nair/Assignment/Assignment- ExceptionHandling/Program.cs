using ExceptionLibrary;
namespace Assignment3
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            string name;
            int marks;
            List<Student> students = new List<Student>();
            do
            {
                repeat:
                Console.WriteLine("Enter Student Name:");
                name=Console.ReadLine();
                Console.WriteLine("Enter Student Mark:");
                marks=(int)Convert.ToInt32(Console.ReadLine());
                try
                {
                    Student s = new Student(name, marks);
                    Display(s);
                    students.Add(s);
                    Console.WriteLine("Do you want to add more students (y/n)");
                    string ch=Console.ReadLine();
                    if (ch == "y")
                    {
                        goto repeat;
                    }
                    else
                    {
                        break;
                    }

                }
                catch (MarksNegativeException e)
                {
                    Console.WriteLine("Enter marks above 0");
                    goto repeat;

                }catch(MarksOverException e)
                {
                    Console.WriteLine("Enter marks below 100");
                    goto repeat;
                }
            } while(true);

        }
        public static void Display(Student s)
        {
            Console.WriteLine("New Student has been added");
            Console.WriteLine($"Student Id: {s.ID}");
            Console.WriteLine("----------------------------");
        }
    }
}
