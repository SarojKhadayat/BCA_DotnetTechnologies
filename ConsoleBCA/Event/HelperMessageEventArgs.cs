using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Event
{
    public class HelperMessageEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
}
