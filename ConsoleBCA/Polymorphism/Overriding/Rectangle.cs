using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Polymorphism.Overriding
{
    public class Rectangle : Area
    {
        public int Breadth { get; set; }
        public Rectangle(int length, int breadth) : base(length)
        {
            this.Breadth = breadth;
        }
        public override double GetArea()
        {
            Console.WriteLine("Area of rectangle:");
            return Length * Breadth;
        }
    }
}
