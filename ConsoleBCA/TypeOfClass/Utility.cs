using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.TypeOfClass
{
    public static class Utility
    {
        public static int Id { get; set; }
        public static void ReturnNothing()
        {
            Console.WriteLine("I am from static class");
        }
        public static string AppendTest(this string str)
        {
            return str + " Test";
        }
    }
}
