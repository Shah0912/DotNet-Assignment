using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExceptionLibrary;

namespace StudentDetails
{
    public  class Student
    {
        private int ID, Marks;
        private string Name;
        public static int id_val= 0;
        
        public Student(string name, int marks)
        {
            try
            {
                if(marks > 100)
                {
                    throw new MarksOverException("\nError: MarksOverException! \nMarks cannot be greater than 100!");
                }

                else if(marks<0)
                {
                    throw new MarksNegativeException("Error: MarksNegativeException! \nMarks cannot be less than 0!");
                }

                else
                {
                    this.Marks = marks;
                    this.Name = name;
                    this.ID = Interlocked.Increment(ref id_val);
                    Console.WriteLine("Student added");
                }
            }
            catch(MarksNegativeException ex1)
            {
                Console.WriteLine(ex1.Message);
            }

            catch(MarksOverException ex2)
            {
                Console.WriteLine(ex2.Message);
            }
        }
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>();

            char cnt;
            int find_id;

            do
            {

                Console.WriteLine("\nEnter your choice");
                Console.WriteLine("\n1.Add Student");
                Console.WriteLine("\n2.Display Student marks using student ID ");
                Console.WriteLine("\n3.Display Student marks");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Insert();
                        break;

                    case 2:
                        bool ans = GetOneStudent();
                        if (ans == false)
                        {
                            Console.WriteLine("\nInvalid Student ID");
                        }
                        break;

                    case 3:
                        GetAllStudent();
                        break;
                }
                Console.WriteLine("\nDo you want to continue? enter 'y' or 'n'");
                cnt = Char.Parse(Console.ReadLine());
            } while (cnt == 'y');


            void Insert()
            {
                Console.WriteLine("\nEnter Student name");
                string stud_name = Console.ReadLine();
                Console.Write("\nEnter marks: ");
                int stud_marks = int.Parse(Console.ReadLine());

                Student obj_insert = new Student(stud_name, stud_marks);
                stud.Add(obj_insert);


            }

            bool GetOneStudent()
            {
                Console.WriteLine("Enter the student id");
                find_id = int.Parse(Console.ReadLine());
                foreach(Student find_obj in stud)
                {
                    if(find_obj.ID == find_id)
                    {
                        Console.WriteLine($"\nName: {find_obj.Name}");
                        Console.WriteLine($"\nMarks:  {find_obj.Marks}");
                        return true;

                    }
                }
                return false;

            }

            void GetAllStudent()

            {
                foreach(Student print_obj in stud)
                {

                    Console.WriteLine($"\nStudent ID: {print_obj.ID}");
                    Console.WriteLine($"\nStudent Name: {print_obj.Name}");
                    Console.WriteLine($"\nStudent Marks: {print_obj.Marks}");

                }
            }
        }
    }
}
