using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel2
{
    public class Product2 : ProductBase
    {
        public Product2(int id, string code, string name) : base(id, code, name)
        {
        }
        public bool IsTaxApplicable()
        {
            if (Code == "B")
            {
                return true;
            }
            return false;

        }
    }
}
