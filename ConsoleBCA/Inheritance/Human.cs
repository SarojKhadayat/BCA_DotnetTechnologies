using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Inheritance
{
    public class BaseStudent
    {
        public BaseStudent() { }
        public BaseStudent(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetStudentFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
