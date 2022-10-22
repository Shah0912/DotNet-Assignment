namespace CustomerLibrary
{
    public class Customer
    {
        public int Id;
        public string Name;

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Display(Customer cmp)
        {
            Console.WriteLine("Employee id: " + cmp.Id + " Employee name: " + cmp.Name);
        }
    }
}