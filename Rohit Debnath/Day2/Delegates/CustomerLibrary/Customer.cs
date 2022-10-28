namespace CustomerLibrary
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static void Display()
        {
            List<Customer> customers = new List<Customer> { new Customer(1, "Customer1"),
                                                         new Customer(2, "Customer2")};
            foreach (Customer cust in customers)
            {
                Console.WriteLine($"Id: {cust.Id}  Name: {cust.Name}");
            }

        }
    }
}