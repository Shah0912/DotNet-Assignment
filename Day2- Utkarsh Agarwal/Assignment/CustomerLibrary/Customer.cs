namespace CustomerLibrary
{
    public class Customer
    {
        int Id;
        string Name;

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine($"Customer Id: {Id}  Customer Name: {Name}");
        }


    }
}