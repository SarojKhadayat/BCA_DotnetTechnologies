using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Product : ProductBase
    {
        public Product(int id, string
             code, string name) : base(id, code, name)
        {

        }
        public bool IsTaxApplicable()
        {
            if (Code == "A")
            {
                return true;
            }
            return false;
        }
    }
}
