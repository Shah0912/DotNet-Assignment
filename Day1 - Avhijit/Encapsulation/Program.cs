namespace Encapsulation 
{
public class Calculator
    {
        private int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        private int Subtract(int num1, int num2)
        {
            return num2 - num1;
        }
        private int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        private int Divide(int num1, int num2)
        {
            int result;
            try
            {
                result = num1 / num2;
                return result;
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }
        private int[] GetData()
        {
            Console.WriteLine("Enter First number: ");
            int num1 = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = (int)Convert.ToInt32(Console.ReadLine());
            int[] array = new int[] { num1, num2};
            return array;

        }
        public void ValidateData()
        {
            int[] data =  GetData();
            if (data[0]>=0 && data[1] >= 0)
            {
                ValidateChoice(data);
            }
            else
            {
                Console.WriteLine("Entered values must be positive. Please try again.");
                ValidateData();
            }

        }
        public void ValidateChoice(int[] data)
        {
            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("1. Addition" + "\n" + "2. Subtraction" + "\n" + "3. Multiplication" + "\n" + "4. Division");
            Console.WriteLine("Enter your option");
            int choice = (int)Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PrintData(Add(data[0], data[1]));
                    break;
                    case 2:
                        PrintData(Subtract(data[0], data[1]));
                        break;
                            case 3:
                                PrintData(Multiply(data[0], data[1]));
                                break;
                                    case 4:
                                        PrintData(Divide(data[0], data[1]));
                                        break;
                    default:
                    {
                        Console.WriteLine("Not a valid choice. Please try again.");
                        ValidateChoice(data);
                    }
                    break;

            }
        }
        private void PrintData(int data)
        {
            Console.WriteLine("The result is: "+data);
        }
    }
    public class MainClass
    {
        static void Main()
        {
            Calculator c = new Calculator();
            c.ValidateData();
        }
    }
}