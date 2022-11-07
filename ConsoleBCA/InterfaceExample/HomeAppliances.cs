using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.InterfaceExample
{
    public class HomeAppliances : IProduct
    {
        public string GetDetails(int id)
        {
            Console.WriteLine("This is home appliances detail");
            return "Home Appliances";
        }

        public int ShowDiscount()
        {
            Console.WriteLine("This is home appliances discount");
            return 10;
        }

        public int ShowPrice(int id)
        {
            Console.WriteLine("This is home appliances price");
            return 100;
        }
    }
}
