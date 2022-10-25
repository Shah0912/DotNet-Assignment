namespace Assignment
{
    public class Calculator
    {
        private int num1, num2;
        public void ValidateData()
        {
            //while loop runs till it gets a valid input
            //here assuming user inputs all numbers, code checks it it's positive or not
            do
            {
                GetData();
                if (num1 < 0 || num2 < 0)
                {
                    Console.WriteLine("Enter a positive number");
                }
                else
                {
                    break;
                }
            } while (true);
            Console.WriteLine("\n");
        }
        private void GetData()
        {
            Console.WriteLine("Enter First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
        public bool Calculate(int ch)
        {
            switch (ch)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Comparision();
                    break;
                case 3:
                    Swap();
                    break;
                case 4:
                    Table();
                    break;
                default:
                    Console.WriteLine("Enter a correct choice !");
                    return false;

            }
            return true;

        }
        private void PrintData(string result)
        {
            Console.WriteLine(result);
        }

        private void Table()
        {
            //assuming we have to print from num1 to num2
            int res;
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            for (int i = num1; i <= num2; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    res = i * j;
                    PrintData($"{i} x {j} ={res}");
                }
                Console.WriteLine("\n------------------\n");
            }
        }

        private void Swap()
        {
            PrintData($"Before swap inside Swap method\n X:{num1} Y:{num2}");
            int temp = num1;
            num1 = num2;
            num2 = temp;
            PrintData($"After swap inside Swap method\n X:{num1} Y:{num2}\n\n");
        }

        private void Comparision()
        {
            if (num1 > num2)
            {
                PrintData($"{num1} is greater than {num2}\n\n");
            }
            else if (num2 > num1)
            {
                PrintData($"{num2} is greater than {num1}\n\n");
            }
            else
            {
                PrintData($"{num2} is equal to {num1}\n\n");
            }
        }

        private void Addition()
        {
            int result = num1 + num2;
            PrintData($"{num1} + {num2} = {result}\n\n");
        }
    }


}

