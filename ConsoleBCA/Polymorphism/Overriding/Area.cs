using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Polymorphism.Overriding
{
    public class Area
    {
        public int Length { get; set; }
        public Area()
        {
            Console.WriteLine("Object created");
        }
        public Area(int length)
        {
            this.Length = length;
            Console.WriteLine("Object created with length {0}", length);
        }
        public virtual double GetArea()
        {
            Console.WriteLine("Area of square from base class.");
            return Length * Length;
        }
    }
}
