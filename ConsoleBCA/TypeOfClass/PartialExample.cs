using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.TypeOfClass
{
    public sealed partial class PartialExample
    {
        public string Address { get; set; }
        public string ContactNumber { get; set; }

    }

    public partial class PartialExample
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }

    }
}
