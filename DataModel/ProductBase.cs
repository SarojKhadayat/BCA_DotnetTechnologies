using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class ProductBase
    {
        public ProductBase(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }

        internal int Id { get; set; }
        internal protected string Code { get; set; }
        internal string Name { get; set; }
    }
}
