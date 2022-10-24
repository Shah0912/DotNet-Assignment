namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Calculator calculator=new Calculator();
            do
            {
                calculator.ValidateData();
            Repeat:
                Console.WriteLine("What operation you want to perform \n1.Addition\n2.Comparision\n3.Swapping\n4.Print Table\nEnter you option: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (!calculator.Calculate(choice))
                {
                    goto Repeat;
                }
                string ch2;
                Console.WriteLine("Any More Operations to perform (y|n): ");
                ch2 = Console.ReadLine();
                if (ch2 != "y")
                {
                    break;
                }
            }while(true);
        }
    }
}