using MarksExceptionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Student
    {
        private readonly string id;
        private string name;
        private int marks;

        public string Id {
            get
            {
                return id;
            }
        }

        public Student(string name, int marks)
        {
            id = Guid.NewGuid().ToString();
            this.name = name;
            if (marks < 0)
            {
                throw new MarksNegativeException("Marks cannot be negative");
            }
            else if (marks > 100)
            {
                throw new MarksOverflowException("Marks cannot be greater than 100");
            }
            else
            {
                this.marks = marks;
            }
        }

        public override string ToString()
        {
            return $"Student ID: {Id}\nName: {name}\nMarks: {marks}";
        }
    }
}
