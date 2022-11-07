using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Polymorphism.Overriding
{
    public class Triangle : Area
    {
        public int Height { get; set; }
        public Triangle(int length, int height) : base(length)
        {
            this.Height = height;
        }
        public override double GetArea()
        {
            Console.WriteLine("This is area of triangle.");
            return 0.5 * Length * Height;
        }
    }
}
