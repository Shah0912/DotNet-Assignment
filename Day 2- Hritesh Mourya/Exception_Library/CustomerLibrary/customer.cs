using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CustomerLibrary
{
    public class customer
    {
        public int id;
        public String Name;

        public customer(int i, string n)
        {
            this.id = i;
            this.Name = n;
        }
        public static void Main()
        {

        }

        public static void Display1()
        {

            ArrayList arr2 = new ArrayList();

            arr2.Add(new customer(1, "CustomerName1"));
            arr2.Add(new customer(2, "CustomerName2"));
            arr2.Add(new customer(3, "CustomerName3"));
            arr2.Add(new customer(4, "CustomerName4"));
            arr2.Add(new customer(5, "CustomerName5"));

            Console.WriteLine("\nCustomer List: ");

            foreach (customer cust in arr2)
            {
                Console.WriteLine($"\nCustomer ID: {cust.id} \nCustomer Name: {cust.Name}");
            }

        }
    }
}