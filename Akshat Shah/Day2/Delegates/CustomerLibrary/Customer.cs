namespace CustomerLibrary
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Customer(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Customer {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine();
        }
    }
}