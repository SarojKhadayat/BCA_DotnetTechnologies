using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.ExceptionHandling
{
    public class DivideByFiveException : System.Exception
    {
        public DivideByFiveException(string msg): base(msg){
        }
    }
}
