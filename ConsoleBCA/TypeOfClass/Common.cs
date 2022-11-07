using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.TypeOfClass
{
    public abstract class Common
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract int GetId();

        public virtual string GetName()
        {
            return $"{ FirstName} {LastName}";
        }
    }
}
