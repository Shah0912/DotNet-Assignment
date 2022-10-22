namespace StudentLibrary
{
    public class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine("Employee id: " + Id + " Employee name: " + Name);
        }
    }
}