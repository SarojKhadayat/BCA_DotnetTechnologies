using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Inheritance
{
    public class Student : BaseStudent
    {
        public Student() { 
         
        }
        public Student(string fname, string lname, int depId, string depName) : base(fname, lname)
        {
            this.Department = new Department(depId, depName);
        }
        public Department Department { get; set; }
        public int Age { get; set; }


    }
    public class Department
    {
        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string GetDeparmentDetails() {
            return $"{Id} {Name}";
        }
    }
}
