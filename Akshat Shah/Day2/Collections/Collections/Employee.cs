using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Employee
    {
        public readonly string Id;
        public readonly string Name;

        public Employee(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public override string ToString()
        {
            return $"<Employee ID: {Id} Name: {Name}";
        }
    }
}
