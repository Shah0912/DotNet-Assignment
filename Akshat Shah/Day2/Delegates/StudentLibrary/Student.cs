namespace StudentLibrary
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string TopInterest { get; set; }

        public Student(string name, string topInterest)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            TopInterest = topInterest;
        }

        public void Display()
        {
            Console.WriteLine($"Student {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Top Interest: {TopInterest}");
            Console.WriteLine();
        }
    }
}