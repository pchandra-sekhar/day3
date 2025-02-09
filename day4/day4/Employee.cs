using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string Empname { get; set; }

        public Employee(int id,string name)
        {
            EmpId = id;
            Empname = name;

        }
        public virtual void Display()
        {
            Console.WriteLine(EmpId + " " + Empname);
        }
    }
}
