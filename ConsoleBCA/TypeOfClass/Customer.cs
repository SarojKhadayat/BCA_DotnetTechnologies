using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.TypeOfClass
{
    public class Customer : Common
    {
        public static string StaticProp { get; set; }
        public Customer(int id, string fname, string lname)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
        }

        public override int GetId()
        {
            return 1;
        }

        public override string GetName()
        {
            return FirstName;
        }
        //~Customer() {
        //    Console.WriteLine("Desctructor calling for customer class");
        //}
        public void Finalize()
        {
            Console.WriteLine("Desctructor calling for customer class");
        }
    }
}
