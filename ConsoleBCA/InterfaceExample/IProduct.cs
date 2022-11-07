using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.InterfaceExample
{
    public interface IProduct
    {
        string GetDetails(int id);
        int ShowPrice(int id);
        int ShowDiscount();

    }
}
