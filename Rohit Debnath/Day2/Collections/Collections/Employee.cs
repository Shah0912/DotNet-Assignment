
namespace Collections
{
    public class Employee
    {
        public int EmpID { get; private set; }
        public string EmpName { get; private set; }

        public Employee(int empid, string name)
        {
            EmpID = empid;
            EmpName = name;
        }

        public override string ToString()
        {
            return $"EmpId: {EmpID}    EmpName: {EmpName}";
        }
    }
}
