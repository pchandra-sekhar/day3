using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    public class Department : Employee
    {
        public string DeptName { get; set; }

        public decimal Salary { get; set; }

        public Department(int id, string name, string dname, decimal salary) : base(id, name)
        {
            DeptName = dname;
            Salary = salary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(DeptName + " " + Salary);
        }




    }
}
