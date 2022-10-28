namespace StudentLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static void Display()
        {
            List<Student> students = new List<Student> { new Student(1, "Student1"),
                                                         new Student(2, "Student2")};
            foreach(Student student in students)
            {
                Console.WriteLine($"Id: {student.Id}  Name: {student.Name}");
            }
            
        }
    }
}