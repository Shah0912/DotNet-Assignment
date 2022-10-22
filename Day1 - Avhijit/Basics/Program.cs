namespace Basics
{
    public class Calculator
    {
        private void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
        }
        private void Comparision(int num1, int num2)
        {
            bool result = num1 > num2;
            if (result)
                Console.WriteLine(num1 + " is greater than " + num2);
            else
                Console.WriteLine(num2 + " is greater than " + num1);
        }
        private void Swapping(int num1, int num2)
        {
            Console.WriteLine("Before Swap inside Swap Method");
            Console.WriteLine("X: " + num1 + " , Y: " + num2);
            Console.WriteLine("After Swap inside Swap Method");
            Console.WriteLine("X: " + num2 + " , Y: " + num1);
        }
        private void PrintTable(int num1, int num2)
        {
            for(int i = num1;i<= num2; i++)
            {
                Console.WriteLine(i + " * 1 = " + i * 1);
                Console.WriteLine(i + " * 2 = " + i * 2);
                Console.WriteLine(i + " * 3 = " + i * 3);
                Console.WriteLine(i + " * 4 = " + i * 4);
                Console.WriteLine(i + " * 5 = " + i * 5);
                Console.WriteLine(i + " * 6 = " + i * 6);
                Console.WriteLine(i + " * 7 = " + i * 7);
                Console.WriteLine(i + " * 8 = " + i * 8);
                Console.WriteLine(i + " * 9 = " + i * 9);
                Console.WriteLine(i + " * 10 = " + i * 10);
                Console.WriteLine("-------------------");
            }
        }
        public void GetData()
        {
            Console.WriteLine("Enter First number: ");
            int num1 = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = (int)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform?");
            Console.WriteLine("1. Addition" + "\n" + "2. Comparision" + "\n" + "3. swapping" + "\n" + "4. Print Table");
            Console.WriteLine("Enter your option");
            int choice = (int)Convert.ToInt32(Console.ReadLine());
            Calculate(num1, num2, choice);
            Console.WriteLine("Anymore operation you want to perform? (y/n)");
            string ans = Console.ReadLine().ToLower();
            if (ans.Equals("y") || ans.Equals("yes"))
                GetData();
        }
        private void Calculate(int num1,int num2,int choice)
        {
            switch(choice)
            {
                case 1:
                    Addition(num1, num2);
                    break;
                case 2:
                    Comparision(num1, num2);
                    break;
                case 3:
                    Swapping(num1, num2);
                    break;
                case 4:
                    PrintTable(num1, num2);
                    break;
            }
        }
        static void Main()
        {
            Calculator c = new Calculator();
            c.GetData();
        }
    }
}