using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Calculator
    {
        //Member declaration
        private int a;
        private int b;
        private double result;
        private int choice;
        
        //Method definitions

        //Method to get input from user
        private int GetData()
        {
            Console.Write("Enter a no.: ");
            return int.Parse(Console.ReadLine());
        }

        //Method to print data
        public void PrintData()
        {
            Console.WriteLine($"\nThe result is: {result}\n");
        }

        //Method to perform calculations
        private void Calculate()
        {  
            switch(choice)
            {
                case 1: Add(); break;
                case 2: Subtract(); break;
                case 3: Multiply(); break;
                case 4: Divide(); break;
            }
        }

        //Method to validate the data entered
        public void ValidateData()
        {
            int var1 = GetData();
            int var2 = GetData();
            if(var1>0 && var2>0)
            {
                a = var1;
                b = var2;
            }

            else 
            {
                Console.WriteLine("\nInvalid input! The numbers must be positive integers.\n");
                ValidateData();
            }
        }

        //Method to validate the choice
        public void ValidateChoice()
        {
            do
            {
                Console.WriteLine("Which operation do you wish to perform?");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("\nEnter your choice: ");
                choice = int.Parse(Console.ReadLine());

                if(choice>=1 && choice<=4)
                {
                    Calculate();
                }
                else
                {
                    Console.WriteLine("\nInvalid choice entered! Please enter a choice between 1-4.\n");
                }
            }
            while (choice < 1 || choice > 4);
            
        }

        //Method to perform division
        private void Divide()
        {
            result = Convert.ToDouble(a)/Convert.ToDouble(b);
        }

        //Method to perform multiplication
        private void Multiply()
        {
            result = a * b;
        }

        //Method to perform subtraction
        private void Subtract()
        {
            result = a - b;
        }

        //Method to perform addition
        private void Add()
        {
            result = a + b;
        }
    }
}
