using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class AccessProduct
    {
        public bool IsTaxApplicable()
        {
            return new Product(1, "B", "Test").IsTaxApplicable();
        }
    }
}
