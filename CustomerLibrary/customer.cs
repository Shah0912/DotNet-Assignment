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

            arr2.Add(new customer(1, "ramesh"));

            arr2.Add(new customer(2, "suresh"));
            arr2.Add(new customer(3, "ganesh"));
            arr2.Add(new customer(4, "vignesh"));
            arr2.Add(new customer(5, "rajesh"));

            Console.WriteLine("Customer");

            foreach (customer e in arr2)
            {
                Console.WriteLine(e.id + ": " + e.Name);
                Console.WriteLine();
            }

        }
    }
}