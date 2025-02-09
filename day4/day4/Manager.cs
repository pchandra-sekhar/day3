using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    internal class Manager : Department
    {
        public string Name { get; set; }

        public Manager(int eid,string ename,string dname,decimal sal,string managername) : base(eid,ename,dname,sal)
        {
            Name = ename;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(Name);

        }
    }
}
