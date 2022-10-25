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
            //do nothing
        }

        public static void Display3()
        {

            ArrayList arr = new ArrayList();

            arr3.Add(new student(1, "StudentName1"));
            arr3.Add(new student(2, "StudentName2"));
            arr3.Add(new student(3, "StudentName3"));
            arr3.Add(new student(4, "StudentName4"));
            arr3.Add(new student(5, "StudentName5"));

            Console.WriteLine("Students List");

            foreach (student stud in arr)
            {
                Console.WriteLine($"\nStudent Id: {stud.id} \nStudent Name: {stud.Name}");
            }

        }
    }
}