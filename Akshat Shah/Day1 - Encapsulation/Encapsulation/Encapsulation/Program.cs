namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            string choice = "y";
            do
            {
                try
                {
                    calculator.GetData();
                    calculator.Calculate();
                    calculator.PrintData();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Error occured");
                }

                Console.WriteLine();
                Console.WriteLine("Perform another calculation? (Enter y|yes to proceed, or anything else to cancel)");
                choice = Console.ReadLine() ?? "n";
                Console.WriteLine();

            } while (choice.ToLower() == "y" || choice.ToLower() == "yes");
        }
    }
}