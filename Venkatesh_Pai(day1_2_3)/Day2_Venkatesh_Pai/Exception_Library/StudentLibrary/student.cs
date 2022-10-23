using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace StudentLibrary
{
    public class student
    {
        public int id;
        public String Name;

        public student(int i, string n)
        {
            this.id = i;
            this.Name = n;
        }
        public static void Main()
        {

        }

        public static void Display3()
        {

            ArrayList arr3  = new ArrayList();

            arr3.Add(new student(1, "steve"));

            arr3.Add(new student(2, "smith"));
            arr3.Add(new student(3, "david"));
            arr3.Add(new student(4, "rashid"));
            arr3.Add(new student(5, "adil"));

            Console.WriteLine("Student");

            foreach (student e in arr3)
            {
                Console.WriteLine(e.id + ": " + e.Name);
                Console.WriteLine();
            }

        }
    }
}