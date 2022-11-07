using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.InterfaceExample
{
    public class KitchenUtensils : IProduct
    {
        public string GetDetails(int id)
        {
            Console.WriteLine("This is Kitchen utnesils detail");
            return "Kitchen";
        }

        public int ShowDiscount()
        {
            Console.WriteLine("This is kitchen discount");
            return 5;
        }

        public int ShowPrice(int id)
        {
            Console.WriteLine("This is kitchen price");
            return 500;
        }
    }
}
