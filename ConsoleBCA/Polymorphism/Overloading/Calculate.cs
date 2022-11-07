using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Polymorphism.Overloading
{
    public class Calculate
    {
        public int Sum(int a, int b, int c) {
            return a + b + c;
        }
        public string Sum(string a, string b) {
            return a + b;
        }
        public string Sum(int a, int b)
        {
            return a + b.ToString();
        }
    }
    public class Student { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

}
