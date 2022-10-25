namespace StudentLibrary
{
    public class Student
    {
        int Id;
        string Name;

        public Student(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine($"Student Id: {Id} Student name: {Name}");
        }

    }
}